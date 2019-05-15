namespace FormsLib
{
    partial class FormAddNewContract
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ootIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOfferType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onameDataGridViewTextBoxColumn,
            this.b_name,
            this.opercentageDataGridViewTextBoxColumn,
            this.banksDataGridViewTextBoxColumn,
            this.conditionsDataGridViewTextBoxColumn,
            this.contractsDataGridViewTextBoxColumn,
            this.offerTypeDataGridViewTextBoxColumn,
            this.ootIDDataGridViewTextBoxColumn,
            this.ocIDDataGridViewTextBoxColumn,
            this.obIDDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.offersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            this.onameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b_name
            // 
            this.b_name.DataPropertyName = "o_b_ID";
            this.b_name.DataSource = this.banksBindingSource;
            this.b_name.DisplayMember = "b_name";
            this.b_name.HeaderText = "Bank";
            this.b_name.Name = "b_name";
            this.b_name.ReadOnly = true;
            this.b_name.ValueMember = "b_ID";
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataSource = typeof(ClassLib.Banks);
            // 
            // opercentageDataGridViewTextBoxColumn
            // 
            this.opercentageDataGridViewTextBoxColumn.DataPropertyName = "o_percentage";
            this.opercentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.opercentageDataGridViewTextBoxColumn.Name = "opercentageDataGridViewTextBoxColumn";
            this.opercentageDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ootIDDataGridViewTextBoxColumn
            // 
            this.ootIDDataGridViewTextBoxColumn.DataPropertyName = "o_ot_ID";
            this.ootIDDataGridViewTextBoxColumn.HeaderText = "o_ot_ID";
            this.ootIDDataGridViewTextBoxColumn.Name = "ootIDDataGridViewTextBoxColumn";
            this.ootIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ootIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ocIDDataGridViewTextBoxColumn
            // 
            this.ocIDDataGridViewTextBoxColumn.DataPropertyName = "o_c_ID";
            this.ocIDDataGridViewTextBoxColumn.HeaderText = "o_c_ID";
            this.ocIDDataGridViewTextBoxColumn.Name = "ocIDDataGridViewTextBoxColumn";
            this.ocIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // obIDDataGridViewTextBoxColumn
            // 
            this.obIDDataGridViewTextBoxColumn.DataPropertyName = "o_b_ID";
            this.obIDDataGridViewTextBoxColumn.HeaderText = "o_b_ID";
            this.obIDDataGridViewTextBoxColumn.Name = "obIDDataGridViewTextBoxColumn";
            this.obIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.obIDDataGridViewTextBoxColumn.Visible = false;
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
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePickerFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinish.Location = new System.Drawing.Point(90, 99);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(149, 32);
            this.dateTimePickerFinish.TabIndex = 1;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownSum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSum.Location = new System.Drawing.Point(90, 22);
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
            this.numericUpDownSum.Size = new System.Drawing.Size(149, 32);
            this.numericUpDownSum.TabIndex = 2;
            this.numericUpDownSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSum.ValueChanged += new System.EventHandler(this.numericUpDownSum_ValueChanged);
            // 
            // comboBoxOfferType
            // 
            this.comboBoxOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxOfferType.FormattingEnabled = true;
            this.comboBoxOfferType.Items.AddRange(new object[] {
            "Deposit",
            "Credit"});
            this.comboBoxOfferType.Location = new System.Drawing.Point(90, 60);
            this.comboBoxOfferType.Name = "comboBoxOfferType";
            this.comboBoxOfferType.Size = new System.Drawing.Size(149, 33);
            this.comboBoxOfferType.TabIndex = 3;
            this.comboBoxOfferType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfferType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(-1, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Finish:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonAdd.Location = new System.Drawing.Point(255, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 101);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 118);
            this.panel1.TabIndex = 8;
            // 
            // FormAddNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxOfferType);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddNewContract";
            this.Text = "New contract";
            this.Load += new System.EventHandler(this.FormAddNewContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn b_name;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn opercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ootIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource offersBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.ComboBox comboBoxOfferType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
    }
}