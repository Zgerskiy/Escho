namespace Route.Forms
{
    partial class StreetsForm
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
            System.Windows.Forms.Label locality_nameLabel;
            System.Windows.Forms.Label area_nameLabel;
            System.Windows.Forms.Label region_nameLabel;
            System.Windows.Forms.Label street_nameLabel;
            this.streetGroupBox = new System.Windows.Forms.GroupBox();
            this.locality_nameComboBox = new System.Windows.Forms.ComboBox();
            this.streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.localityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.street_nameTextBox = new System.Windows.Forms.TextBox();
            this.area_nameComboBox = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.region_nameComboBox = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.localitytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.streetsDataGridView = new System.Windows.Forms.DataGridView();
            this.streetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitytypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.streetTableAdapter = new Route.MilkWorkDataSetTableAdapters.StreetTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new Route.MilkWorkDataSetTableAdapters.AreaTableAdapter();
            this.locality_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Locality_typeTableAdapter();
            this.localityTableAdapter = new Route.MilkWorkDataSetTableAdapters.LocalityTableAdapter();
            this.regionTableAdapter = new Route.MilkWorkDataSetTableAdapters.RegionTableAdapter();
            locality_nameLabel = new System.Windows.Forms.Label();
            area_nameLabel = new System.Windows.Forms.Label();
            region_nameLabel = new System.Windows.Forms.Label();
            street_nameLabel = new System.Windows.Forms.Label();
            this.streetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locality_nameLabel
            // 
            locality_nameLabel.AutoSize = true;
            locality_nameLabel.Location = new System.Drawing.Point(9, 98);
            locality_nameLabel.Name = "locality_nameLabel";
            locality_nameLabel.Size = new System.Drawing.Size(64, 13);
            locality_nameLabel.TabIndex = 5;
            locality_nameLabel.Text = "Нас. пункт:";
            // 
            // area_nameLabel
            // 
            area_nameLabel.AutoSize = true;
            area_nameLabel.Location = new System.Drawing.Point(9, 59);
            area_nameLabel.Name = "area_nameLabel";
            area_nameLabel.Size = new System.Drawing.Size(41, 13);
            area_nameLabel.TabIndex = 7;
            area_nameLabel.Text = "Район:";
            // 
            // region_nameLabel
            // 
            region_nameLabel.AutoSize = true;
            region_nameLabel.Location = new System.Drawing.Point(9, 16);
            region_nameLabel.Name = "region_nameLabel";
            region_nameLabel.Size = new System.Drawing.Size(53, 13);
            region_nameLabel.TabIndex = 9;
            region_nameLabel.Text = "Область:";
            // 
            // street_nameLabel
            // 
            street_nameLabel.AutoSize = true;
            street_nameLabel.Location = new System.Drawing.Point(9, 137);
            street_nameLabel.Name = "street_nameLabel";
            street_nameLabel.Size = new System.Drawing.Size(42, 13);
            street_nameLabel.TabIndex = 12;
            street_nameLabel.Text = "Улица:";
            // 
            // streetGroupBox
            // 
            this.streetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetGroupBox.Controls.Add(this.locality_nameComboBox);
            this.streetGroupBox.Controls.Add(street_nameLabel);
            this.streetGroupBox.Controls.Add(this.street_nameTextBox);
            this.streetGroupBox.Controls.Add(locality_nameLabel);
            this.streetGroupBox.Controls.Add(area_nameLabel);
            this.streetGroupBox.Controls.Add(this.area_nameComboBox);
            this.streetGroupBox.Controls.Add(region_nameLabel);
            this.streetGroupBox.Controls.Add(this.region_nameComboBox);
            this.streetGroupBox.Controls.Add(this.cancelButton);
            this.streetGroupBox.Controls.Add(this.saveButton);
            this.streetGroupBox.Enabled = false;
            this.streetGroupBox.Location = new System.Drawing.Point(12, 291);
            this.streetGroupBox.MaximumSize = new System.Drawing.Size(226, 212);
            this.streetGroupBox.MinimumSize = new System.Drawing.Size(226, 212);
            this.streetGroupBox.Name = "streetGroupBox";
            this.streetGroupBox.Size = new System.Drawing.Size(226, 212);
            this.streetGroupBox.TabIndex = 29;
            this.streetGroupBox.TabStop = false;
            this.streetGroupBox.Text = "Информация о населенном пункте";
            // 
            // locality_nameComboBox
            // 
            this.locality_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streetBindingSource, "Id_locality", true));
            this.locality_nameComboBox.DataSource = this.localityBindingSource;
            this.locality_nameComboBox.DisplayMember = "Address";
            this.locality_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locality_nameComboBox.FormattingEnabled = true;
            this.locality_nameComboBox.Location = new System.Drawing.Point(9, 113);
            this.locality_nameComboBox.Name = "locality_nameComboBox";
            this.locality_nameComboBox.Size = new System.Drawing.Size(206, 21);
            this.locality_nameComboBox.TabIndex = 14;
            this.locality_nameComboBox.ValueMember = "Id_locality";
            // 
            // streetBindingSource
            // 
            this.streetBindingSource.DataMember = "Street";
            this.streetBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localityBindingSource
            // 
            this.localityBindingSource.DataMember = "Locality";
            this.localityBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // street_nameTextBox
            // 
            this.street_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.streetBindingSource, "Street_name", true));
            this.street_nameTextBox.Location = new System.Drawing.Point(9, 153);
            this.street_nameTextBox.Name = "street_nameTextBox";
            this.street_nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.street_nameTextBox.TabIndex = 13;
            // 
            // area_nameComboBox
            // 
            this.area_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streetBindingSource, "Id_area", true));
            this.area_nameComboBox.DataSource = this.areaBindingSource;
            this.area_nameComboBox.DisplayMember = "Area_name";
            this.area_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_nameComboBox.FormattingEnabled = true;
            this.area_nameComboBox.Location = new System.Drawing.Point(9, 75);
            this.area_nameComboBox.Name = "area_nameComboBox";
            this.area_nameComboBox.Size = new System.Drawing.Size(206, 21);
            this.area_nameComboBox.TabIndex = 8;
            this.area_nameComboBox.ValueMember = "Id_area";
            this.area_nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.area_nameComboBox_SelectionChangeCommitted);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // region_nameComboBox
            // 
            this.region_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.streetBindingSource, "Id_region", true));
            this.region_nameComboBox.DataSource = this.regionBindingSource;
            this.region_nameComboBox.DisplayMember = "Region_name";
            this.region_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.region_nameComboBox.FormattingEnabled = true;
            this.region_nameComboBox.Location = new System.Drawing.Point(9, 32);
            this.region_nameComboBox.Name = "region_nameComboBox";
            this.region_nameComboBox.Size = new System.Drawing.Size(206, 21);
            this.region_nameComboBox.TabIndex = 10;
            this.region_nameComboBox.ValueMember = "Id_region";
            this.region_nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.region_nameComboBox_SelectionChangeCommitted);
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // localitytypeBindingSource
            // 
            this.localitytypeBindingSource.DataMember = "Locality_type";
            this.localitytypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 28;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 10);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 27;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // streetsDataGridView
            // 
            this.streetsDataGridView.AllowUserToAddRows = false;
            this.streetsDataGridView.AllowUserToDeleteRows = false;
            this.streetsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetsDataGridView.AutoGenerateColumns = false;
            this.streetsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.streetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.streetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.streetnameDataGridViewTextBoxColumn,
            this.localitynameDataGridViewTextBoxColumn,
            this.localitytypenameDataGridViewTextBoxColumn,
            this.areanameDataGridViewTextBoxColumn,
            this.regionnameDataGridViewTextBoxColumn});
            this.streetsDataGridView.DataSource = this.streetBindingSource;
            this.streetsDataGridView.Location = new System.Drawing.Point(12, 39);
            this.streetsDataGridView.Name = "streetsDataGridView";
            this.streetsDataGridView.ReadOnly = true;
            this.streetsDataGridView.RowHeadersVisible = false;
            this.streetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.streetsDataGridView.Size = new System.Drawing.Size(776, 246);
            this.streetsDataGridView.TabIndex = 26;
            this.streetsDataGridView.SelectionChanged += new System.EventHandler(this.streetsDataGridView_SelectionChanged);
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "Street_name";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitynameDataGridViewTextBoxColumn
            // 
            this.localitynameDataGridViewTextBoxColumn.DataPropertyName = "Locality_name";
            this.localitynameDataGridViewTextBoxColumn.HeaderText = "Нас. пункт";
            this.localitynameDataGridViewTextBoxColumn.Name = "localitynameDataGridViewTextBoxColumn";
            this.localitynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitytypenameDataGridViewTextBoxColumn
            // 
            this.localitytypenameDataGridViewTextBoxColumn.DataPropertyName = "Locality_type_name";
            this.localitytypenameDataGridViewTextBoxColumn.HeaderText = "Тип. нас пункта";
            this.localitytypenameDataGridViewTextBoxColumn.Name = "localitytypenameDataGridViewTextBoxColumn";
            this.localitytypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areanameDataGridViewTextBoxColumn
            // 
            this.areanameDataGridViewTextBoxColumn.DataPropertyName = "Area_name";
            this.areanameDataGridViewTextBoxColumn.HeaderText = "Район";
            this.areanameDataGridViewTextBoxColumn.Name = "areanameDataGridViewTextBoxColumn";
            this.areanameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionnameDataGridViewTextBoxColumn
            // 
            this.regionnameDataGridViewTextBoxColumn.DataPropertyName = "Region_name";
            this.regionnameDataGridViewTextBoxColumn.HeaderText = "Область";
            this.regionnameDataGridViewTextBoxColumn.Name = "regionnameDataGridViewTextBoxColumn";
            this.regionnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // streetTableAdapter
            // 
            this.streetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CarViewTableAdapter = null;
            this.tableAdapterManager.Locality_typeTableAdapter = this.locality_typeTableAdapter;
            this.tableAdapterManager.LocalityTableAdapter = this.localityTableAdapter;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Product_typeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductViewTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = this.regionTableAdapter;
            this.tableAdapterManager.Request_structTableAdapter = null;
            this.tableAdapterManager.RequestStructViewTableAdapter = null;
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.Route_structViewTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopRequestViewTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = this.streetTableAdapter;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // locality_typeTableAdapter
            // 
            this.locality_typeTableAdapter.ClearBeforeFill = true;
            // 
            // localityTableAdapter
            // 
            this.localityTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // StreetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.streetGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.streetsDataGridView);
            this.Controls.Add(this.addButton);
            this.MinimumSize = new System.Drawing.Size(816, 546);
            this.Name = "StreetsForm";
            this.Text = "StreetsForm";
            this.Load += new System.EventHandler(this.StreetsForm_Load);
            this.streetGroupBox.ResumeLayout(false);
            this.streetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox streetGroupBox;
        private System.Windows.Forms.ComboBox area_nameComboBox;
        private System.Windows.Forms.ComboBox region_nameComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView streetsDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource streetBindingSource;
        private MilkWorkDataSetTableAdapters.StreetTableAdapter streetTableAdapter;
        private System.Windows.Forms.ComboBox locality_nameComboBox;
        private System.Windows.Forms.TextBox street_nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitytypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionnameDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private MilkWorkDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MilkWorkDataSetTableAdapters.LocalityTableAdapter localityTableAdapter;
        private System.Windows.Forms.BindingSource localityBindingSource;
        private MilkWorkDataSetTableAdapters.Locality_typeTableAdapter locality_typeTableAdapter;
        private System.Windows.Forms.BindingSource localitytypeBindingSource;
    }
}