using MockServer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockServer
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            getLogData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getLogData();
        }

        private void getLogData()
        {
            var logRepository = new LogRepository();
            var logModel = logRepository.List();
            var logString = new StringBuilder();

            logString.AppendLine(" # Software: Mock Server ");
            logString.AppendLine(" # Version: 1.0 ");
            logString.AppendLine(" # Date: 2001-05-02 17:42:15 ");
            logString.AppendLine(" # Fields: time c-ip cs-method cs-uri-stem sc-status cs-version ");

            foreach (var log in logModel)
            {
                logString.AppendLine($" {log.DateAndTime.ToString("yyyy/MM/dd HH:mm:ss")} {log.Ip} {log.Verb} {log.Path} {log.ResponseStatus} {log.HttpVersion} ");
            }

            txtLog.Text = logString.ToString();
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
    }
}
