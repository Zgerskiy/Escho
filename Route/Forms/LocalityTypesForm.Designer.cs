namespace Route.Forms
{
    partial class LocalityTypesForm
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
            System.Windows.Forms.Label locality_type_nameLabel;
            this.localityTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.localitytypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.locality_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Locality_typeTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.locality_type_nameTextBox = new System.Windows.Forms.TextBox();
            locality_type_nameLabel = new System.Windows.Forms.Label();
            this.localityTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // localityTypeGroupBox
            // 
            this.localityTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localityTypeGroupBox.Controls.Add(locality_type_nameLabel);
            this.localityTypeGroupBox.Controls.Add(this.locality_type_nameTextBox);
            this.localityTypeGroupBox.Controls.Add(this.cancelButton);
            this.localityTypeGroupBox.Controls.Add(this.saveButton);
            this.localityTypeGroupBox.Enabled = false;
            this.localityTypeGroupBox.Location = new System.Drawing.Point(12, 281);
            this.localityTypeGroupBox.Name = "localityTypeGroupBox";
            this.localityTypeGroupBox.Size = new System.Drawing.Size(395, 101);
            this.localityTypeGroupBox.TabIndex = 9;
            this.localityTypeGroupBox.TabStop = false;
            this.localityTypeGroupBox.Text = "Информация о типе населенного пункта";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(90, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 7);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // marksDataGridView
            // 
            this.marksDataGridView.AllowUserToAddRows = false;
            this.marksDataGridView.AllowUserToDeleteRows = false;
            this.marksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksDataGridView.AutoGenerateColumns = false;
            this.marksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localitytypenameDataGridViewTextBoxColumn});
            this.marksDataGridView.DataSource = this.localitytypeBindingSource;
            this.marksDataGridView.Location = new System.Drawing.Point(12, 36);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.ReadOnly = true;
            this.marksDataGridView.RowHeadersVisible = false;
            this.marksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksDataGridView.Size = new System.Drawing.Size(395, 239);
            this.marksDataGridView.TabIndex = 6;
            // 
            // localitytypenameDataGridViewTextBoxColumn
            // 
            this.localitytypenameDataGridViewTextBoxColumn.DataPropertyName = "Locality_type_name";
            this.localitytypenameDataGridViewTextBoxColumn.HeaderText = "Тип нас. пункта";
            this.localitytypenameDataGridViewTextBoxColumn.Name = "localitytypenameDataGridViewTextBoxColumn";
            this.localitytypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitytypeBindingSource
            // 
            this.localitytypeBindingSource.DataMember = "Locality_type";
            this.localitytypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // locality_typeTableAdapter
            // 
            this.locality_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CarViewTableAdapter = null;
            this.tableAdapterManager.Locality_typeTableAdapter = this.locality_typeTableAdapter;
            this.tableAdapterManager.LocalityTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Product_typeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductViewTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.Request_structTableAdapter = null;
            this.tableAdapterManager.RequestStructViewTableAdapter = null;
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.Route_structViewTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopRequestViewTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locality_type_nameLabel
            // 
            locality_type_nameLabel.AutoSize = true;
            locality_type_nameLabel.Location = new System.Drawing.Point(6, 16);
            locality_type_nameLabel.Name = "locality_type_nameLabel";
            locality_type_nameLabel.Size = new System.Drawing.Size(134, 13);
            locality_type_nameLabel.TabIndex = 5;
            locality_type_nameLabel.Text = "Тип населенного пункта:";
            // 
            // locality_type_nameTextBox
            // 
            this.locality_type_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locality_type_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localitytypeBindingSource, "Locality_type_name", true));
            this.locality_type_nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.locality_type_nameTextBox.Name = "locality_type_nameTextBox";
            this.locality_type_nameTextBox.Size = new System.Drawing.Size(383, 20);
            this.locality_type_nameTextBox.TabIndex = 6;
            // 
            // LocalityTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 394);
            this.Controls.Add(this.localityTypeGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.marksDataGridView);
            this.Controls.Add(this.addButton);
            this.Name = "LocalityTypesForm";
            this.Text = "LocalityTypesForm";
            this.Load += new System.EventHandler(this.LocalityTypesForm_Load);
            this.localityTypeGroupBox.ResumeLayout(false);
            this.localityTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox localityTypeGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource localitytypeBindingSource;
        private MilkWorkDataSetTableAdapters.Locality_typeTableAdapter locality_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitytypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox locality_type_nameTextBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}