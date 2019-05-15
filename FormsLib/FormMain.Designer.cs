namespace FormsLib
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBanks = new System.Windows.Forms.TabPage();
            this.buttonBanksDelete = new System.Windows.Forms.Button();
            this.buttonBanksSave = new System.Windows.Forms.Button();
            this.dataGridViewBanks = new System.Windows.Forms.DataGridView();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonClientsDelete = new System.Windows.Forms.Button();
            this.buttonClientsSave = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.clnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcltIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clt_text = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBanks);
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBanks
            // 
            this.tabPageBanks.Controls.Add(this.label1);
            this.tabPageBanks.Controls.Add(this.buttonBanksDelete);
            this.tabPageBanks.Controls.Add(this.buttonBanksSave);
            this.tabPageBanks.Controls.Add(this.dataGridViewBanks);
            this.tabPageBanks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBanks.Name = "tabPageBanks";
            this.tabPageBanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBanks.Size = new System.Drawing.Size(768, 412);
            this.tabPageBanks.TabIndex = 0;
            this.tabPageBanks.Text = "Banks";
            this.tabPageBanks.UseVisualStyleBackColor = true;
            this.tabPageBanks.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonBanksDelete
            // 
            this.buttonBanksDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonBanksDelete.Location = new System.Drawing.Point(162, 6);
            this.buttonBanksDelete.Name = "buttonBanksDelete";
            this.buttonBanksDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonBanksDelete.TabIndex = 2;
            this.buttonBanksDelete.Text = "Delete";
            this.buttonBanksDelete.UseVisualStyleBackColor = true;
            this.buttonBanksDelete.Click += new System.EventHandler(this.buttonBanksDelete_Click);
            // 
            // buttonBanksSave
            // 
            this.buttonBanksSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonBanksSave.Location = new System.Drawing.Point(6, 6);
            this.buttonBanksSave.Name = "buttonBanksSave";
            this.buttonBanksSave.Size = new System.Drawing.Size(150, 40);
            this.buttonBanksSave.TabIndex = 1;
            this.buttonBanksSave.Text = "Save";
            this.buttonBanksSave.UseVisualStyleBackColor = true;
            this.buttonBanksSave.Click += new System.EventHandler(this.buttonBanksSave_Click);
            // 
            // dataGridViewBanks
            // 
            this.dataGridViewBanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBanks.AutoGenerateColumns = false;
            this.dataGridViewBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnameDataGridViewTextBoxColumn,
            this.blocationDataGridViewTextBoxColumn,
            this.offersDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn});
            this.dataGridViewBanks.DataSource = this.banksBindingSource;
            this.dataGridViewBanks.Location = new System.Drawing.Point(6, 52);
            this.dataGridViewBanks.Name = "dataGridViewBanks";
            this.dataGridViewBanks.Size = new System.Drawing.Size(756, 336);
            this.dataGridViewBanks.TabIndex = 0;
            this.dataGridViewBanks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBanks_CellDoubleClick);
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // blocationDataGridViewTextBoxColumn
            // 
            this.blocationDataGridViewTextBoxColumn.DataPropertyName = "b_location";
            this.blocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.blocationDataGridViewTextBoxColumn.Name = "blocationDataGridViewTextBoxColumn";
            this.blocationDataGridViewTextBoxColumn.Width = 150;
            // 
            // offersDataGridViewTextBoxColumn
            // 
            this.offersDataGridViewTextBoxColumn.DataPropertyName = "Offers";
            this.offersDataGridViewTextBoxColumn.HeaderText = "Offers";
            this.offersDataGridViewTextBoxColumn.Name = "offersDataGridViewTextBoxColumn";
            this.offersDataGridViewTextBoxColumn.Visible = false;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "b_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "b_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataSource = typeof(ClassLib.Banks);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.label2);
            this.tabPageClients.Controls.Add(this.buttonClientsDelete);
            this.tabPageClients.Controls.Add(this.buttonClientsSave);
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(768, 410);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            this.tabPageClients.Click += new System.EventHandler(this.tabPageClients_Click);
            // 
            // buttonClientsDelete
            // 
            this.buttonClientsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClientsDelete.Location = new System.Drawing.Point(163, 6);
            this.buttonClientsDelete.Name = "buttonClientsDelete";
            this.buttonClientsDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonClientsDelete.TabIndex = 3;
            this.buttonClientsDelete.Text = "Delete";
            this.buttonClientsDelete.UseVisualStyleBackColor = true;
            this.buttonClientsDelete.Click += new System.EventHandler(this.buttonClientsDelete_Click);
            // 
            // buttonClientsSave
            // 
            this.buttonClientsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClientsSave.Location = new System.Drawing.Point(7, 6);
            this.buttonClientsSave.Name = "buttonClientsSave";
            this.buttonClientsSave.Size = new System.Drawing.Size(150, 40);
            this.buttonClientsSave.TabIndex = 2;
            this.buttonClientsSave.Text = "Save";
            this.buttonClientsSave.UseVisualStyleBackColor = true;
            this.buttonClientsSave.Click += new System.EventHandler(this.buttonClientsSave_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnameDataGridViewTextBoxColumn,
            this.clcltIDDataGridViewTextBoxColumn,
            this.clt_text,
            this.clientTypeDataGridViewTextBoxColumn,
            this.contractsDataGridViewTextBoxColumn,
            this.clIDDataGridViewTextBoxColumn});
            this.dataGridViewClients.DataSource = this.clientsBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(7, 52);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(755, 335);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellDoubleClick);
            this.dataGridViewClients.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewClients_DataError);
            // 
            // clnameDataGridViewTextBoxColumn
            // 
            this.clnameDataGridViewTextBoxColumn.DataPropertyName = "cl_name";
            this.clnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.clnameDataGridViewTextBoxColumn.Name = "clnameDataGridViewTextBoxColumn";
            this.clnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // clcltIDDataGridViewTextBoxColumn
            // 
            this.clcltIDDataGridViewTextBoxColumn.DataPropertyName = "cl_clt_ID";
            this.clcltIDDataGridViewTextBoxColumn.HeaderText = "cl_clt_ID";
            this.clcltIDDataGridViewTextBoxColumn.Name = "clcltIDDataGridViewTextBoxColumn";
            this.clcltIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clt_text
            // 
            this.clt_text.DataPropertyName = "cl_clt_ID";
            this.clt_text.DataSource = this.clientTypeBindingSource;
            this.clt_text.DisplayMember = "clt_text";
            this.clt_text.HeaderText = "Client type";
            this.clt_text.Name = "clt_text";
            this.clt_text.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clt_text.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clt_text.ValueMember = "clt_ID";
            // 
            // clientTypeBindingSource
            // 
            this.clientTypeBindingSource.DataSource = typeof(ClassLib.ClientType);
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // contractsDataGridViewTextBoxColumn
            // 
            this.contractsDataGridViewTextBoxColumn.DataPropertyName = "Contracts";
            this.contractsDataGridViewTextBoxColumn.HeaderText = "Contracts";
            this.contractsDataGridViewTextBoxColumn.Name = "contractsDataGridViewTextBoxColumn";
            this.contractsDataGridViewTextBoxColumn.Visible = false;
            // 
            // clIDDataGridViewTextBoxColumn
            // 
            this.clIDDataGridViewTextBoxColumn.DataPropertyName = "cl_ID";
            this.clIDDataGridViewTextBoxColumn.HeaderText = "cl_ID";
            this.clIDDataGridViewTextBoxColumn.Name = "clIDDataGridViewTextBoxColumn";
            this.clIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(ClassLib.Clients);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "*DoubleClick the bank to edit bank`s offers";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(4, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "*DoubleClick the client to edit client`s contracts";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Welcome form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBanks.ResumeLayout(false);
            this.tabPageBanks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBanks;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.DataGridView dataGridViewBanks;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource clientTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcltIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clt_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBanksDelete;
        private System.Windows.Forms.Button buttonBanksSave;
        private System.Windows.Forms.Button buttonClientsDelete;
        private System.Windows.Forms.Button buttonClientsSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

