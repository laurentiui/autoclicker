using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Logger
    {
        private readonly TextBox txtLog;

        public Logger(TextBox txtLog)
        {
            this.txtLog = txtLog;
        }

        public async Task Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now.ToString("HH:mm:ss")}: {message} {Environment.NewLine}");
        }
    }
}
