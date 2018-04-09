using MockServer.Models;
using MockServer.Repositories;
using Newtonsoft.Json;
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
    public partial class frmEditMock : Form
    {
        private int Id;
        private RestMockRepository restMockRepository;
        private RestMock restMock;

        public frmEditMock()
        {
            InitializeComponent();
        }

        public frmEditMock(int id)
        {
            InitializeComponent();
            this.Id = id;
        }
                
        private void frmEditMock_Load(object sender, EventArgs e)
        {
            var lstVerbs = Utils.GetVerbList();
            var lstResponseStatus = Utils.GetResponseStatusList();
            var lstContentType = Utils.GetContentTypeList();
            
            cboVerb.DisplayMember = "Text";
            cboVerb.ValueMember = "Value";
            cboVerb.DataSource = lstVerbs;
            cboVerb.SelectedValue = "GET";

            cboResponseStatus.DisplayMember = "Text";
            cboResponseStatus.ValueMember = "Value";
            cboResponseStatus.DataSource = lstResponseStatus;
            cboResponseStatus.SelectedValue = "200";

            cboContentType.DisplayMember = "Text";
            cboContentType.ValueMember = "Value";
            cboContentType.DataSource = lstContentType;

            txtContentEncoding.Text = "UTF-8";
            
            this.restMockRepository = new RestMockRepository();
            this.restMock = new RestMock();

            if (this.Id > 0)
            {
                this.restMock = this.restMockRepository.Get(this.Id);

                txtDisplayName.Text = this.restMock.DisplayName;
                txtDescription.Text = this.restMock.Description;
                txtPath.Text = this.restMock.Path;
                cboResponseStatus.SelectedValue = this.restMock.ResponseStatus.ToString();
                cboVerb.SelectedValue = this.restMock.Verb;
                cboContentType.Text = this.restMock.ContentType;
                txtContentEncoding.Text = this.restMock.ContentEncoding;
                txtResponseBody.Text = this.restMock.ResponseBody;
                txtResponseDelay.Text = this.restMock.ResponseDelay.ToString();
                chkResponseDelay.Checked = this.restMock.ResponseDelay > 0;
                chkActive.Checked = this.restMock.Active;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var responseDelay = 0;
            int.TryParse(txtResponseDelay.Text, out responseDelay);
            if (chkResponseDelay.Checked) responseDelay = 0;

            this.restMock.DisplayName = txtDisplayName.Text;
            this.restMock.Description = txtDescription.Text;
            this.restMock.Path = txtPath.Text;
            this.restMock.ResponseStatus = int.Parse(cboResponseStatus.SelectedValue.ToString());
            this.restMock.Verb = cboVerb.SelectedValue.ToString();
            this.restMock.ContentType = cboContentType.SelectedValue.ToString();
            this.restMock.ContentEncoding = txtContentEncoding.Text;
            this.restMock.ResponseBody = txtResponseBody.Text;
            this.restMock.ResponseDelay = responseDelay;
            this.restMock.Active = chkActive.Checked;

            if (this.restMock.IdRestMock > 0)
            {
                this.restMockRepository.Update(this.restMock);
            }
            else
            {
                this.restMockRepository.Add(this.restMock);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkResponseDelay_CheckedChanged(object sender, EventArgs e)
        {
            txtResponseDelay.Enabled = chkResponseDelay.Checked;
        }
    }
}
