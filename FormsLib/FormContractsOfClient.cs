using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ClassLib;

namespace FormsLib
{
    public partial class FormContractsOfClient : Form
    {
        private int cl_id;
        private ClassLib.RegisteredUsers user;
        private ClassLib.BanksDBV2Entities ctx;
        public FormContractsOfClient(int cl_idtemp, ClassLib.RegisteredUsers tempo)
        {
            user = tempo;
            InitializeComponent();
            cl_id = cl_idtemp;

            if (user.access_lvl>0)
            {

            }
            else
            {
                SetSettingsForUser();
            }

            comboBoxContractType.SelectedIndex = 0;
            LoadContracts();
        }

        private void SetSettingsForUser()
        {
            buttonContractsAddNew.Visible = false;
            buttonContractsDelete.Visible = false;
        }

        private void LoadContracts()
        {
            ctx = new BanksDBV2Entities();

            var query = (from c in ctx.Contracts
                         join off in ctx.Offers on c.con_o_ID equals off.o_ID
                         where (c.con_cl_ID == cl_id && off.o_ot_ID == (comboBoxContractType.SelectedIndex + 1))
                        select c);
            query.Load();
            this.contractsBindingSource.DataSource = ctx.Contracts.Local.ToBindingList();

            ctx.Offers.Load();
            this.offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();
        }

        private void FormContractsOfClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonContractsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                contractsBindingSource.RemoveCurrent();
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error");
            }
        }

        private void buttonContractsAddNew_Click(object sender, EventArgs e)
        {
            FormAddNewContract formAddNewContract = new FormAddNewContract(cl_id);
            this.Hide();

            formAddNewContract.ShowDialog();
            formAddNewContract.Dispose();

            this.Show();
            LoadContracts();
        }

        private void comboBoxContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContracts();
        }
    }
}
