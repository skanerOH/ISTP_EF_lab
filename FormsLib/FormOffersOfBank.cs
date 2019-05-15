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
    public partial class FormOffersOfBank : Form
    {
        private int b_id;
        private BanksDBV2Entities ctx;

        public FormOffersOfBank(int b_idtempo)
        {
            InitializeComponent();
            ctx = new BanksDBV2Entities();
            b_id = b_idtempo;

            comboBoxOfferType.SelectedIndex = 2;

            ctx.Offers.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Conditions.Load();
            conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();

            ctx.OfferType.Load();
            offerTypeBindingSource.DataSource = ctx.OfferType.Local.ToBindingList();

            ctx.Dispose();
            ctx = new BanksDBV2Entities();

            var query = (from c in ctx.Offers
                         where (c.o_b_ID == b_id)
                         select c);
            query = query.Where(c => c.o_b_ID == b_id);
            query.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Conditions.Load();
            conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();

            ctx.OfferType.Load();
            offerTypeBindingSource.DataSource = ctx.OfferType.Local.ToBindingList();
        }

        private void FormOffersOfBank_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewOffers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dataGridViewOffers[2, dataGridViewOffers.CurrentCell.RowIndex].Value.ToString() == "")
            {
                dataGridViewOffers.Rows[dataGridViewOffers.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
            if (dataGridViewOffers[3, dataGridViewOffers.CurrentCell.RowIndex].Value.ToString() == "")
            {
                dataGridViewOffers.Rows[dataGridViewOffers.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
            if (dataGridViewOffers[4, dataGridViewOffers.CurrentCell.RowIndex].Value.ToString() == "")
            {
                dataGridViewOffers.Rows[dataGridViewOffers.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
            if (dataGridViewOffers[5, dataGridViewOffers.CurrentCell.RowIndex].Value.ToString() == "")
            {
                dataGridViewOffers.Rows[dataGridViewOffers.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
            if (dataGridViewOffers[6, dataGridViewOffers.CurrentCell.RowIndex].Value.ToString() == "")
            {
                dataGridViewOffers.Rows[dataGridViewOffers.CurrentCell.RowIndex].Cells[2].Value = 1;
            }
        }

        private void buttonOffersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Offers offer = (Offers)dataGridViewOffers.CurrentRow.DataBoundItem;
                var temp = (from c in ctx.Contracts where (c.con_o_ID == offer.o_ID) select c).Any();
                if (temp)
                {
                    MessageBox.Show("Can`t delete! Offer has some contracts. You should delete offer`s contracts and then delete the offer.", "Deleting error");
                }
                else
                {
                    offersBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error", "Unknown why");
            }
        }

        private void FindOffers()
        {
            ctx.Dispose();
            ctx = new BanksDBV2Entities();

            var query = (from offer in ctx.Offers
                         join con in ctx.Conditions on offer.o_c_ID equals con.c_ID
                         where (offer.o_b_ID == b_id &&
                                con.c_credit_count_max >= (int)numericUpDownCredCount.Value &&
                                con.c_deposit_count_min <= (int)numericUpDownDepCount.Value &&
                                con.c_sum_max >= (int)numericUpDownSum.Value && con.c_sum_min <= (int)numericUpDownSum.Value)
                         select offer);
            query = query.Where(c => c.o_b_ID == b_id);
            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                query = query.Where(c => c.o_name.Contains(textBoxName.Text));
            }
            if (comboBoxOfferType.SelectedIndex!=2)
            {
                query = query.Where(c => c.o_ot_ID == (comboBoxOfferType.SelectedIndex + 1));
            }

            if ((int)numericUpDownPercentage.Value != 0)
            {
                query = query.Where(c => c.o_percentage == (int)numericUpDownPercentage.Value);
            }
            /*foreach( var offer in query)
            {
                var condition = (from con in ctx.Conditions
                                 where (con.c_ID == offer.o_c_ID &&
                                 con.c_credit_count_max > (int)numericUpDownCredCount.Value &&
                              con.c_deposit_count_min < (int)numericUpDownDepCount.Value &&
                              con.c_sum_max > (int)numericUpDownSum.Value && con.c_sum_min < (int)numericUpDownSum.Value)
                                 select con).Any();
                if (!condition)
                {
                    query = query.Where(c => c.o_ID != offer.o_ID);
                }
            }*/

            //query = query.Where(c => OfferHasCondition(c));

            query.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Conditions.Load();
            conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();

            ctx.OfferType.Load();
            offerTypeBindingSource.DataSource = ctx.OfferType.Local.ToBindingList();
        }

        private bool OfferHasCondition(ClassLib.Offers offer)
        {
            var condition = (from con in ctx.Conditions
                             where (con.c_ID == offer.o_c_ID &&
                             con.c_credit_count_max > (int)numericUpDownCredCount.Value &&
                          con.c_deposit_count_min < (int)numericUpDownDepCount.Value &&
                          con.c_sum_max > (int)numericUpDownSum.Value && con.c_sum_min < (int)numericUpDownSum.Value)
                             select con).Any();
            return condition;
        }

        private void buttonOffersFilter_Click(object sender, EventArgs e)
        {
            FindOffers();
        }

        private void buttonOffersAddNew_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAddNewOffer formAddNewOffer = new FormAddNewOffer(b_id);
            formAddNewOffer.ShowDialog();
            formAddNewOffer.Dispose();

            this.Show();
            ctx.Offers.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Conditions.Load();
            conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();

            ctx.OfferType.Load();
            offerTypeBindingSource.DataSource = ctx.OfferType.Local.ToBindingList();
        }

        private void FormOffersOfBank_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
