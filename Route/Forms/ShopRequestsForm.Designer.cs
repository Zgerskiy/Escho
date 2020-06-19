namespace Route.Forms
{
    partial class ShopRequestsForm
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
            System.Windows.Forms.Label date_of_requestLabel;
            System.Windows.Forms.Label id_shopLabel;
            System.Windows.Forms.Label id_productLabel;
            System.Windows.Forms.Label product_countLabel;
            this.shopRequestGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.date_of_requestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shopRequestViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.id_shopComboBox = new System.Windows.Forms.ComboBox();
            this.shopViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.shopnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.shopRequestViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ShopRequestViewTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.shopViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ShopViewTableAdapter();
            this.shopRequestStructGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelRequestButton = new System.Windows.Forms.Button();
            this.saveRequestButton = new System.Windows.Forms.Button();
            this.id_productComboBox = new System.Windows.Forms.ComboBox();
            this.requestStructViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_countTextBox = new System.Windows.Forms.TextBox();
            this.removeStructButton = new System.Windows.Forms.Button();
            this.editStructButton = new System.Windows.Forms.Button();
            this.addStructButton = new System.Windows.Forms.Button();
            this.requestStructViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.RequestStructViewTableAdapter();
            this.productViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ProductViewTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date_of_requestLabel = new System.Windows.Forms.Label();
            id_shopLabel = new System.Windows.Forms.Label();
            id_productLabel = new System.Windows.Forms.Label();
            product_countLabel = new System.Windows.Forms.Label();
            this.shopRequestGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopRequestViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopRequestsDataGridView)).BeginInit();
            this.shopRequestStructGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestStructViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_of_requestLabel
            // 
            date_of_requestLabel.AutoSize = true;
            date_of_requestLabel.Location = new System.Drawing.Point(15, 16);
            date_of_requestLabel.Name = "date_of_requestLabel";
            date_of_requestLabel.Size = new System.Drawing.Size(75, 13);
            date_of_requestLabel.TabIndex = 0;
            date_of_requestLabel.Text = "Дата заявки:";
            // 
            // id_shopLabel
            // 
            id_shopLabel.AutoSize = true;
            id_shopLabel.Location = new System.Drawing.Point(15, 55);
            id_shopLabel.Name = "id_shopLabel";
            id_shopLabel.Size = new System.Drawing.Size(54, 13);
            id_shopLabel.TabIndex = 2;
            id_shopLabel.Text = "Магазин:";
            // 
            // id_productLabel
            // 
            id_productLabel.AutoSize = true;
            id_productLabel.Location = new System.Drawing.Point(6, 16);
            id_productLabel.Name = "id_productLabel";
            id_productLabel.Size = new System.Drawing.Size(52, 13);
            id_productLabel.TabIndex = 1;
            id_productLabel.Text = "Продукт:";
            // 
            // product_countLabel
            // 
            product_countLabel.AutoSize = true;
            product_countLabel.Location = new System.Drawing.Point(6, 56);
            product_countLabel.Name = "product_countLabel";
            product_countLabel.Size = new System.Drawing.Size(69, 13);
            product_countLabel.TabIndex = 3;
            product_countLabel.Text = "Количество:";
            // 
            // shopRequestGroupBox
            // 
            this.shopRequestGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopRequestGroupBox.Controls.Add(this.cancelButton);
            this.shopRequestGroupBox.Controls.Add(this.saveButton);
            this.shopRequestGroupBox.Controls.Add(date_of_requestLabel);
            this.shopRequestGroupBox.Controls.Add(this.date_of_requestDateTimePicker);
            this.shopRequestGroupBox.Controls.Add(id_shopLabel);
            this.shopRequestGroupBox.Controls.Add(this.id_shopComboBox);
            this.shopRequestGroupBox.Enabled = false;
            this.shopRequestGroupBox.Location = new System.Drawing.Point(12, 279);
            this.shopRequestGroupBox.Name = "shopRequestGroupBox";
            this.shopRequestGroupBox.Size = new System.Drawing.Size(493, 169);
            this.shopRequestGroupBox.TabIndex = 0;
            this.shopRequestGroupBox.TabStop = false;
            this.shopRequestGroupBox.Text = "Информация о заявке";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 98);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // date_of_requestDateTimePicker
            // 
            this.date_of_requestDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.shopRequestViewBindingSource, "Date_of_request", true));
            this.date_of_requestDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_requestDateTimePicker.Location = new System.Drawing.Point(6, 32);
            this.date_of_requestDateTimePicker.Name = "date_of_requestDateTimePicker";
            this.date_of_requestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_requestDateTimePicker.TabIndex = 1;
            // 
            // shopRequestViewBindingSource
            // 
            this.shopRequestViewBindingSource.DataMember = "ShopRequestView";
            this.shopRequestViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_shopComboBox
            // 
            this.id_shopComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shopRequestViewBindingSource, "Id_shop", true));
            this.id_shopComboBox.DataSource = this.shopViewBindingSource;
            this.id_shopComboBox.DisplayMember = "Shop_name";
            this.id_shopComboBox.FormattingEnabled = true;
            this.id_shopComboBox.Location = new System.Drawing.Point(6, 71);
            this.id_shopComboBox.Name = "id_shopComboBox";
            this.id_shopComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_shopComboBox.TabIndex = 3;
            this.id_shopComboBox.ValueMember = "Id_shop";
            // 
            // shopViewBindingSource
            // 
            this.shopViewBindingSource.DataMember = "ShopView";
            this.shopViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // shopRequestsDataGridView
            // 
            this.shopRequestsDataGridView.AllowUserToAddRows = false;
            this.shopRequestsDataGridView.AllowUserToDeleteRows = false;
            this.shopRequestsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopRequestsDataGridView.AutoGenerateColumns = false;
            this.shopRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shopRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopRequestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateofrequestDataGridViewTextBoxColumn});
            this.shopRequestsDataGridView.DataSource = this.shopRequestViewBindingSource;
            this.shopRequestsDataGridView.Location = new System.Drawing.Point(12, 44);
            this.shopRequestsDataGridView.Name = "shopRequestsDataGridView";
            this.shopRequestsDataGridView.ReadOnly = true;
            this.shopRequestsDataGridView.RowHeadersVisible = false;
            this.shopRequestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shopRequestsDataGridView.Size = new System.Drawing.Size(493, 229);
            this.shopRequestsDataGridView.TabIndex = 1;
            this.shopRequestsDataGridView.SelectionChanged += new System.EventHandler(this.shopRequestsDataGridView_SelectionChanged);
            // 
            // shopnameDataGridViewTextBoxColumn
            // 
            this.shopnameDataGridViewTextBoxColumn.DataPropertyName = "Shop_name";
            this.shopnameDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.shopnameDataGridViewTextBoxColumn.Name = "shopnameDataGridViewTextBoxColumn";
            this.shopnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofrequestDataGridViewTextBoxColumn
            // 
            this.dateofrequestDataGridViewTextBoxColumn.DataPropertyName = "Date_of_request";
            this.dateofrequestDataGridViewTextBoxColumn.HeaderText = "Дата заявки";
            this.dateofrequestDataGridViewTextBoxColumn.Name = "dateofrequestDataGridViewTextBoxColumn";
            this.dateofrequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(191, 15);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 15);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // shopRequestViewTableAdapter
            // 
            this.shopRequestViewTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ShopRequestViewTableAdapter = this.shopRequestViewTableAdapter;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = this.shopViewTableAdapter;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shopViewTableAdapter
            // 
            this.shopViewTableAdapter.ClearBeforeFill = true;
            // 
            // shopRequestStructGroupBox
            // 
            this.shopRequestStructGroupBox.Controls.Add(this.cancelRequestButton);
            this.shopRequestStructGroupBox.Controls.Add(this.saveRequestButton);
            this.shopRequestStructGroupBox.Controls.Add(id_productLabel);
            this.shopRequestStructGroupBox.Controls.Add(this.id_productComboBox);
            this.shopRequestStructGroupBox.Controls.Add(product_countLabel);
            this.shopRequestStructGroupBox.Controls.Add(this.product_countTextBox);
            this.shopRequestStructGroupBox.Enabled = false;
            this.shopRequestStructGroupBox.Location = new System.Drawing.Point(509, 279);
            this.shopRequestStructGroupBox.Name = "shopRequestStructGroupBox";
            this.shopRequestStructGroupBox.Size = new System.Drawing.Size(448, 169);
            this.shopRequestStructGroupBox.TabIndex = 9;
            this.shopRequestStructGroupBox.TabStop = false;
            this.shopRequestStructGroupBox.Text = "Структура заявки";
            // 
            // cancelRequestButton
            // 
            this.cancelRequestButton.Location = new System.Drawing.Point(90, 98);
            this.cancelRequestButton.Name = "cancelRequestButton";
            this.cancelRequestButton.Size = new System.Drawing.Size(75, 23);
            this.cancelRequestButton.TabIndex = 7;
            this.cancelRequestButton.Text = "Отменить";
            this.cancelRequestButton.UseVisualStyleBackColor = true;
            this.cancelRequestButton.Click += new System.EventHandler(this.cancelRequestButton_Click);
            // 
            // saveRequestButton
            // 
            this.saveRequestButton.Location = new System.Drawing.Point(9, 98);
            this.saveRequestButton.Name = "saveRequestButton";
            this.saveRequestButton.Size = new System.Drawing.Size(75, 23);
            this.saveRequestButton.TabIndex = 6;
            this.saveRequestButton.Text = "Сохранить";
            this.saveRequestButton.UseVisualStyleBackColor = true;
            this.saveRequestButton.Click += new System.EventHandler(this.saveRequestButton_Click);
            // 
            // id_productComboBox
            // 
            this.id_productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestStructViewBindingSource, "Id_product", true));
            this.id_productComboBox.DataSource = this.productViewBindingSource;
            this.id_productComboBox.DisplayMember = "Product_name";
            this.id_productComboBox.FormattingEnabled = true;
            this.id_productComboBox.Location = new System.Drawing.Point(9, 32);
            this.id_productComboBox.Name = "id_productComboBox";
            this.id_productComboBox.Size = new System.Drawing.Size(205, 21);
            this.id_productComboBox.TabIndex = 2;
            this.id_productComboBox.ValueMember = "Id_product";
            // 
            // requestStructViewBindingSource
            // 
            this.requestStructViewBindingSource.DataMember = "RequestStructView";
            this.requestStructViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataMember = "ProductView";
            this.productViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // product_countTextBox
            // 
            this.product_countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestStructViewBindingSource, "Product_count", true));
            this.product_countTextBox.Location = new System.Drawing.Point(9, 72);
            this.product_countTextBox.Name = "product_countTextBox";
            this.product_countTextBox.Size = new System.Drawing.Size(205, 20);
            this.product_countTextBox.TabIndex = 4;
            // 
            // removeStructButton
            // 
            this.removeStructButton.Location = new System.Drawing.Point(685, 15);
            this.removeStructButton.Name = "removeStructButton";
            this.removeStructButton.Size = new System.Drawing.Size(75, 23);
            this.removeStructButton.TabIndex = 12;
            this.removeStructButton.Text = "Удалить";
            this.removeStructButton.UseVisualStyleBackColor = true;
            this.removeStructButton.Click += new System.EventHandler(this.removeStructButton_Click);
            // 
            // editStructButton
            // 
            this.editStructButton.Location = new System.Drawing.Point(587, 15);
            this.editStructButton.Name = "editStructButton";
            this.editStructButton.Size = new System.Drawing.Size(75, 23);
            this.editStructButton.TabIndex = 11;
            this.editStructButton.Text = "Изменить";
            this.editStructButton.UseVisualStyleBackColor = true;
            this.editStructButton.Click += new System.EventHandler(this.editStructButton_Click);
            // 
            // addStructButton
            // 
            this.addStructButton.Location = new System.Drawing.Point(506, 15);
            this.addStructButton.Name = "addStructButton";
            this.addStructButton.Size = new System.Drawing.Size(75, 23);
            this.addStructButton.TabIndex = 10;
            this.addStructButton.Text = "Добавить";
            this.addStructButton.UseVisualStyleBackColor = true;
            this.addStructButton.Click += new System.EventHandler(this.addStructButton_Click);
            // 
            // requestStructViewTableAdapter
            // 
            this.requestStructViewTableAdapter.ClearBeforeFill = true;
            // 
            // productViewTableAdapter
            // 
            this.productViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnameDataGridViewTextBoxColumn,
            this.producttypenameDataGridViewTextBoxColumn,
            this.productcountDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestStructViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(511, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(434, 229);
            this.dataGridView1.TabIndex = 13;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producttypenameDataGridViewTextBoxColumn
            // 
            this.producttypenameDataGridViewTextBoxColumn.DataPropertyName = "Product_type_name";
            this.producttypenameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.producttypenameDataGridViewTextBoxColumn.Name = "producttypenameDataGridViewTextBoxColumn";
            this.producttypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcountDataGridViewTextBoxColumn
            // 
            this.productcountDataGridViewTextBoxColumn.DataPropertyName = "Product_count";
            this.productcountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.productcountDataGridViewTextBoxColumn.Name = "productcountDataGridViewTextBoxColumn";
            this.productcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "Unit_name";
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShopRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeStructButton);
            this.Controls.Add(this.editStructButton);
            this.Controls.Add(this.addStructButton);
            this.Controls.Add(this.shopRequestStructGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.shopRequestsDataGridView);
            this.Controls.Add(this.shopRequestGroupBox);
            this.Name = "ShopRequestsForm";
            this.Text = "Заявки магазинов";
            this.Load += new System.EventHandler(this.ShopRequestsForm_Load);
            this.shopRequestGroupBox.ResumeLayout(false);
            this.shopRequestGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopRequestViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopRequestsDataGridView)).EndInit();
            this.shopRequestStructGroupBox.ResumeLayout(false);
            this.shopRequestStructGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestStructViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shopRequestGroupBox;
        private System.Windows.Forms.DataGridView shopRequestsDataGridView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource shopRequestViewBindingSource;
        private MilkWorkDataSetTableAdapters.ShopRequestViewTableAdapter shopRequestViewTableAdapter;
        private System.Windows.Forms.DateTimePicker date_of_requestDateTimePicker;
        private System.Windows.Forms.ComboBox id_shopComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofrequestDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.ShopViewTableAdapter shopViewTableAdapter;
        private System.Windows.Forms.BindingSource shopViewBindingSource;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox shopRequestStructGroupBox;
        private System.Windows.Forms.Button removeStructButton;
        private System.Windows.Forms.Button editStructButton;
        private System.Windows.Forms.Button addStructButton;
        private System.Windows.Forms.BindingSource requestStructViewBindingSource;
        private MilkWorkDataSetTableAdapters.RequestStructViewTableAdapter requestStructViewTableAdapter;
        private System.Windows.Forms.ComboBox id_productComboBox;
        private System.Windows.Forms.TextBox product_countTextBox;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private MilkWorkDataSetTableAdapters.ProductViewTableAdapter productViewTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelRequestButton;
        private System.Windows.Forms.Button saveRequestButton;
    }
}