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
            if (gridMocks.SelectedRows.Count > 0)
            {
                int id;
                int.TryParse(gridMocks.SelectedRows[0].Cells[0].Value.ToString(), out id);
                var frm = new frmEditMock(id);
                frm.ShowDialog();
                GetMockData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridMocks.SelectedRows.Count > 0)
            {
                int id;
                int.TryParse(gridMocks.SelectedRows[0].Cells[0].Value.ToString(), out id);
                
                if (MessageBox.Show("The selected record will be deleted. Do you wish to continue?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.restMockRepository.Delete(id);
                    GetMockData();
                }
            }
        }
    }
}
