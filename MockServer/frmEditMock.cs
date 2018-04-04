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
            cboVerb.SelectedIndex = cboVerb.Items.IndexOf("GET");

            cboResponseStatus.DisplayMember = "Text";
            cboResponseStatus.ValueMember = "Value";
            cboResponseStatus.DataSource = lstResponseStatus;
            cboResponseStatus.SelectedIndex = cboResponseStatus.Items.IndexOf("200");

            cboContentType.DisplayMember = "Text";
            cboContentType.ValueMember = "Value";
            cboContentType.DataSource = lstContentType;

            txtContentEncoding.Text = "UTF-8";
            
            this.restMockRepository = new RestMockRepository();
            this.restMock = new RestMock();

            if (this.Id > 0)
            {
                this.restMock = this.restMockRepository.Get(this.Id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var responseDelay = 0;
            int.TryParse(txtResponseDelay.Text, out responseDelay);

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
        }
    }
}
