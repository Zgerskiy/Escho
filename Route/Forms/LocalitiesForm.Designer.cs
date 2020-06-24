namespace Route.Forms
{
    partial class LocalitiesForm
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
            System.Windows.Forms.Label locality_type_nameLabel;
            this.localityGroupBox = new System.Windows.Forms.GroupBox();
            this.locality_nameTextBox = new System.Windows.Forms.TextBox();
            this.localityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.area_nameComboBox = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.region_nameComboBox = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locality_type_nameComboBox = new System.Windows.Forms.ComboBox();
            this.localitytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.localitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.localitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitytypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.localityTableAdapter = new Route.MilkWorkDataSetTableAdapters.LocalityTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new Route.MilkWorkDataSetTableAdapters.AreaTableAdapter();
            this.locality_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Locality_typeTableAdapter();
            this.regionTableAdapter = new Route.MilkWorkDataSetTableAdapters.RegionTableAdapter();
            locality_nameLabel = new System.Windows.Forms.Label();
            area_nameLabel = new System.Windows.Forms.Label();
            region_nameLabel = new System.Windows.Forms.Label();
            locality_type_nameLabel = new System.Windows.Forms.Label();
            this.localityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locality_nameLabel
            // 
            locality_nameLabel.AutoSize = true;
            locality_nameLabel.Location = new System.Drawing.Point(9, 139);
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
            // locality_type_nameLabel
            // 
            locality_type_nameLabel.AutoSize = true;
            locality_type_nameLabel.Location = new System.Drawing.Point(9, 99);
            locality_type_nameLabel.Name = "locality_type_nameLabel";
            locality_type_nameLabel.Size = new System.Drawing.Size(132, 13);
            locality_type_nameLabel.TabIndex = 11;
            locality_type_nameLabel.Text = "тип населенного пункта:";
            // 
            // localityGroupBox
            // 
            this.localityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localityGroupBox.Controls.Add(locality_nameLabel);
            this.localityGroupBox.Controls.Add(this.locality_nameTextBox);
            this.localityGroupBox.Controls.Add(area_nameLabel);
            this.localityGroupBox.Controls.Add(this.area_nameComboBox);
            this.localityGroupBox.Controls.Add(region_nameLabel);
            this.localityGroupBox.Controls.Add(this.region_nameComboBox);
            this.localityGroupBox.Controls.Add(locality_type_nameLabel);
            this.localityGroupBox.Controls.Add(this.locality_type_nameComboBox);
            this.localityGroupBox.Controls.Add(this.cancelButton);
            this.localityGroupBox.Controls.Add(this.saveButton);
            this.localityGroupBox.Enabled = false;
            this.localityGroupBox.Location = new System.Drawing.Point(12, 218);
            this.localityGroupBox.MaximumSize = new System.Drawing.Size(225, 210);
            this.localityGroupBox.MinimumSize = new System.Drawing.Size(225, 210);
            this.localityGroupBox.Name = "localityGroupBox";
            this.localityGroupBox.Size = new System.Drawing.Size(225, 210);
            this.localityGroupBox.TabIndex = 24;
            this.localityGroupBox.TabStop = false;
            this.localityGroupBox.Text = "Информация о населенном пункте";
            // 
            // locality_nameTextBox
            // 
            this.locality_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localityBindingSource, "Locality_name", true));
            this.locality_nameTextBox.Location = new System.Drawing.Point(9, 155);
            this.locality_nameTextBox.Name = "locality_nameTextBox";
            this.locality_nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.locality_nameTextBox.TabIndex = 6;
            // 
            // localityBindingSource
            // 
            this.localityBindingSource.DataMember = "Locality";
            this.localityBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // area_nameComboBox
            // 
            this.area_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localityBindingSource, "Id_area", true));
            this.area_nameComboBox.DataSource = this.areaBindingSource;
            this.area_nameComboBox.DisplayMember = "Area_name";
            this.area_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_nameComboBox.FormattingEnabled = true;
            this.area_nameComboBox.Location = new System.Drawing.Point(9, 75);
            this.area_nameComboBox.Name = "area_nameComboBox";
            this.area_nameComboBox.Size = new System.Drawing.Size(206, 21);
            this.area_nameComboBox.TabIndex = 8;
            this.area_nameComboBox.ValueMember = "Id_area";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // region_nameComboBox
            // 
            this.region_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localityBindingSource, "Id_region", true));
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
            // locality_type_nameComboBox
            // 
            this.locality_type_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.localityBindingSource, "Id_locality_type", true));
            this.locality_type_nameComboBox.DataSource = this.localitytypeBindingSource;
            this.locality_type_nameComboBox.DisplayMember = "Locality_type_name";
            this.locality_type_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locality_type_nameComboBox.FormattingEnabled = true;
            this.locality_type_nameComboBox.Location = new System.Drawing.Point(9, 115);
            this.locality_type_nameComboBox.Name = "locality_type_nameComboBox";
            this.locality_type_nameComboBox.Size = new System.Drawing.Size(206, 21);
            this.locality_type_nameComboBox.TabIndex = 12;
            this.locality_type_nameComboBox.ValueMember = "Id_locality_type";
            // 
            // localitytypeBindingSource
            // 
            this.localitytypeBindingSource.DataMember = "Locality_type";
            this.localitytypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 181);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 15);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 15);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // localitiesDataGridView
            // 
            this.localitiesDataGridView.AllowUserToAddRows = false;
            this.localitiesDataGridView.AllowUserToDeleteRows = false;
            this.localitiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localitiesDataGridView.AutoGenerateColumns = false;
            this.localitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.localitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localitynameDataGridViewTextBoxColumn,
            this.localitytypenameDataGridViewTextBoxColumn,
            this.areanameDataGridViewTextBoxColumn,
            this.regionnameDataGridViewTextBoxColumn});
            this.localitiesDataGridView.DataSource = this.localityBindingSource;
            this.localitiesDataGridView.Location = new System.Drawing.Point(12, 44);
            this.localitiesDataGridView.Name = "localitiesDataGridView";
            this.localitiesDataGridView.ReadOnly = true;
            this.localitiesDataGridView.RowHeadersVisible = false;
            this.localitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.localitiesDataGridView.Size = new System.Drawing.Size(780, 168);
            this.localitiesDataGridView.TabIndex = 21;
            this.localitiesDataGridView.SelectionChanged += new System.EventHandler(this.localitiesDataGridView_SelectionChanged);
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
            this.localitytypenameDataGridViewTextBoxColumn.HeaderText = "Тип";
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
            this.addButton.Location = new System.Drawing.Point(12, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // localityTableAdapter
            // 
            this.localityTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StreetTableAdapter = null;
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
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // LocalitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 431);
            this.Controls.Add(this.localityGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.localitiesDataGridView);
            this.Controls.Add(this.addButton);
            this.MinimumSize = new System.Drawing.Size(820, 470);
            this.Name = "LocalitiesForm";
            this.Text = "Справочник наслеленных пунктов";
            this.Load += new System.EventHandler(this.LocalitiesForm_Load);
            this.localityGroupBox.ResumeLayout(false);
            this.localityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox localityGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView localitiesDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource localityBindingSource;
        private MilkWorkDataSetTableAdapters.LocalityTableAdapter localityTableAdapter;
        private System.Windows.Forms.TextBox locality_nameTextBox;
        private System.Windows.Forms.ComboBox area_nameComboBox;
        private System.Windows.Forms.ComboBox region_nameComboBox;
        private System.Windows.Forms.ComboBox locality_type_nameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitytypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionnameDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private MilkWorkDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MilkWorkDataSetTableAdapters.Locality_typeTableAdapter locality_typeTableAdapter;
        private System.Windows.Forms.BindingSource localitytypeBindingSource;
    }
}