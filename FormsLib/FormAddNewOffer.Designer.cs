namespace FormsLib
{
    partial class FormAddNewOffer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewConditions = new System.Windows.Forms.DataGridView();
            this.csummaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csumminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdepositcountminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditcountmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclienttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCoditionsSave = new System.Windows.Forms.Button();
            this.buttonConditionsDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOfferType = new System.Windows.Forms.ComboBox();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddOffer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewConditions
            // 
            this.dataGridViewConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConditions.AutoGenerateColumns = false;
            this.dataGridViewConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csummaxDataGridViewTextBoxColumn,
            this.csumminDataGridViewTextBoxColumn,
            this.cdepositcountminDataGridViewTextBoxColumn,
            this.ccreditcountmaxDataGridViewTextBoxColumn,
            this.offersDataGridViewTextBoxColumn,
            this.cclienttypeDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn});
            this.dataGridViewConditions.DataSource = this.conditionsBindingSource;
            this.dataGridViewConditions.Location = new System.Drawing.Point(12, 167);
            this.dataGridViewConditions.Name = "dataGridViewConditions";
            this.dataGridViewConditions.Size = new System.Drawing.Size(446, 271);
            this.dataGridViewConditions.TabIndex = 0;
            // 
            // csummaxDataGridViewTextBoxColumn
            // 
            this.csummaxDataGridViewTextBoxColumn.DataPropertyName = "c_sum_max";
            this.csummaxDataGridViewTextBoxColumn.HeaderText = "Sum max";
            this.csummaxDataGridViewTextBoxColumn.Name = "csummaxDataGridViewTextBoxColumn";
            // 
            // csumminDataGridViewTextBoxColumn
            // 
            this.csumminDataGridViewTextBoxColumn.DataPropertyName = "c_sum_min";
            this.csumminDataGridViewTextBoxColumn.HeaderText = "Sum min";
            this.csumminDataGridViewTextBoxColumn.Name = "csumminDataGridViewTextBoxColumn";
            // 
            // cdepositcountminDataGridViewTextBoxColumn
            // 
            this.cdepositcountminDataGridViewTextBoxColumn.DataPropertyName = "c_deposit_count_min";
            this.cdepositcountminDataGridViewTextBoxColumn.HeaderText = "Min deposit count";
            this.cdepositcountminDataGridViewTextBoxColumn.Name = "cdepositcountminDataGridViewTextBoxColumn";
            // 
            // ccreditcountmaxDataGridViewTextBoxColumn
            // 
            this.ccreditcountmaxDataGridViewTextBoxColumn.DataPropertyName = "c_credit_count_max";
            this.ccreditcountmaxDataGridViewTextBoxColumn.HeaderText = "Max credit count";
            this.ccreditcountmaxDataGridViewTextBoxColumn.Name = "ccreditcountmaxDataGridViewTextBoxColumn";
            // 
            // offersDataGridViewTextBoxColumn
            // 
            this.offersDataGridViewTextBoxColumn.DataPropertyName = "Offers";
            this.offersDataGridViewTextBoxColumn.HeaderText = "Offers";
            this.offersDataGridViewTextBoxColumn.Name = "offersDataGridViewTextBoxColumn";
            this.offersDataGridViewTextBoxColumn.Visible = false;
            // 
            // cclienttypeDataGridViewTextBoxColumn
            // 
            this.cclienttypeDataGridViewTextBoxColumn.DataPropertyName = "c_client_type";
            this.cclienttypeDataGridViewTextBoxColumn.HeaderText = "c_client_type";
            this.cclienttypeDataGridViewTextBoxColumn.Name = "cclienttypeDataGridViewTextBoxColumn";
            this.cclienttypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "c_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "c_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // conditionsBindingSource
            // 
            this.conditionsBindingSource.DataSource = typeof(ClassLib.Conditions);
            // 
            // buttonCoditionsSave
            // 
            this.buttonCoditionsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCoditionsSave.Location = new System.Drawing.Point(12, 131);
            this.buttonCoditionsSave.Name = "buttonCoditionsSave";
            this.buttonCoditionsSave.Size = new System.Drawing.Size(100, 30);
            this.buttonCoditionsSave.TabIndex = 1;
            this.buttonCoditionsSave.Text = "Save";
            this.buttonCoditionsSave.UseVisualStyleBackColor = true;
            this.buttonCoditionsSave.Click += new System.EventHandler(this.buttonCoditionsSave_Click);
            // 
            // buttonConditionsDelete
            // 
            this.buttonConditionsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonConditionsDelete.Location = new System.Drawing.Point(118, 131);
            this.buttonConditionsDelete.Name = "buttonConditionsDelete";
            this.buttonConditionsDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonConditionsDelete.TabIndex = 2;
            this.buttonConditionsDelete.Text = "Delete";
            this.buttonConditionsDelete.UseVisualStyleBackColor = true;
            this.buttonConditionsDelete.Click += new System.EventHandler(this.buttonConditionsDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxName.Location = new System.Drawing.Point(176, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 29);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "New offer`s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "New offer`s type:";
            // 
            // comboBoxOfferType
            // 
            this.comboBoxOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOfferType.FormattingEnabled = true;
            this.comboBoxOfferType.Items.AddRange(new object[] {
            "Deposit",
            "Credit"});
            this.comboBoxOfferType.Location = new System.Drawing.Point(176, 43);
            this.comboBoxOfferType.Name = "comboBoxOfferType";
            this.comboBoxOfferType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOfferType.TabIndex = 7;
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownPercentage.Location = new System.Drawing.Point(189, 79);
            this.numericUpDownPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(108, 29);
            this.numericUpDownPercentage.TabIndex = 8;
            this.numericUpDownPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPercentage.ValueChanged += new System.EventHandler(this.numericUpDownPercentage_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Offer`s percentage:";
            // 
            // buttonAddOffer
            // 
            this.buttonAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonAddOffer.Location = new System.Drawing.Point(308, 8);
            this.buttonAddOffer.Name = "buttonAddOffer";
            this.buttonAddOffer.Size = new System.Drawing.Size(150, 100);
            this.buttonAddOffer.TabIndex = 10;
            this.buttonAddOffer.Text = "ADD OFFER";
            this.buttonAddOffer.UseVisualStyleBackColor = true;
            this.buttonAddOffer.Click += new System.EventHandler(this.buttonAddOffer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 117);
            this.panel1.TabIndex = 11;
            // 
            // FormAddNewOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.buttonAddOffer);
            this.Controls.Add(this.numericUpDownPercentage);
            this.Controls.Add(this.comboBoxOfferType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonConditionsDelete);
            this.Controls.Add(this.buttonCoditionsSave);
            this.Controls.Add(this.dataGridViewConditions);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddNewOffer";
            this.Text = "New offer";
            this.Load += new System.EventHandler(this.FormAddNewOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConditions;
        private System.Windows.Forms.BindingSource conditionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn csummaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csumminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdepositcountminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditcountmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclienttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCoditionsSave;
        private System.Windows.Forms.Button buttonConditionsDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOfferType;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddOffer;
        private System.Windows.Forms.Panel panel1;
    }
}