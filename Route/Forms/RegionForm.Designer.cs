namespace Route.Forms
{
    partial class RegionForm
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
            System.Windows.Forms.Label region_nameLabel;
            this.regionGroupBox = new System.Windows.Forms.GroupBox();
            this.region_nameTextBox = new System.Windows.Forms.TextBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.regionsDataGridView = new System.Windows.Forms.DataGridView();
            this.regionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.regionTableAdapter = new Route.MilkWorkDataSetTableAdapters.RegionTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            region_nameLabel = new System.Windows.Forms.Label();
            this.regionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // region_nameLabel
            // 
            region_nameLabel.AutoSize = true;
            region_nameLabel.Location = new System.Drawing.Point(8, 16);
            region_nameLabel.Name = "region_nameLabel";
            region_nameLabel.Size = new System.Drawing.Size(41, 13);
            region_nameLabel.TabIndex = 5;
            region_nameLabel.Text = "Район:";
            // 
            // regionGroupBox
            // 
            this.regionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionGroupBox.Controls.Add(region_nameLabel);
            this.regionGroupBox.Controls.Add(this.region_nameTextBox);
            this.regionGroupBox.Controls.Add(this.cancelButton);
            this.regionGroupBox.Controls.Add(this.saveButton);
            this.regionGroupBox.Enabled = false;
            this.regionGroupBox.Location = new System.Drawing.Point(12, 285);
            this.regionGroupBox.Name = "regionGroupBox";
            this.regionGroupBox.Size = new System.Drawing.Size(308, 101);
            this.regionGroupBox.TabIndex = 14;
            this.regionGroupBox.TabStop = false;
            this.regionGroupBox.Text = "Информация о районе";
            // 
            // region_nameTextBox
            // 
            this.region_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.region_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "Region_name", true));
            this.region_nameTextBox.Location = new System.Drawing.Point(11, 32);
            this.region_nameTextBox.Name = "region_nameTextBox";
            this.region_nameTextBox.Size = new System.Drawing.Size(291, 20);
            this.region_nameTextBox.TabIndex = 6;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 11);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // regionsDataGridView
            // 
            this.regionsDataGridView.AllowUserToAddRows = false;
            this.regionsDataGridView.AllowUserToDeleteRows = false;
            this.regionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionsDataGridView.AutoGenerateColumns = false;
            this.regionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.regionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionnameDataGridViewTextBoxColumn});
            this.regionsDataGridView.DataSource = this.regionBindingSource;
            this.regionsDataGridView.Location = new System.Drawing.Point(12, 40);
            this.regionsDataGridView.Name = "regionsDataGridView";
            this.regionsDataGridView.ReadOnly = true;
            this.regionsDataGridView.RowHeadersVisible = false;
            this.regionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.regionsDataGridView.Size = new System.Drawing.Size(308, 239);
            this.regionsDataGridView.TabIndex = 11;
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
            this.addButton.Location = new System.Drawing.Point(12, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
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
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 398);
            this.Controls.Add(this.regionGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.regionsDataGridView);
            this.Controls.Add(this.addButton);
            this.Name = "RegionForm";
            this.Text = "RegionForm";
            this.Load += new System.EventHandler(this.RegionForm_Load);
            this.regionGroupBox.ResumeLayout(false);
            this.regionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox regionGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView regionsDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private MilkWorkDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.TextBox region_nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionnameDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}