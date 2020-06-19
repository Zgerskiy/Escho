namespace Route
{
    partial class ProductForm
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
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label id_product_typeLabel;
            System.Windows.Forms.Label id_unitLabel;
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.addProductTypeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.id_product_typeComboBox = new System.Windows.Forms.ComboBox();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_unitComboBox = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.productViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ProductViewTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.product_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Product_typeTableAdapter();
            this.unitTableAdapter = new Route.MilkWorkDataSetTableAdapters.UnitTableAdapter();
            product_nameLabel = new System.Windows.Forms.Label();
            id_product_typeLabel = new System.Windows.Forms.Label();
            id_unitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(6, 16);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(109, 13);
            product_nameLabel.TabIndex = 0;
            product_nameLabel.Text = "Название продукта:";
            // 
            // id_product_typeLabel
            // 
            id_product_typeLabel.AutoSize = true;
            id_product_typeLabel.Location = new System.Drawing.Point(6, 55);
            id_product_typeLabel.Name = "id_product_typeLabel";
            id_product_typeLabel.Size = new System.Drawing.Size(78, 13);
            id_product_typeLabel.TabIndex = 2;
            id_product_typeLabel.Text = "Тип продукта:";
            // 
            // id_unitLabel
            // 
            id_unitLabel.AutoSize = true;
            id_unitLabel.Location = new System.Drawing.Point(6, 95);
            id_unitLabel.Name = "id_unitLabel";
            id_unitLabel.Size = new System.Drawing.Size(112, 13);
            id_unitLabel.TabIndex = 4;
            id_unitLabel.Text = "Единица измерения:";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnameDataGridViewTextBoxColumn,
            this.producttypenameDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productViewBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 42);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(776, 237);
            this.productsDataGridView.TabIndex = 1;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producttypenameDataGridViewTextBoxColumn
            // 
            this.producttypenameDataGridViewTextBoxColumn.DataPropertyName = "Product_type_name";
            this.producttypenameDataGridViewTextBoxColumn.HeaderText = "Тип продукта";
            this.producttypenameDataGridViewTextBoxColumn.Name = "producttypenameDataGridViewTextBoxColumn";
            this.producttypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "Unit_name";
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataMember = "ProductView";
            this.productViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGroupBox.Controls.Add(this.addUnitButton);
            this.productGroupBox.Controls.Add(this.addProductTypeButton);
            this.productGroupBox.Controls.Add(this.saveButton);
            this.productGroupBox.Controls.Add(this.cancelButton);
            this.productGroupBox.Controls.Add(product_nameLabel);
            this.productGroupBox.Controls.Add(this.product_nameTextBox);
            this.productGroupBox.Controls.Add(id_product_typeLabel);
            this.productGroupBox.Controls.Add(this.id_product_typeComboBox);
            this.productGroupBox.Controls.Add(id_unitLabel);
            this.productGroupBox.Controls.Add(this.id_unitComboBox);
            this.productGroupBox.Enabled = false;
            this.productGroupBox.Location = new System.Drawing.Point(12, 286);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(776, 166);
            this.productGroupBox.TabIndex = 2;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Информация о продукте";
            // 
            // addUnitButton
            // 
            this.addUnitButton.Location = new System.Drawing.Point(241, 111);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(21, 21);
            this.addUnitButton.TabIndex = 11;
            this.addUnitButton.Text = "+";
            this.addUnitButton.UseVisualStyleBackColor = true;
            this.addUnitButton.Click += new System.EventHandler(this.addUnitButton_Click);
            // 
            // addProductTypeButton
            // 
            this.addProductTypeButton.Location = new System.Drawing.Point(241, 71);
            this.addProductTypeButton.Name = "addProductTypeButton";
            this.addProductTypeButton.Size = new System.Drawing.Size(21, 21);
            this.addProductTypeButton.TabIndex = 9;
            this.addProductTypeButton.Text = "+";
            this.addProductTypeButton.UseVisualStyleBackColor = true;
            this.addProductTypeButton.Click += new System.EventHandler(this.addProductTypeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 138);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productViewBindingSource, "Product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(229, 20);
            this.product_nameTextBox.TabIndex = 1;
            // 
            // id_product_typeComboBox
            // 
            this.id_product_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productViewBindingSource, "Id_product_type", true));
            this.id_product_typeComboBox.DataSource = this.producttypeBindingSource;
            this.id_product_typeComboBox.DisplayMember = "Product_type_name";
            this.id_product_typeComboBox.FormattingEnabled = true;
            this.id_product_typeComboBox.Location = new System.Drawing.Point(6, 71);
            this.id_product_typeComboBox.Name = "id_product_typeComboBox";
            this.id_product_typeComboBox.Size = new System.Drawing.Size(229, 21);
            this.id_product_typeComboBox.TabIndex = 3;
            this.id_product_typeComboBox.ValueMember = "Id_product_type";
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "Product_type";
            this.producttypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // id_unitComboBox
            // 
            this.id_unitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productViewBindingSource, "Id_unit", true));
            this.id_unitComboBox.DataSource = this.unitBindingSource;
            this.id_unitComboBox.DisplayMember = "Unit_name";
            this.id_unitComboBox.FormattingEnabled = true;
            this.id_unitComboBox.Location = new System.Drawing.Point(6, 111);
            this.id_unitComboBox.Name = "id_unitComboBox";
            this.id_unitComboBox.Size = new System.Drawing.Size(229, 21);
            this.id_unitComboBox.TabIndex = 5;
            this.id_unitComboBox.ValueMember = "Id_unit";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(207, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // productViewTableAdapter
            // 
            this.productViewTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Product_typeTableAdapter = this.product_typeTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductViewTableAdapter = this.productViewTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.Request_structTableAdapter = null;
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.Route_structViewTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = this.unitTableAdapter;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.productsDataGridView);
            this.Name = "ProductForm";
            this.Text = "Справочник продуктов";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private MilkWorkDataSetTableAdapters.ProductViewTableAdapter productViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.ComboBox id_product_typeComboBox;
        private System.Windows.Forms.ComboBox id_unitComboBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.Product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private MilkWorkDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Button addUnitButton;
        private System.Windows.Forms.Button addProductTypeButton;
    }
}