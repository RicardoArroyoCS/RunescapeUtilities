using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace nmz_notification
{
    public partial class NmzForm : Form
    {
        private TimeSpan _timer;
        // DEBUG
        //private TimeSpan _defaultTimer = new TimeSpan(0, 0, 0, 10, 0);
        private delegate void UpdateTimeValue_Delegate(string timeValue);
        private const string _minuteFormat = @"m\:ss";

        public NmzForm()
        {
            bool sucessfulRead = ReadConfig();

            if (sucessfulRead)
            {
                InitializeComponent();

                // Set Up Timer
                _timer = new TimeSpan(0, 0, CountDownMax, 0, 0);
                this.timerLabel.Text = _timer.ToString(_minuteFormat);

                // Player
                this.playerNameTextBox.Text = PlayerName;
            }
            else
            {
                MessageBox.Show("The Input Values for countDownMinutes and/or notificationMessage are invalid. Check the values and try again.");
                this.Close();
            }
        }

        private bool ReadConfig()
        {
            bool successfulParse;
            string countDown = ConfigurationManager.AppSettings.Get("countDownMinutes");                        

            if (successfulParse = int.TryParse(countDown, out int countDownVal))
            {
                CountDownMax = countDownVal;
            }
            
            NotificationMessage = ConfigurationManager.AppSettings.Get("notificationMessage");
            PlayerName = ConfigurationManager.AppSettings.Get("defaultPlayerName");

            return !string.IsNullOrEmpty(NotificationMessage) && successfulParse;
        }

        private string PlayerName
        {
            get;
            set;
        } = "Unknown Player";

        private bool IsCancel
        {
            get;
            set;
        }

        private static string AppId
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("appId");
            }
        }

        private int CountDownMax
        {
            get;
            set;
        }

        private string NotificationMessage
        {
            get;
            set;
        }

        #region Events
        private void playerNameTextBox_Leave(object sender, EventArgs e)
        {
            PlayerName = ((TextBox)sender).Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IsCancel = true;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this.cancelButton.Enabled = true;
            try
            {
                //await StartCountDown();
                // https://stackoverflow.com/questions/33671919/gui-freezes-when-using-async-await
                // https://stackoverflow.com/questions/37629720/update-ui-from-different-thread
                //Action<string> updateTimerAction= UpdateTimerLabel;
                //Progress<string> updateTimerProcess = new Progress<string>(updateTimerAction);

                await Task.Run(() => StartCountDown((Button)sender));
            }
            finally
            {
                this.startButton.Enabled = true;
                this.cancelButton.Enabled = false;
            }
        }    
        #endregion

        private async Task<int> StartCountDown(Button button)
        {
            TimeSpan timeSpanEnd = new TimeSpan(0, 0, 0, 0, 0);
            bool isCountDownComplete = false;            
            var stopWatch = Stopwatch.StartNew();

            while (!isCountDownComplete && !IsCancel)
            {
                TimeSpan remainingTime = _timer.Subtract(stopWatch.Elapsed);

                //UpdateTimerLabel(remainingTime.ToString(@"m\:ss"));
                button.Invoke(new UpdateTimeValue_Delegate(UpdateTimerLabel), remainingTime.ToString(_minuteFormat));
                

                if (remainingTime <= timeSpanEnd)
                {
                    isCountDownComplete = true;
                    if (this.notificationCheckBox.Checked)
                    {
                        SendWindowsToastMessage($"Runescape: {this.PlayerName}", this.NotificationMessage);
                    }

                    //UpdateTimerLabel(_defaultTimer.ToString(@"m\:ss"));
                }
            }

            button.Invoke(new UpdateTimeValue_Delegate(UpdateTimerLabel), _timer.ToString(_minuteFormat));
            IsCancel = false;

            return 1;
        }

        // https://stackoverflow.com/questions/32214716/windows-10-showing-a-toast-notification
        public static void SendWindowsToastMessage(string title, string message)
        {
            Windows.Data.Xml.Dom.XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);
            CreateToastMessage(toastXml, title, message, string.Empty);

            //stringElements[0].AppendChild(toastXml.CreateTextNode($"Line {i}"));
            //stringElements[1].AppendChild(toastXml.CreateTextNode($"Line {i}"));
            //stringElements[2].AppendChild(toastXml.CreateTextNode($"Line {i}"));

            //for (int i = 0; i < stringElements.Length; i++)
            //{
            //    stringElements[i].AppendChild(toastXml.CreateTextNode($"Line {i}"));
            //}

            String imagePath = "file:///" + Path.GetFullPath("..\\..\\assets\\Overload_detail.png");
            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
            imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;

            ToastNotification toast = new ToastNotification(toastXml);

            ToastNotificationManager.CreateToastNotifier(AppId).Show(toast);
        }

        private static void CreateToastMessage(XmlDocument toastXml, string title, string body, string footer)
        {
            XmlNodeList toastNodeList = toastXml.GetElementsByTagName("text");
            toastNodeList[0].AppendChild(toastXml.CreateTextNode(title));
            toastNodeList[1].AppendChild(toastXml.CreateTextNode(body));
            toastNodeList[2].AppendChild(toastXml.CreateTextNode(footer));
        }

        private void UpdateTimerLabel(string timeValue)
        {
            if (!string.IsNullOrEmpty(timeValue))
            {
                this.timerLabel.Text = timeValue;
                this.timerLabel.Refresh();
            }
        }
    }
}
