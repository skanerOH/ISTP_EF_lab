namespace FormsLib
{
    partial class FormContractsOfClient
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
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.o_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.offersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.o_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.consumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_percentage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.confinishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consigningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonContractsDelete = new System.Windows.Forms.Button();
            this.buttonContractsAddNew = new System.Windows.Forms.Button();
            this.comboBoxContractType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AllowUserToAddRows = false;
            this.dataGridViewContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContracts.AutoGenerateColumns = false;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.o_name,
            this.o_type,
            this.consumDataGridViewTextBoxColumn,
            this.o_percentage,
            this.confinishdateDataGridViewTextBoxColumn,
            this.consigningdateDataGridViewTextBoxColumn,
            this.clientsDataGridViewTextBoxColumn,
            this.offersDataGridViewTextBoxColumn,
            this.conIDDataGridViewTextBoxColumn,
            this.conclIDDataGridViewTextBoxColumn,
            this.conoIDDataGridViewTextBoxColumn});
            this.dataGridViewContracts.DataSource = this.contractsBindingSource;
            this.dataGridViewContracts.Location = new System.Drawing.Point(13, 59);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.ReadOnly = true;
            this.dataGridViewContracts.Size = new System.Drawing.Size(664, 379);
            this.dataGridViewContracts.TabIndex = 0;
            // 
            // o_name
            // 
            this.o_name.DataPropertyName = "con_o_ID";
            this.o_name.DataSource = this.offersBindingSource;
            this.o_name.DisplayMember = "o_name";
            this.o_name.HeaderText = "Offer name";
            this.o_name.Name = "o_name";
            this.o_name.ReadOnly = true;
            this.o_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.o_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.o_name.ValueMember = "o_ID";
            this.o_name.Width = 120;
            // 
            // offersBindingSource
            // 
            this.offersBindingSource.DataSource = typeof(ClassLib.Offers);
            // 
            // o_type
            // 
            this.o_type.DataPropertyName = "con_o_ID";
            this.o_type.DataSource = this.offersBindingSource;
            this.o_type.DisplayMember = "o_ot_ID";
            this.o_type.HeaderText = "Deposit(1)/Credit(2)";
            this.o_type.Name = "o_type";
            this.o_type.ReadOnly = true;
            this.o_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.o_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.o_type.ValueMember = "o_ID";
            this.o_type.Visible = false;
            // 
            // consumDataGridViewTextBoxColumn
            // 
            this.consumDataGridViewTextBoxColumn.DataPropertyName = "con_sum";
            this.consumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.consumDataGridViewTextBoxColumn.Name = "consumDataGridViewTextBoxColumn";
            this.consumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // o_percentage
            // 
            this.o_percentage.DataPropertyName = "con_o_ID";
            this.o_percentage.DataSource = this.offersBindingSource;
            this.o_percentage.DisplayMember = "o_percentage";
            this.o_percentage.HeaderText = "Percentage";
            this.o_percentage.Name = "o_percentage";
            this.o_percentage.ReadOnly = true;
            this.o_percentage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.o_percentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.o_percentage.ValueMember = "o_ID";
            // 
            // confinishdateDataGridViewTextBoxColumn
            // 
            this.confinishdateDataGridViewTextBoxColumn.DataPropertyName = "con_finish_date";
            this.confinishdateDataGridViewTextBoxColumn.HeaderText = "Finish";
            this.confinishdateDataGridViewTextBoxColumn.Name = "confinishdateDataGridViewTextBoxColumn";
            this.confinishdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consigningdateDataGridViewTextBoxColumn
            // 
            this.consigningdateDataGridViewTextBoxColumn.DataPropertyName = "con_signing_date";
            this.consigningdateDataGridViewTextBoxColumn.HeaderText = "Start";
            this.consigningdateDataGridViewTextBoxColumn.Name = "consigningdateDataGridViewTextBoxColumn";
            this.consigningdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsDataGridViewTextBoxColumn
            // 
            this.clientsDataGridViewTextBoxColumn.DataPropertyName = "Clients";
            this.clientsDataGridViewTextBoxColumn.HeaderText = "Clients";
            this.clientsDataGridViewTextBoxColumn.Name = "clientsDataGridViewTextBoxColumn";
            this.clientsDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientsDataGridViewTextBoxColumn.Visible = false;
            // 
            // offersDataGridViewTextBoxColumn
            // 
            this.offersDataGridViewTextBoxColumn.DataPropertyName = "Offers";
            this.offersDataGridViewTextBoxColumn.HeaderText = "Offers";
            this.offersDataGridViewTextBoxColumn.Name = "offersDataGridViewTextBoxColumn";
            this.offersDataGridViewTextBoxColumn.ReadOnly = true;
            this.offersDataGridViewTextBoxColumn.Visible = false;
            // 
            // conIDDataGridViewTextBoxColumn
            // 
            this.conIDDataGridViewTextBoxColumn.DataPropertyName = "con_ID";
            this.conIDDataGridViewTextBoxColumn.HeaderText = "con_ID";
            this.conIDDataGridViewTextBoxColumn.Name = "conIDDataGridViewTextBoxColumn";
            this.conIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.conIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // conclIDDataGridViewTextBoxColumn
            // 
            this.conclIDDataGridViewTextBoxColumn.DataPropertyName = "con_cl_ID";
            this.conclIDDataGridViewTextBoxColumn.HeaderText = "con_cl_ID";
            this.conclIDDataGridViewTextBoxColumn.Name = "conclIDDataGridViewTextBoxColumn";
            this.conclIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.conclIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // conoIDDataGridViewTextBoxColumn
            // 
            this.conoIDDataGridViewTextBoxColumn.DataPropertyName = "con_o_ID";
            this.conoIDDataGridViewTextBoxColumn.HeaderText = "con_o_ID";
            this.conoIDDataGridViewTextBoxColumn.Name = "conoIDDataGridViewTextBoxColumn";
            this.conoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.conoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataSource = typeof(ClassLib.Contracts);
            // 
            // buttonContractsDelete
            // 
            this.buttonContractsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonContractsDelete.Location = new System.Drawing.Point(13, 13);
            this.buttonContractsDelete.Name = "buttonContractsDelete";
            this.buttonContractsDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonContractsDelete.TabIndex = 1;
            this.buttonContractsDelete.Text = "Delete";
            this.buttonContractsDelete.UseVisualStyleBackColor = true;
            this.buttonContractsDelete.Click += new System.EventHandler(this.buttonContractsDelete_Click);
            // 
            // buttonContractsAddNew
            // 
            this.buttonContractsAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonContractsAddNew.Location = new System.Drawing.Point(169, 13);
            this.buttonContractsAddNew.Name = "buttonContractsAddNew";
            this.buttonContractsAddNew.Size = new System.Drawing.Size(150, 40);
            this.buttonContractsAddNew.TabIndex = 2;
            this.buttonContractsAddNew.Text = "Add new";
            this.buttonContractsAddNew.UseVisualStyleBackColor = true;
            this.buttonContractsAddNew.Click += new System.EventHandler(this.buttonContractsAddNew_Click);
            // 
            // comboBoxContractType
            // 
            this.comboBoxContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxContractType.FormattingEnabled = true;
            this.comboBoxContractType.Items.AddRange(new object[] {
            "Deposit",
            "Credit"});
            this.comboBoxContractType.Location = new System.Drawing.Point(326, 13);
            this.comboBoxContractType.Name = "comboBoxContractType";
            this.comboBoxContractType.Size = new System.Drawing.Size(121, 33);
            this.comboBoxContractType.TabIndex = 3;
            this.comboBoxContractType.SelectedIndexChanged += new System.EventHandler(this.comboBoxContractType_SelectedIndexChanged);
            // 
            // FormContractsOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.comboBoxContractType);
            this.Controls.Add(this.buttonContractsAddNew);
            this.Controls.Add(this.buttonContractsDelete);
            this.Controls.Add(this.dataGridViewContracts);
            this.Name = "FormContractsOfClient";
            this.Text = "Client`s contracts";
            this.Load += new System.EventHandler(this.FormContractsOfClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.BindingSource offersBindingSource;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private System.Windows.Forms.Button buttonContractsDelete;
        private System.Windows.Forms.Button buttonContractsAddNew;
        private System.Windows.Forms.DataGridViewComboBoxColumn o_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn o_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn o_percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn confinishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consigningdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxContractType;
    }
}