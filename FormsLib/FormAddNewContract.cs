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
    public partial class FormAddNewContract : Form
    {
        private int cl_id;
        private ClassLib.BanksDBV2Entities ctx;
        public FormAddNewContract(int cl_idtempo)
        {
            InitializeComponent();
            cl_id = cl_idtempo;
            ctx = new BanksDBV2Entities();
            ctx.OfferType.Load();
            ctx.Conditions.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Banks.Load();
            banksBindingSource.DataSource = ctx.Banks.Local.ToBindingList();

            dateTimePickerFinish.MinDate = DateTime.Now;
            dateTimePickerFinish.Value = DateTime.Now;

            comboBoxOfferType.SelectedIndex = 0;

            LoadOffers();
        }

        private void FormAddNewContract_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadOffers()
        {
            ctx = new BanksDBV2Entities();
            ctx.OfferType.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();
            ctx.Conditions.Load();
            ctx.Banks.Load();
            banksBindingSource.DataSource = ctx.Banks.Local.ToBindingList();
            int CreditCount = (from con in ctx.Contracts
                               join off in ctx.Offers on con.con_o_ID equals off.o_ID
                               join ot in ctx.OfferType on off.o_ot_ID equals ot.ot_ID
                               where (con.con_cl_ID == cl_id && ot.ot_name == "Credit")
                               select con).Count();
            int DepositCount = (from con in ctx.Contracts
                                join off in ctx.Offers on con.con_o_ID equals off.o_ID
                                join ot in ctx.OfferType on off.o_ot_ID equals ot.ot_ID
                                where (con.con_cl_ID == cl_id && ot.ot_name == "Deposit")
                                select con).Count();
            var querry = (from off in ctx.Offers
                          join con in ctx.Conditions on off.o_c_ID equals con.c_ID
                          join ot in ctx.OfferType on off.o_ot_ID equals ot.ot_ID
                          where (con.c_sum_max >= numericUpDownSum.Value &&
                                con.c_sum_min <= numericUpDownSum.Value &&
                                con.c_credit_count_max >= CreditCount &&
                                con.c_deposit_count_min <= DepositCount &&
                                ot.ot_type_int==comboBoxOfferType.SelectedIndex
                                )
                          select off);
            querry.Load();
        }

        private void comboBoxOfferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOffers();
        }

        private void numericUpDownSum_ValueChanged(object sender, EventArgs e)
        {
            LoadOffers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Contracts contract = new Contracts();
                contract.con_cl_ID = cl_id;
                contract.con_o_ID = (int)dataGridView1.CurrentRow.Cells["oIDDataGridViewTextBoxColumn"].Value;
                contract.con_sum = (int)numericUpDownSum.Value;
                int ID;
                if ((from con in ctx.Contracts
                     select con.con_ID).Count() == 0)
                {
                    ID = 0;
                }
                else
                {
                    ID = (from con in ctx.Contracts
                          select con.con_ID).Max();
                }
                contract.con_ID = (int)ID+1;
                contract.con_signing_date = DateTime.Now;
                contract.con_finish_date = dateTimePickerFinish.Value;

                ctx.Contracts.Add(contract);
                ctx.SaveChanges();

                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Something`s gone wrong!");
            }
        }
    }
}
