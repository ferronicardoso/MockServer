﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MockServer
{
    public partial class frmMain : Form
    {
        private Server server;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.txtPort.Text = "3000";
            this.txtPort.Enabled = true;
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.btnMocks.Enabled = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        private void Start()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPort.Text)) txtPort.Text = "3000";

                int port;
                int.TryParse(txtPort.Text, out port);
                if (port <= 0) port = 3000;

                server = new Server(port);
                server.Server_Started += (string message, string url) =>
                {
                    this.txtPort.Enabled = false;
                    this.btnStart.Enabled = false;
                    this.btnStop.Enabled = true;
                    this.btnMocks.Enabled = false;
                    this.WindowState = FormWindowState.Minimized;

                    iconServer.BalloonTipTitle = message;
                    iconServer.BalloonTipText = $"{message}: {url}";
                    iconServer.ShowBalloonTip(3000);
                };
                server.Server_Stopped += (string message) =>
                {
                    this.txtPort.Enabled = true;
                    this.btnStart.Enabled = true;
                    this.btnStop.Enabled = false;
                    this.btnMocks.Enabled = true;

                    iconServer.BalloonTipTitle = message;
                    iconServer.BalloonTipText = $"{message}!";
                    iconServer.ShowBalloonTip(3000);
                };

                server.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stop()
        {
            try
            {
                if (server != null)
                    server.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMocks_Click(object sender, EventArgs e)
        {
            var frmmocks = new frmMocks();
            frmmocks.ShowDialog();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                iconServer.Visible = true;
            }
        }

        private void iconServer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconServer.Visible = false;
        }
    }
}
