namespace Route
{
    partial class ShopsForm
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
            System.Windows.Forms.Label shop_nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.shopsDataGridView = new System.Windows.Forms.DataGridView();
            this.shopnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.shopInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.localityViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.shop_nameTextBox = new System.Windows.Forms.TextBox();
            this.streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.shopViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ShopViewTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.streetTableAdapter = new Route.MilkWorkDataSetTableAdapters.StreetTableAdapter();
            this.regionTableAdapter = new Route.MilkWorkDataSetTableAdapters.RegionTableAdapter();
            this.areaTableAdapter = new Route.MilkWorkDataSetTableAdapters.AreaTableAdapter();
            this.localityViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.LocalityViewTableAdapter();
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            shop_nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.shopInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localityViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shop_nameLabel
            // 
            shop_nameLabel.AutoSize = true;
            shop_nameLabel.Location = new System.Drawing.Point(6, 24);
            shop_nameLabel.Name = "shop_nameLabel";
            shop_nameLabel.Size = new System.Drawing.Size(112, 13);
            shop_nameLabel.TabIndex = 0;
            shop_nameLabel.Text = "Название магазина:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 183);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(42, 13);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Улица:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 13);
            label1.TabIndex = 8;
            label1.Text = "Населенный пункт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 10;
            label2.Text = "Район:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 13);
            label3.TabIndex = 12;
            label3.Text = "Область:";
            // 
            // shopsDataGridView
            // 
            this.shopsDataGridView.AllowUserToAddRows = false;
            this.shopsDataGridView.AllowUserToDeleteRows = false;
            this.shopsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopsDataGridView.AutoGenerateColumns = false;
            this.shopsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shopsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.shopsDataGridView.DataSource = this.shopViewBindingSource;
            this.shopsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.shopsDataGridView.Name = "shopsDataGridView";
            this.shopsDataGridView.ReadOnly = true;
            this.shopsDataGridView.RowHeadersVisible = false;
            this.shopsDataGridView.RowHeadersWidth = 10;
            this.shopsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shopsDataGridView.Size = new System.Drawing.Size(820, 206);
            this.shopsDataGridView.TabIndex = 0;
            this.shopsDataGridView.SelectionChanged += new System.EventHandler(this.shopsDataGridView_SelectionChanged);
            // 
            // shopnameDataGridViewTextBoxColumn
            // 
            this.shopnameDataGridViewTextBoxColumn.DataPropertyName = "Shop_name";
            this.shopnameDataGridViewTextBoxColumn.HeaderText = "Название магазина";
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
            // shopViewBindingSource
            // 
            this.shopViewBindingSource.DataMember = "ShopView";
            this.shopViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopInfoGroupBox
            // 
            this.shopInfoGroupBox.Controls.Add(this.streetComboBox);
            this.shopInfoGroupBox.Controls.Add(label3);
            this.shopInfoGroupBox.Controls.Add(this.regionComboBox);
            this.shopInfoGroupBox.Controls.Add(label2);
            this.shopInfoGroupBox.Controls.Add(this.areaComboBox);
            this.shopInfoGroupBox.Controls.Add(label1);
            this.shopInfoGroupBox.Controls.Add(this.LocalityComboBox);
            this.shopInfoGroupBox.Controls.Add(this.cancelButton);
            this.shopInfoGroupBox.Controls.Add(this.saveButton);
            this.shopInfoGroupBox.Controls.Add(this.mapControl1);
            this.shopInfoGroupBox.Controls.Add(shop_nameLabel);
            this.shopInfoGroupBox.Controls.Add(this.shop_nameTextBox);
            this.shopInfoGroupBox.Controls.Add(addressLabel);
            this.shopInfoGroupBox.Enabled = false;
            this.shopInfoGroupBox.Location = new System.Drawing.Point(12, 268);
            this.shopInfoGroupBox.Name = "shopInfoGroupBox";
            this.shopInfoGroupBox.Size = new System.Drawing.Size(820, 257);
            this.shopInfoGroupBox.TabIndex = 1;
            this.shopInfoGroupBox.TabStop = false;
            this.shopInfoGroupBox.Text = "Информация о магазине";
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shopViewBindingSource, "Id_region", true));
            this.regionComboBox.DataSource = this.regionBindingSource;
            this.regionComboBox.DisplayMember = "Region_name";
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(6, 79);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(231, 21);
            this.regionComboBox.TabIndex = 11;
            this.regionComboBox.ValueMember = "Id_region";
            this.regionComboBox.SelectionChangeCommitted += new System.EventHandler(this.regionComboBox_SelectionChangeCommitted);
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // areaComboBox
            // 
            this.areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shopViewBindingSource, "Id_area", true));
            this.areaComboBox.DataSource = this.areaBindingSource;
            this.areaComboBox.DisplayMember = "Area_name";
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(6, 119);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(231, 21);
            this.areaComboBox.TabIndex = 9;
            this.areaComboBox.ValueMember = "Id_area";
            this.areaComboBox.SelectionChangeCommitted += new System.EventHandler(this.areaComboBox_SelectionChangeCommitted);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shopViewBindingSource, "Id_locality", true));
            this.LocalityComboBox.DataSource = this.localityViewBindingSource;
            this.LocalityComboBox.DisplayMember = "Locality_name";
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.Location = new System.Drawing.Point(6, 159);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(231, 21);
            this.LocalityComboBox.TabIndex = 7;
            this.LocalityComboBox.ValueMember = "Id_locality";
            this.LocalityComboBox.SelectionChangeCommitted += new System.EventHandler(this.LocalityComboBox_SelectionChangeCommitted);
            // 
            // localityViewBindingSource
            // 
            this.localityViewBindingSource.DataMember = "LocalityView";
            this.localityViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 228);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mapControl1
            // 
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(414, 7);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(400, 244);
            this.mapControl1.TabIndex = 4;
            this.mapControl1.DoubleClick += new System.EventHandler(this.mapControl1_DoubleClick);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AkXEvTw7yRRdLI5OcK2-bQJaMt9Q4FB9pMOLAxUZjYWjxE8TEdXvSEv3vDulu4rD";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            // 
            // shop_nameTextBox
            // 
            this.shop_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopViewBindingSource, "Shop_name", true));
            this.shop_nameTextBox.Location = new System.Drawing.Point(6, 40);
            this.shop_nameTextBox.Name = "shop_nameTextBox";
            this.shop_nameTextBox.Size = new System.Drawing.Size(231, 20);
            this.shop_nameTextBox.TabIndex = 1;
            // 
            // streetBindingSource
            // 
            this.streetBindingSource.DataMember = "Street";
            this.streetBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(174, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // shopViewTableAdapter
            // 
            this.shopViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.Locality_typeTableAdapter = null;
            this.tableAdapterManager.LocalityTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.Product_typeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.Request_structTableAdapter = null;
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = this.shopViewTableAdapter;
            this.tableAdapterManager.StreetTableAdapter = this.streetTableAdapter;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // streetTableAdapter
            // 
            this.streetTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // localityViewTableAdapter
            // 
            this.localityViewTableAdapter.ClearBeforeFill = true;
            // 
            // streetComboBox
            // 
            this.streetComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shopViewBindingSource, "Id_street", true));
            this.streetComboBox.DataSource = this.streetBindingSource;
            this.streetComboBox.DisplayMember = "Street_name";
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Location = new System.Drawing.Point(6, 199);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(231, 21);
            this.streetComboBox.TabIndex = 13;
            this.streetComboBox.ValueMember = "Id_street";
            // 
            // ShopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 537);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.shopInfoGroupBox);
            this.Controls.Add(this.shopsDataGridView);
            this.Name = "ShopsForm";
            this.Text = "Справочник магазинов";
            this.Load += new System.EventHandler(this.ShopsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.shopInfoGroupBox.ResumeLayout(false);
            this.shopInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localityViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shopsDataGridView;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource shopViewBindingSource;
        private MilkWorkDataSetTableAdapters.ShopViewTableAdapter shopViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox shopInfoGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox shop_nameTextBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.StreetTableAdapter streetTableAdapter;
        private System.Windows.Forms.BindingSource streetBindingSource;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private MilkWorkDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MilkWorkDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource localityViewBindingSource;
        private MilkWorkDataSetTableAdapters.LocalityViewTableAdapter localityViewTableAdapter;
        private System.Windows.Forms.ComboBox streetComboBox;
    }
}

