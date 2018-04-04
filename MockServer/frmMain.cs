using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MockServer
{
    public partial class frmMain : Form
    {
        private Server server;
        private Thread ServerThread;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeComponent();
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
                var port = 3000;
                if (string.IsNullOrWhiteSpace(txtPort.Text) || !int.TryParse(txtPort.Text, out port))
                {
                    txtPort.Text = "3000";
                    int.TryParse(txtPort.Text, out port);
                }
                
                server = new Server(port);
                ServerThread = new Thread(server.Start);
                ServerThread.Start();
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
    }
}
