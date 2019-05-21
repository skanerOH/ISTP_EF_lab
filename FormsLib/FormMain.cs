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
    public partial class FormMain : Form
    {
        private ClassLib.BanksDBV2Entities ctx;
        private ClassLib.RegisteredUsers logedInUser;

        public FormMain(ClassLib.RegisteredUsers temp)
        {
            logedInUser = temp;
            InitializeComponent();

            if (logedInUser.access_lvl>0)
            {

            }
            else
            {
                SetSettingForUser();
            }
            ctx = new BanksDBV2Entities();

            ctx.Banks.Load();
            this.banksBindingSource.DataSource = ctx.Banks.Local.ToBindingList();

            ctx.Clients.Load();
            this.clientsBindingSource.DataSource = ctx.Clients.Local.ToBindingList();

            ctx.ClientType.Load();
            this.clientTypeBindingSource.DataSource = ctx.ClientType.Local.ToBindingList();
        }

        private void SetSettingForUser()
        {
            dataGridViewBanks.ReadOnly = true;
            dataGridViewBanks.AllowUserToAddRows = false;
            dataGridViewBanks.AllowUserToDeleteRows = false;

            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewClients.AllowUserToAddRows = false;

            buttonBanksDelete.Visible = false;

            buttonBanksSave.Visible = false;

            buttonClientsDelete.Visible = false;

            buttonClientsSave.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void tabPageClients_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dataGridViewClients[2,dataGridViewClients.CurrentCell.RowIndex].Value.ToString()=="")
            {
                dataGridViewClients.Rows[dataGridViewClients.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
        }

        private void buttonBanksSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonBanksDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Banks ban = (Banks)dataGridViewBanks.CurrentRow.DataBoundItem;
                var temp = (from c in ctx.Offers where (c.o_b_ID == ban.b_ID) select c).Any();
                if (temp)
                {
                    MessageBox.Show("Can`t delete! Bank has some offers. You should delete bank`s offers and then delete the bank.", "Deleting error");
                }
                else
                {
                    banksBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error", "Unknown why");
            }
        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonClientsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Clients client = (Clients)dataGridViewClients.CurrentRow.DataBoundItem;
                var temp = (from c in ctx.Contracts where (c.con_cl_ID == client.cl_ID) select c).Any();
                if (temp)
                {
                    MessageBox.Show("Can`t delete! Client has some contracts. You should delete client`s contracts and then delete the client.", "Deleting error");
                }
                else
                {
                    clientsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error", "Unknown why");
            }
        }

        private void dataGridViewBanks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int b_id = (int)dataGridViewBanks.CurrentRow.Cells["biddataGridViewTextBoxColumn"].Value;
            this.Hide();
            FormOffersOfBank formOffersOfBank = new FormOffersOfBank(b_id,logedInUser);

            formOffersOfBank.ShowDialog();
            formOffersOfBank.Dispose();

            this.Show();
        }

        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cl_id = (int)dataGridViewClients.CurrentRow.Cells["cliddataGridViewTextBoxColumn"].Value;
            this.Hide();
            FormContractsOfClient formContractsOfClient = new FormContractsOfClient(cl_id,logedInUser);

            formContractsOfClient.ShowDialog();
            formContractsOfClient.Dispose();

            this.Show();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
