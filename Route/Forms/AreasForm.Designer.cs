namespace Route.Forms
{
    partial class AreasForm
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
            System.Windows.Forms.Label area_nameLabel;
            System.Windows.Forms.Label id_regionLabel;
            this.areaGroupBox = new System.Windows.Forms.GroupBox();
            this.area_nameTextBox = new System.Windows.Forms.TextBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.id_regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.areasDataGridView = new System.Windows.Forms.DataGridView();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.areaTableAdapter = new Route.MilkWorkDataSetTableAdapters.AreaTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.regionTableAdapter = new Route.MilkWorkDataSetTableAdapters.RegionTableAdapter();
            area_nameLabel = new System.Windows.Forms.Label();
            id_regionLabel = new System.Windows.Forms.Label();
            this.areaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // area_nameLabel
            // 
            area_nameLabel.AutoSize = true;
            area_nameLabel.Location = new System.Drawing.Point(6, 56);
            area_nameLabel.Name = "area_nameLabel";
            area_nameLabel.Size = new System.Drawing.Size(41, 13);
            area_nameLabel.TabIndex = 5;
            area_nameLabel.Text = "Район:";
            // 
            // id_regionLabel
            // 
            id_regionLabel.AutoSize = true;
            id_regionLabel.Location = new System.Drawing.Point(6, 16);
            id_regionLabel.Name = "id_regionLabel";
            id_regionLabel.Size = new System.Drawing.Size(53, 13);
            id_regionLabel.TabIndex = 7;
            id_regionLabel.Text = "Область:";
            // 
            // areaGroupBox
            // 
            this.areaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areaGroupBox.Controls.Add(area_nameLabel);
            this.areaGroupBox.Controls.Add(this.area_nameTextBox);
            this.areaGroupBox.Controls.Add(id_regionLabel);
            this.areaGroupBox.Controls.Add(this.id_regionComboBox);
            this.areaGroupBox.Controls.Add(this.cancelButton);
            this.areaGroupBox.Controls.Add(this.saveButton);
            this.areaGroupBox.Enabled = false;
            this.areaGroupBox.Location = new System.Drawing.Point(12, 301);
            this.areaGroupBox.MaximumSize = new System.Drawing.Size(259, 129);
            this.areaGroupBox.MinimumSize = new System.Drawing.Size(259, 129);
            this.areaGroupBox.Name = "areaGroupBox";
            this.areaGroupBox.Size = new System.Drawing.Size(259, 129);
            this.areaGroupBox.TabIndex = 19;
            this.areaGroupBox.TabStop = false;
            this.areaGroupBox.Text = "Информация об области";
            // 
            // area_nameTextBox
            // 
            this.area_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "Area_name", true));
            this.area_nameTextBox.Location = new System.Drawing.Point(9, 72);
            this.area_nameTextBox.Name = "area_nameTextBox";
            this.area_nameTextBox.Size = new System.Drawing.Size(238, 20);
            this.area_nameTextBox.TabIndex = 6;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_regionComboBox
            // 
            this.id_regionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.areaBindingSource, "Id_region", true));
            this.id_regionComboBox.DataSource = this.regionBindingSource;
            this.id_regionComboBox.DisplayMember = "Region_name";
            this.id_regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_regionComboBox.FormattingEnabled = true;
            this.id_regionComboBox.Location = new System.Drawing.Point(9, 32);
            this.id_regionComboBox.Name = "id_regionComboBox";
            this.id_regionComboBox.Size = new System.Drawing.Size(238, 21);
            this.id_regionComboBox.TabIndex = 8;
            this.id_regionComboBox.ValueMember = "Id_region";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(90, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 98);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 10);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // areasDataGridView
            // 
            this.areasDataGridView.AllowUserToAddRows = false;
            this.areasDataGridView.AllowUserToDeleteRows = false;
            this.areasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.areasDataGridView.AutoGenerateColumns = false;
            this.areasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.areasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areanameDataGridViewTextBoxColumn,
            this.regionnameDataGridViewTextBoxColumn});
            this.areasDataGridView.DataSource = this.areaBindingSource;
            this.areasDataGridView.Location = new System.Drawing.Point(12, 39);
            this.areasDataGridView.Name = "areasDataGridView";
            this.areasDataGridView.ReadOnly = true;
            this.areasDataGridView.RowHeadersVisible = false;
            this.areasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.areasDataGridView.Size = new System.Drawing.Size(460, 256);
            this.areasDataGridView.TabIndex = 16;
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
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
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
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // AreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.areaGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.areasDataGridView);
            this.Controls.Add(this.addButton);
            this.MinimumSize = new System.Drawing.Size(500, 470);
            this.Name = "AreasForm";
            this.Text = "Справочник районов";
            this.Load += new System.EventHandler(this.AreasForm_Load);
            this.areaGroupBox.ResumeLayout(false);
            this.areaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox areaGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView areasDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MilkWorkDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox area_nameTextBox;
        private System.Windows.Forms.ComboBox id_regionComboBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilkWorkDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource regionBindingSource;
    }
}