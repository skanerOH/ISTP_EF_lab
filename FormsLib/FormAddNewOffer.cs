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
    public partial class FormAddNewOffer : Form
    {
        private ClassLib.BanksDBV2Entities ctx;
        private int b_id;

        public FormAddNewOffer(int b_idtempo)
        {
            InitializeComponent();
            ctx = new ClassLib.BanksDBV2Entities();
            b_id = b_idtempo;
            comboBoxOfferType.SelectedIndex = 0;

            ctx.Offers.Load();
            ctx.Conditions.Load();
            this.conditionsBindingSource.DataSource = ctx.Conditions.Local.ToBindingList();
        }

        private void FormAddNewOffer_Load(object sender, EventArgs e)
        {

        }

        private void buttonCoditionsSave_Click(object sender, EventArgs e)
        {

            ctx.SaveChanges();
        }

        private void buttonConditionsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Conditions condition = (Conditions)dataGridViewConditions.CurrentRow.DataBoundItem;
                var temp = (from c in ctx.Offers where (c.o_c_ID == condition.c_ID) select c).Any();
                if (temp)
                {
                    MessageBox.Show("Can`t delete! Condition is used in some offers.", "Deleting error");
                }
                else
                {
                    conditionsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error", "Unknown why");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPercentage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddOffer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.Text.Length>255)
            {
                Offers offer = new Offers();
                offer.o_b_ID = b_id;
                offer.o_c_ID = (int)dataGridViewConditions.CurrentRow.Cells["ciddataGridViewTextBoxColumn"].Value;
                offer.o_name = textBoxName.Text;
                offer.o_ot_ID = comboBoxOfferType.SelectedIndex + 1;
                offer.o_percentage = (int)numericUpDownPercentage.Value;
                int lastoffer;
                if ((from c in ctx.Offers
                     select c.o_ID).Count() == 0)
                {
                    lastoffer = 0;
                }
                else
                {
                    lastoffer = (from c in ctx.Offers
                                 select c.o_ID).Max();
                }
                offer.o_ID = lastoffer + 1;
                ctx.Offers.Add(offer);
                ctx.SaveChanges();
                ctx.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Change offer`s name", "Error");
            }
        }
    }
}
