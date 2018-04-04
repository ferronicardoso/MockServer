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
    public partial class frmMocks : Form
    {
        private RestMockRepository restMockRepository;

        public frmMocks()
        {
            InitializeComponent();
        }

        private void frmMocks_Load(object sender, EventArgs e)
        {
            GetMockData();
        }

        private void GetMockData()
        {
            restMockRepository = new RestMockRepository();
            var mocks = restMockRepository.List();
            gridMocks.AutoGenerateColumns = false;
            gridMocks.DataSource = mocks.ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frm = new frmEditMock();
            frm.ShowDialog();
            GetMockData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frm = new frmEditMock();
            frm.ShowDialog();
            GetMockData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
