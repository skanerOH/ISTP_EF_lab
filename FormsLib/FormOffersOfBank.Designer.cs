namespace FormsLib
{
    partial class FormOffersOfBank
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
            this.dataGridViewOffers = new System.Windows.Forms.DataGridView();
            this.c_summax = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_sum_min = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_min_deposit_count = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_credit_max_count = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ot_text = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCredCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOfferType = new System.Windows.Forms.ComboBox();
            this.buttonOffersDelete = new System.Windows.Forms.Button();
            this.buttonOffersFilter = new System.Windows.Forms.Button();
            this.buttonOffersAddNew = new System.Windows.Forms.Button();
            this.buttonTransformToXML = new System.Windows.Forms.Button();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ootIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOffers
            // 
            this.dataGridViewOffers.AllowUserToAddRows = false;
            this.dataGridViewOffers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOffers.AutoGenerateColumns = false;
            this.dataGridViewOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onameDataGridViewTextBoxColumn,
            this.opercentageDataGridViewTextBoxColumn,
            this.c_summax,
            this.c_sum_min,
            this.c_min_deposit_count,
            this.c_credit_max_count,
            this.ot_text,
            this.ocIDDataGridViewTextBoxColumn,
            this.ootIDDataGridViewTextBoxColumn,
            this.obIDDataGridViewTextBoxColumn,
            this.banksDataGridViewTextBoxColumn,
            this.conditionsDataGridViewTextBoxColumn,
            this.contractsDataGridViewTextBoxColumn,
            this.offerTypeDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn});
            this.dataGridViewOffers.DataSource = this.offersBindingSource;
            this.dataGridViewOffers.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewOffers.Name = "dataGridViewOffers";
            this.dataGridViewOffers.ReadOnly = true;
            this.dataGridViewOffers.Size = new System.Drawing.Size(714, 334);
            this.dataGridViewOffers.TabIndex = 0;
            this.dataGridViewOffers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOffers_DataError);
            // 
            // c_summax
            // 
            this.c_summax.DataPropertyName = "o_c_ID";
            this.c_summax.DataSource = this.conditionsBindingSource;
            this.c_summax.DisplayMember = "c_sum_max";
            this.c_summax.HeaderText = "Max sum";
            this.c_summax.Name = "c_summax";
            this.c_summax.ReadOnly = true;
            this.c_summax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_summax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_summax.ValueMember = "c_ID";
            this.c_summax.Width = 75;
            // 
            // c_sum_min
            // 
            this.c_sum_min.DataPropertyName = "o_c_ID";
            this.c_sum_min.DataSource = this.conditionsBindingSource;
            this.c_sum_min.DisplayMember = "c_sum_min";
            this.c_sum_min.HeaderText = "Min sum";
            this.c_sum_min.Name = "c_sum_min";
            this.c_sum_min.ReadOnly = true;
            this.c_sum_min.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_sum_min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_sum_min.ValueMember = "c_ID";
            this.c_sum_min.Width = 75;
            // 
            // c_min_deposit_count
            // 
            this.c_min_deposit_count.DataPropertyName = "o_c_ID";
            this.c_min_deposit_count.DataSource = this.conditionsBindingSource;
            this.c_min_deposit_count.DisplayMember = "c_deposit_count_min";
            this.c_min_deposit_count.HeaderText = "Min count of deposits";
            this.c_min_deposit_count.Name = "c_min_deposit_count";
            this.c_min_deposit_count.ReadOnly = true;
            this.c_min_deposit_count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_min_deposit_count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_min_deposit_count.ValueMember = "c_ID";
            // 
            // c_credit_max_count
            // 
            this.c_credit_max_count.DataPropertyName = "o_c_ID";
            this.c_credit_max_count.DataSource = this.conditionsBindingSource;
            this.c_credit_max_count.DisplayMember = "c_credit_count_max";
            this.c_credit_max_count.HeaderText = "Max count of credits";
            this.c_credit_max_count.Name = "c_credit_max_count";
            this.c_credit_max_count.ReadOnly = true;
            this.c_credit_max_count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_credit_max_count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_credit_max_count.ValueMember = "c_ID";
            // 
            // ot_text
            // 
            this.ot_text.DataPropertyName = "o_ot_ID";
            this.ot_text.DataSource = this.offerTypeBindingSource;
            this.ot_text.DisplayMember = "ot_name";
            this.ot_text.HeaderText = "Offer type";
            this.ot_text.Name = "ot_text";
            this.ot_text.ReadOnly = true;
            this.ot_text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ot_text.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ot_text.ValueMember = "ot_ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxName.Location = new System.Drawing.Point(54, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownPercentage.Location = new System.Drawing.Point(181, 69);
            this.numericUpDownPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(93, 29);
            this.numericUpDownPercentage.TabIndex = 2;
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownSum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSum.Location = new System.Drawing.Point(281, 69);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDownSum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.Size = new System.Drawing.Size(142, 29);
            this.numericUpDownSum.TabIndex = 3;
            this.numericUpDownSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownDepCount
            // 
            this.numericUpDownDepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownDepCount.Location = new System.Drawing.Point(429, 69);
            this.numericUpDownDepCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDepCount.Name = "numericUpDownDepCount";
            this.numericUpDownDepCount.Size = new System.Drawing.Size(93, 29);
            this.numericUpDownDepCount.TabIndex = 4;
            // 
            // numericUpDownCredCount
            // 
            this.numericUpDownCredCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownCredCount.Location = new System.Drawing.Point(528, 69);
            this.numericUpDownCredCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCredCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCredCount.Name = "numericUpDownCredCount";
            this.numericUpDownCredCount.Size = new System.Drawing.Size(93, 29);
            this.numericUpDownCredCount.TabIndex = 5;
            this.numericUpDownCredCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxOfferType
            // 
            this.comboBoxOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOfferType.FormattingEnabled = true;
            this.comboBoxOfferType.Items.AddRange(new object[] {
            "Deposit",
            "Credit",
            "All"});
            this.comboBoxOfferType.Location = new System.Drawing.Point(627, 66);
            this.comboBoxOfferType.Name = "comboBoxOfferType";
            this.comboBoxOfferType.Size = new System.Drawing.Size(98, 32);
            this.comboBoxOfferType.TabIndex = 6;
            // 
            // buttonOffersDelete
            // 
            this.buttonOffersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonOffersDelete.Location = new System.Drawing.Point(54, 24);
            this.buttonOffersDelete.Name = "buttonOffersDelete";
            this.buttonOffersDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonOffersDelete.TabIndex = 7;
            this.buttonOffersDelete.Text = "Delete";
            this.buttonOffersDelete.UseVisualStyleBackColor = true;
            this.buttonOffersDelete.Click += new System.EventHandler(this.buttonOffersDelete_Click);
            // 
            // buttonOffersFilter
            // 
            this.buttonOffersFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonOffersFilter.Location = new System.Drawing.Point(210, 24);
            this.buttonOffersFilter.Name = "buttonOffersFilter";
            this.buttonOffersFilter.Size = new System.Drawing.Size(150, 40);
            this.buttonOffersFilter.TabIndex = 8;
            this.buttonOffersFilter.Text = "Filter";
            this.buttonOffersFilter.UseVisualStyleBackColor = true;
            this.buttonOffersFilter.Click += new System.EventHandler(this.buttonOffersFilter_Click);
            // 
            // buttonOffersAddNew
            // 
            this.buttonOffersAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonOffersAddNew.Location = new System.Drawing.Point(366, 24);
            this.buttonOffersAddNew.Name = "buttonOffersAddNew";
            this.buttonOffersAddNew.Size = new System.Drawing.Size(150, 40);
            this.buttonOffersAddNew.TabIndex = 9;
            this.buttonOffersAddNew.Text = "AddNew";
            this.buttonOffersAddNew.UseVisualStyleBackColor = true;
            this.buttonOffersAddNew.Click += new System.EventHandler(this.buttonOffersAddNew_Click);
            // 
            // buttonTransformToXML
            // 
            this.buttonTransformToXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonTransformToXML.Location = new System.Drawing.Point(522, 24);
            this.buttonTransformToXML.Name = "buttonTransformToXML";
            this.buttonTransformToXML.Size = new System.Drawing.Size(203, 40);
            this.buttonTransformToXML.TabIndex = 10;
            this.buttonTransformToXML.Text = "Transform to XML";
            this.buttonTransformToXML.UseVisualStyleBackColor = true;
            this.buttonTransformToXML.Click += new System.EventHandler(this.buttonTransformToXML_Click);
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            this.onameDataGridViewTextBoxColumn.ReadOnly = true;
            this.onameDataGridViewTextBoxColumn.Width = 120;
            // 
            // opercentageDataGridViewTextBoxColumn
            // 
            this.opercentageDataGridViewTextBoxColumn.DataPropertyName = "o_percentage";
            this.opercentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.opercentageDataGridViewTextBoxColumn.Name = "opercentageDataGridViewTextBoxColumn";
            this.opercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionsBindingSource
            // 
            this.conditionsBindingSource.DataSource = typeof(ClassLib.Conditions);
            // 
            // offerTypeBindingSource
            // 
            this.offerTypeBindingSource.DataSource = typeof(ClassLib.OfferType);
            // 
            // ocIDDataGridViewTextBoxColumn
            // 
            this.ocIDDataGridViewTextBoxColumn.DataPropertyName = "o_c_ID";
            this.ocIDDataGridViewTextBoxColumn.HeaderText = "o_c_ID";
            this.ocIDDataGridViewTextBoxColumn.Name = "ocIDDataGridViewTextBoxColumn";
            this.ocIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ootIDDataGridViewTextBoxColumn
            // 
            this.ootIDDataGridViewTextBoxColumn.DataPropertyName = "o_ot_ID";
            this.ootIDDataGridViewTextBoxColumn.HeaderText = "o_ot_ID";
            this.ootIDDataGridViewTextBoxColumn.Name = "ootIDDataGridViewTextBoxColumn";
            this.ootIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ootIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // obIDDataGridViewTextBoxColumn
            // 
            this.obIDDataGridViewTextBoxColumn.DataPropertyName = "o_b_ID";
            this.obIDDataGridViewTextBoxColumn.HeaderText = "o_b_ID";
            this.obIDDataGridViewTextBoxColumn.Name = "obIDDataGridViewTextBoxColumn";
            this.obIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.obIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // banksDataGridViewTextBoxColumn
            // 
            this.banksDataGridViewTextBoxColumn.DataPropertyName = "Banks";
            this.banksDataGridViewTextBoxColumn.HeaderText = "Banks";
            this.banksDataGridViewTextBoxColumn.Name = "banksDataGridViewTextBoxColumn";
            this.banksDataGridViewTextBoxColumn.ReadOnly = true;
            this.banksDataGridViewTextBoxColumn.Visible = false;
            // 
            // conditionsDataGridViewTextBoxColumn
            // 
            this.conditionsDataGridViewTextBoxColumn.DataPropertyName = "Conditions";
            this.conditionsDataGridViewTextBoxColumn.HeaderText = "Conditions";
            this.conditionsDataGridViewTextBoxColumn.Name = "conditionsDataGridViewTextBoxColumn";
            this.conditionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // contractsDataGridViewTextBoxColumn
            // 
            this.contractsDataGridViewTextBoxColumn.DataPropertyName = "Contracts";
            this.contractsDataGridViewTextBoxColumn.HeaderText = "Contracts";
            this.contractsDataGridViewTextBoxColumn.Name = "contractsDataGridViewTextBoxColumn";
            this.contractsDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractsDataGridViewTextBoxColumn.Visible = false;
            // 
            // offerTypeDataGridViewTextBoxColumn
            // 
            this.offerTypeDataGridViewTextBoxColumn.DataPropertyName = "OfferType";
            this.offerTypeDataGridViewTextBoxColumn.HeaderText = "OfferType";
            this.offerTypeDataGridViewTextBoxColumn.Name = "offerTypeDataGridViewTextBoxColumn";
            this.offerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.offerTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "o_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "o_ID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // offersBindingSource
            // 
            this.offersBindingSource.DataSource = typeof(ClassLib.Offers);
            // 
            // FormOffersOfBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.buttonTransformToXML);
            this.Controls.Add(this.buttonOffersAddNew);
            this.Controls.Add(this.buttonOffersFilter);
            this.Controls.Add(this.buttonOffersDelete);
            this.Controls.Add(this.comboBoxOfferType);
            this.Controls.Add(this.numericUpDownCredCount);
            this.Controls.Add(this.numericUpDownDepCount);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.numericUpDownPercentage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewOffers);
            this.Name = "FormOffersOfBank";
            this.Text = "Bank`s offers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOffersOfBank_FormClosed);
            this.Load += new System.EventHandler(this.FormOffersOfBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOffers;
        private System.Windows.Forms.BindingSource offersBindingSource;
        private System.Windows.Forms.BindingSource conditionsBindingSource;
        private System.Windows.Forms.BindingSource offerTypeBindingSource;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.NumericUpDown numericUpDownDepCount;
        private System.Windows.Forms.NumericUpDown numericUpDownCredCount;
        private System.Windows.Forms.ComboBox comboBoxOfferType;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_summax;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_sum_min;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_min_deposit_count;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_credit_max_count;
        private System.Windows.Forms.DataGridViewComboBoxColumn ot_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ootIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonOffersDelete;
        private System.Windows.Forms.Button buttonOffersFilter;
        private System.Windows.Forms.Button buttonOffersAddNew;
        private System.Windows.Forms.Button buttonTransformToXML;
    }
}