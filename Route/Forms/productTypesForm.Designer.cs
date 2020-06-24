namespace Route.Forms
{
    partial class productTypesForm
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
            System.Windows.Forms.Label product_type_nameLabel;
            this.prodTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.product_type_nameTextBox = new System.Windows.Forms.TextBox();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.prodTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.producttypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.product_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Product_typeTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            product_type_nameLabel = new System.Windows.Forms.Label();
            this.prodTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_type_nameLabel
            // 
            product_type_nameLabel.AutoSize = true;
            product_type_nameLabel.Location = new System.Drawing.Point(6, 16);
            product_type_nameLabel.Name = "product_type_nameLabel";
            product_type_nameLabel.Size = new System.Drawing.Size(78, 13);
            product_type_nameLabel.TabIndex = 5;
            product_type_nameLabel.Text = "Тип продукта:";
            // 
            // prodTypeGroupBox
            // 
            this.prodTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodTypeGroupBox.Controls.Add(product_type_nameLabel);
            this.prodTypeGroupBox.Controls.Add(this.product_type_nameTextBox);
            this.prodTypeGroupBox.Controls.Add(this.cancelButton);
            this.prodTypeGroupBox.Controls.Add(this.saveButton);
            this.prodTypeGroupBox.Enabled = false;
            this.prodTypeGroupBox.Location = new System.Drawing.Point(12, 281);
            this.prodTypeGroupBox.MaximumSize = new System.Drawing.Size(270, 88);
            this.prodTypeGroupBox.MinimumSize = new System.Drawing.Size(270, 88);
            this.prodTypeGroupBox.Name = "prodTypeGroupBox";
            this.prodTypeGroupBox.Size = new System.Drawing.Size(270, 88);
            this.prodTypeGroupBox.TabIndex = 14;
            this.prodTypeGroupBox.TabStop = false;
            this.prodTypeGroupBox.Text = "Информация о типе продукта";
            // 
            // product_type_nameTextBox
            // 
            this.product_type_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_type_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producttypeBindingSource, "Product_type_name", true));
            this.product_type_nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.product_type_nameTextBox.Name = "product_type_nameTextBox";
            this.product_type_nameTextBox.Size = new System.Drawing.Size(258, 20);
            this.product_type_nameTextBox.TabIndex = 6;
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "Product_type";
            this.producttypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 7);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // prodTypesDataGridView
            // 
            this.prodTypesDataGridView.AllowUserToAddRows = false;
            this.prodTypesDataGridView.AllowUserToDeleteRows = false;
            this.prodTypesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodTypesDataGridView.AutoGenerateColumns = false;
            this.prodTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producttypenameDataGridViewTextBoxColumn});
            this.prodTypesDataGridView.DataSource = this.producttypeBindingSource;
            this.prodTypesDataGridView.Location = new System.Drawing.Point(12, 36);
            this.prodTypesDataGridView.Name = "prodTypesDataGridView";
            this.prodTypesDataGridView.ReadOnly = true;
            this.prodTypesDataGridView.RowHeadersVisible = false;
            this.prodTypesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodTypesDataGridView.Size = new System.Drawing.Size(270, 239);
            this.prodTypesDataGridView.TabIndex = 11;
            // 
            // producttypenameDataGridViewTextBoxColumn
            // 
            this.producttypenameDataGridViewTextBoxColumn.DataPropertyName = "Product_type_name";
            this.producttypenameDataGridViewTextBoxColumn.HeaderText = "Тип продукта";
            this.producttypenameDataGridViewTextBoxColumn.Name = "producttypenameDataGridViewTextBoxColumn";
            this.producttypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CarViewTableAdapter = null;
            this.tableAdapterManager.Locality_typeTableAdapter = null;
            this.tableAdapterManager.LocalityTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Product_typeTableAdapter = this.product_typeTableAdapter;
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
            // productTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 381);
            this.Controls.Add(this.prodTypeGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.prodTypesDataGridView);
            this.Controls.Add(this.addButton);
            this.MinimumSize = new System.Drawing.Size(310, 420);
            this.Name = "productTypesForm";
            this.Text = "Справочник типов продуктов";
            this.Load += new System.EventHandler(this.productTypesForm_Load);
            this.prodTypeGroupBox.ResumeLayout(false);
            this.prodTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTypesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prodTypeGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView prodTypesDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private MilkWorkDataSetTableAdapters.Product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.TextBox product_type_nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypenameDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}