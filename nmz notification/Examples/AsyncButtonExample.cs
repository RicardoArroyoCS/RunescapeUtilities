

    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Windows.Forms;
     
    namespace AsyncUI
    {
        // https://stackoverflow.com/questions/661561/how-to-update-the-gui-from-another-thread-in-c 
        public partial class Form1 : Form
        {
            private Control logTb;
            public Form1()
            {
                //InitializeComponent();
            }
     
            private async void startBtn_Click(object sender, EventArgs e)
            {
                await Task.Run(() =>
                {
                        SetControlPropertyThreadSafe(logTb, "Text", "Log Started\n");
                        for (int a = 0; a < 10; a++)
                        {
                            System.Threading.Thread.Sleep(1000);
                            string log = logTb.Text + a.ToString() + Environment.NewLine;
                            SetControlPropertyThreadSafe(logTb, "Text", log);
                        }
                        SetControlPropertyThreadSafe(logTb, "Text", "Log Ended\n");
                });
            }
     
            private void dlgBtn_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Clicked!");
            }

            private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
     
            public static void SetControlPropertyThreadSafe(Control control,string propertyName, object propertyValue)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new SetControlPropertyThreadSafeDelegate
                    (SetControlPropertyThreadSafe),
                    new object[] { control, propertyName, propertyValue });
                }
                else
                {
                    control.GetType().InvokeMember(
                        propertyName,
                        BindingFlags.SetProperty,
                        null,
                        control,
                        new object[] { propertyValue });
                }
            }
        }
    } 
