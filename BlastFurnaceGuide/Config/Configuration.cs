using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlastFurnaceGuide.Config
{
    public static class Configuration
    {
        public const string NextHotKey_Key = "nextHotKey";
        private static string _nextHotKey = null;
        private static Keys _nextHotKeyData = Keys.None;

        public static string NextHotKey
        {
            get
            {
                if(_nextHotKey == null)
                {
                    if (ConfigurationManager.AppSettings[NextHotKey_Key] != null)
                    {
                        _nextHotKey = ConfigurationManager.AppSettings[NextHotKey_Key];
                    }

                }

                return _nextHotKey;
            }
        }

        public static Keys NextHotKeyData
        {
            get
            {
                if(_nextHotKeyData == Keys.None && NextHotKey != null)
                {
                    if (Enum.TryParse<Keys>(NextHotKey, out Keys attemptParse))
                    {
                        _nextHotKeyData = attemptParse;
                    }
                }

                return _nextHotKeyData;
            }
        }
    }
}
