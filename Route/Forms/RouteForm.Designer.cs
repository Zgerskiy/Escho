namespace Route
{
    partial class RouteForm
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
            System.Windows.Forms.Label route_nameLabel;
            System.Windows.Forms.Label route_dateLabel;
            System.Windows.Forms.Label route_distanceLabel;
            System.Windows.Forms.Label carLabel;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routedistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.routeGroupBox = new System.Windows.Forms.GroupBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.carViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.route_nameTextBox = new System.Windows.Forms.TextBox();
            this.route_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.route_distanceTextBox = new System.Windows.Forms.TextBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            this.shopViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routestructViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new Route.MilkWorkDataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.route_structViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.Route_structViewTableAdapter();
            this.carViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.CarViewTableAdapter();
            this.shopViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.ShopViewTableAdapter();
            this.routeStructGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shopComboBox = new System.Windows.Forms.ComboBox();
            this.removePointButton = new System.Windows.Forms.Button();
            this.addPointButton = new System.Windows.Forms.Button();
            this.routeStructDataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            route_nameLabel = new System.Windows.Forms.Label();
            route_dateLabel = new System.Windows.Forms.Label();
            route_distanceLabel = new System.Windows.Forms.Label();
            carLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.routeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routestructViewBindingSource)).BeginInit();
            this.routeStructGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStructDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // route_nameLabel
            // 
            route_nameLabel.AutoSize = true;
            route_nameLabel.Location = new System.Drawing.Point(6, 16);
            route_nameLabel.Name = "route_nameLabel";
            route_nameLabel.Size = new System.Drawing.Size(113, 13);
            route_nameLabel.TabIndex = 0;
            route_nameLabel.Text = "Название маршрута:";
            // 
            // route_dateLabel
            // 
            route_dateLabel.AutoSize = true;
            route_dateLabel.Location = new System.Drawing.Point(6, 55);
            route_dateLabel.Name = "route_dateLabel";
            route_dateLabel.Size = new System.Drawing.Size(36, 13);
            route_dateLabel.TabIndex = 2;
            route_dateLabel.Text = "Дата:";
            // 
            // route_distanceLabel
            // 
            route_distanceLabel.AutoSize = true;
            route_distanceLabel.Location = new System.Drawing.Point(6, 94);
            route_distanceLabel.Name = "route_distanceLabel";
            route_distanceLabel.Size = new System.Drawing.Size(70, 13);
            route_distanceLabel.TabIndex = 4;
            route_distanceLabel.Text = "Расстояние:";
            // 
            // carLabel
            // 
            carLabel.AutoSize = true;
            carLabel.Location = new System.Drawing.Point(6, 133);
            carLabel.Name = "carLabel";
            carLabel.Size = new System.Drawing.Size(72, 13);
            carLabel.TabIndex = 10;
            carLabel.Text = "Автомобиль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 221);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 13);
            label1.TabIndex = 11;
            label1.Text = "Магазин:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routenameDataGridViewTextBoxColumn,
            this.routedateDataGridViewTextBoxColumn,
            this.routedistanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // routenameDataGridViewTextBoxColumn
            // 
            this.routenameDataGridViewTextBoxColumn.DataPropertyName = "Route_name";
            this.routenameDataGridViewTextBoxColumn.HeaderText = "Маршрут";
            this.routenameDataGridViewTextBoxColumn.Name = "routenameDataGridViewTextBoxColumn";
            this.routenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routedateDataGridViewTextBoxColumn
            // 
            this.routedateDataGridViewTextBoxColumn.DataPropertyName = "Route_date";
            this.routedateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.routedateDataGridViewTextBoxColumn.Name = "routedateDataGridViewTextBoxColumn";
            this.routedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routedistanceDataGridViewTextBoxColumn
            // 
            this.routedistanceDataGridViewTextBoxColumn.DataPropertyName = "Route_distance";
            this.routedistanceDataGridViewTextBoxColumn.HeaderText = "Длинна маршрута  (км)";
            this.routedistanceDataGridViewTextBoxColumn.Name = "routedistanceDataGridViewTextBoxColumn";
            this.routedistanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(188, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // routeGroupBox
            // 
            this.routeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeGroupBox.Controls.Add(carLabel);
            this.routeGroupBox.Controls.Add(this.carComboBox);
            this.routeGroupBox.Controls.Add(this.cancelButton);
            this.routeGroupBox.Controls.Add(this.saveButton);
            this.routeGroupBox.Controls.Add(route_nameLabel);
            this.routeGroupBox.Controls.Add(this.route_nameTextBox);
            this.routeGroupBox.Controls.Add(route_dateLabel);
            this.routeGroupBox.Controls.Add(this.route_dateDateTimePicker);
            this.routeGroupBox.Controls.Add(route_distanceLabel);
            this.routeGroupBox.Controls.Add(this.route_distanceTextBox);
            this.routeGroupBox.Enabled = false;
            this.routeGroupBox.Location = new System.Drawing.Point(12, 261);
            this.routeGroupBox.Name = "routeGroupBox";
            this.routeGroupBox.Size = new System.Drawing.Size(526, 257);
            this.routeGroupBox.TabIndex = 4;
            this.routeGroupBox.TabStop = false;
            this.routeGroupBox.Text = "Маршрут";
            // 
            // carComboBox
            // 
            this.carComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.routeBindingSource, "Id_car", true));
            this.carComboBox.DataSource = this.carViewBindingSource;
            this.carComboBox.DisplayMember = "Full_car_name";
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(6, 149);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(200, 21);
            this.carComboBox.TabIndex = 9;
            this.carComboBox.ValueMember = "Id_car";
            // 
            // carViewBindingSource
            // 
            this.carViewBindingSource.DataMember = "CarView";
            this.carViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(113, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // route_nameTextBox
            // 
            this.route_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Route_name", true));
            this.route_nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.route_nameTextBox.Name = "route_nameTextBox";
            this.route_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.route_nameTextBox.TabIndex = 1;
            // 
            // route_dateDateTimePicker
            // 
            this.route_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "Route_date", true));
            this.route_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.route_dateDateTimePicker.Location = new System.Drawing.Point(6, 71);
            this.route_dateDateTimePicker.Name = "route_dateDateTimePicker";
            this.route_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.route_dateDateTimePicker.TabIndex = 3;
            // 
            // route_distanceTextBox
            // 
            this.route_distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Route_distance", true));
            this.route_distanceTextBox.Location = new System.Drawing.Point(6, 110);
            this.route_distanceTextBox.Name = "route_distanceTextBox";
            this.route_distanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.route_distanceTextBox.TabIndex = 5;
            // 
            // mapControl1
            // 
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(6, 266);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(549, 222);
            this.mapControl1.TabIndex = 9;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AkXEvTw7yRRdLI5OcK2-bQJaMt9Q4FB9pMOLAxUZjYWjxE8TEdXvSEv3vDulu4rD";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.informationLayer1.DataProvider = this.bingRouteDataProvider1;
            this.bingRouteDataProvider1.BingKey = "AkXEvTw7yRRdLI5OcK2-bQJaMt9Q4FB9pMOLAxUZjYWjxE8TEdXvSEv3vDulu4rD";
            // 
            // shopViewBindingSource
            // 
            this.shopViewBindingSource.DataMember = "ShopView";
            this.shopViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // routestructViewBindingSource
            // 
            this.routestructViewBindingSource.DataMember = "Route_structView";
            this.routestructViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.Route_structViewTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // route_structViewTableAdapter
            // 
            this.route_structViewTableAdapter.ClearBeforeFill = true;
            // 
            // carViewTableAdapter
            // 
            this.carViewTableAdapter.ClearBeforeFill = true;
            // 
            // shopViewTableAdapter
            // 
            this.shopViewTableAdapter.ClearBeforeFill = true;
            // 
            // routeStructGroupBox
            // 
            this.routeStructGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeStructGroupBox.Controls.Add(this.mapControl1);
            this.routeStructGroupBox.Controls.Add(this.button1);
            this.routeStructGroupBox.Controls.Add(label1);
            this.routeStructGroupBox.Controls.Add(this.shopComboBox);
            this.routeStructGroupBox.Controls.Add(this.removePointButton);
            this.routeStructGroupBox.Controls.Add(this.addPointButton);
            this.routeStructGroupBox.Controls.Add(this.routeStructDataGridView);
            this.routeStructGroupBox.Location = new System.Drawing.Point(544, 24);
            this.routeStructGroupBox.Name = "routeStructGroupBox";
            this.routeStructGroupBox.Size = new System.Drawing.Size(561, 494);
            this.routeStructGroupBox.TabIndex = 7;
            this.routeStructGroupBox.TabStop = false;
            this.routeStructGroupBox.Text = "Структура маршрута";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Построить маршрут";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // shopComboBox
            // 
            this.shopComboBox.DataSource = this.shopViewBindingSource;
            this.shopComboBox.DisplayMember = "Shop_name";
            this.shopComboBox.FormattingEnabled = true;
            this.shopComboBox.Location = new System.Drawing.Point(6, 237);
            this.shopComboBox.Name = "shopComboBox";
            this.shopComboBox.Size = new System.Drawing.Size(163, 21);
            this.shopComboBox.TabIndex = 3;
            this.shopComboBox.ValueMember = "Id_shop";
            // 
            // removePointButton
            // 
            this.removePointButton.Location = new System.Drawing.Point(175, 193);
            this.removePointButton.Name = "removePointButton";
            this.removePointButton.Size = new System.Drawing.Size(163, 23);
            this.removePointButton.TabIndex = 2;
            this.removePointButton.Text = "Удалить точку доставки";
            this.removePointButton.UseVisualStyleBackColor = true;
            this.removePointButton.Click += new System.EventHandler(this.removePointButton_Click_1);
            // 
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(6, 193);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(163, 23);
            this.addPointButton.TabIndex = 1;
            this.addPointButton.Text = "Добавить точку доставки";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click_1);
            // 
            // routeStructDataGridView
            // 
            this.routeStructDataGridView.AllowUserToAddRows = false;
            this.routeStructDataGridView.AllowUserToDeleteRows = false;
            this.routeStructDataGridView.AutoGenerateColumns = false;
            this.routeStructDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routeStructDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeStructDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.Shop_name,
            this.addressDataGridViewTextBoxColumn});
            this.routeStructDataGridView.DataSource = this.routestructViewBindingSource;
            this.routeStructDataGridView.Location = new System.Drawing.Point(6, 17);
            this.routeStructDataGridView.Name = "routeStructDataGridView";
            this.routeStructDataGridView.ReadOnly = true;
            this.routeStructDataGridView.RowHeadersVisible = false;
            this.routeStructDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routeStructDataGridView.Size = new System.Drawing.Size(549, 170);
            this.routeStructDataGridView.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "№";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Shop_name
            // 
            this.Shop_name.DataPropertyName = "Shop_name";
            this.Shop_name.HeaderText = "Магазин";
            this.Shop_name.Name = "Shop_name";
            this.Shop_name.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 520);
            this.Controls.Add(this.routeStructGroupBox);
            this.Controls.Add(this.routeGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RouteForm";
            this.Text = "Маршруты";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.routeGroupBox.ResumeLayout(false);
            this.routeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routestructViewBindingSource)).EndInit();
            this.routeStructGroupBox.ResumeLayout(false);
            this.routeStructGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStructDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox routeGroupBox;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private MilkWorkDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routedistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox route_nameTextBox;
        private System.Windows.Forms.DateTimePicker route_dateDateTimePicker;
        private System.Windows.Forms.TextBox route_distanceTextBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource routestructViewBindingSource;
        private MilkWorkDataSetTableAdapters.Route_structViewTableAdapter route_structViewTableAdapter;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.BindingSource carViewBindingSource;
        private MilkWorkDataSetTableAdapters.CarViewTableAdapter carViewTableAdapter;
        private System.Windows.Forms.BindingSource shopViewBindingSource;
        private MilkWorkDataSetTableAdapters.ShopViewTableAdapter shopViewTableAdapter;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingRouteDataProvider bingRouteDataProvider1;
        private System.Windows.Forms.GroupBox routeStructGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox shopComboBox;
        private System.Windows.Forms.Button removePointButton;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.DataGridView routeStructDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}