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
        private ClassLib.RegisteredUsers user;
        private BanksDBV2Entities ctx;

        public FormOffersOfBank(int b_idtempo, ClassLib.RegisteredUsers tempo)
        {
            user = tempo;
            InitializeComponent();
            ctx = new BanksDBV2Entities();
            b_id = b_idtempo;

            if (user.access_lvl>0)
            {

            }
            else
            {
                SetSettingsForUser();
            }

            comboBoxOfferType.SelectedIndex = 2;

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
            if (comboBoxOfferType.SelectedIndex != 2)
            {
                query = query.Where(c => c.o_ot_ID == (comboBoxOfferType.SelectedIndex + 1));
            }

            if ((int)numericUpDownPercentage.Value != 0)
            {
                query = query.Where(c => c.o_percentage == (int)numericUpDownPercentage.Value);
            }

            query.Load();
            offersBindingSource.DataSource = ctx.Offers.Local.ToBindingList();

            ctx.Conditions.Load();
            conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();

            ctx.OfferType.Load();
            offerTypeBindingSource.DataSource = ctx.OfferType.Local.ToBindingList();
        }

        private void SetSettingsForUser()
        {
            buttonOffersAddNew.Visible = false;
            buttonOffersDelete.Visible = false;
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

        private void buttonTransformToXML_Click(object sender, EventArgs e)
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
            if (comboBoxOfferType.SelectedIndex != 2)
            {
                query = query.Where(c => c.o_ot_ID == (comboBoxOfferType.SelectedIndex + 1));
            }

            if ((int)numericUpDownPercentage.Value != 0)
            {
                query = query.Where(c => c.o_percentage == (int)numericUpDownPercentage.Value);
            }

            if (query==null)
            {
                MessageBox.Show("There is nothing to transform");
            }
            else
            {
                TransformToXML(query);
            }
        }

        private void TransformToXML(IQueryable<ClassLib.Offers> offers)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files(*.*|*.*";
            if (saveFileDialog.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            string path = saveFileDialog.FileName;
            TransformationToXML.Transform(offers, path);
            MessageBox.Show("File was successfully created!");
        }
    }
}
