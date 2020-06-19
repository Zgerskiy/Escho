namespace Route.Forms
{
    partial class CarTypesForm
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
            System.Windows.Forms.Label car_type_nameLabel;
            this.carTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.car_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Car_typeTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.car_type_nameTextBox = new System.Windows.Forms.TextBox();
            this.cartypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            car_type_nameLabel = new System.Windows.Forms.Label();
            this.carTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_typeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carTypeGroupBox
            // 
            this.carTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carTypeGroupBox.Controls.Add(car_type_nameLabel);
            this.carTypeGroupBox.Controls.Add(this.car_type_nameTextBox);
            this.carTypeGroupBox.Controls.Add(this.cancelButton);
            this.carTypeGroupBox.Controls.Add(this.saveButton);
            this.carTypeGroupBox.Enabled = false;
            this.carTypeGroupBox.Location = new System.Drawing.Point(12, 282);
            this.carTypeGroupBox.Name = "carTypeGroupBox";
            this.carTypeGroupBox.Size = new System.Drawing.Size(301, 88);
            this.carTypeGroupBox.TabIndex = 9;
            this.carTypeGroupBox.TabStop = false;
            this.carTypeGroupBox.Text = "Информация о типе авто";
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
            this.removeButton.Location = new System.Drawing.Point(184, 8);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 8);
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
            this.cartypenameDataGridViewTextBoxColumn});
            this.marksDataGridView.DataSource = this.car_typeBindingSource;
            this.marksDataGridView.Location = new System.Drawing.Point(12, 37);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.ReadOnly = true;
            this.marksDataGridView.RowHeadersVisible = false;
            this.marksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksDataGridView.Size = new System.Drawing.Size(301, 239);
            this.marksDataGridView.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_typeBindingSource
            // 
            this.car_typeBindingSource.DataMember = "Car_type";
            this.car_typeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // car_typeTableAdapter
            // 
            this.car_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = this.car_typeTableAdapter;
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
            this.tableAdapterManager.ShopRequestViewTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_type_nameLabel
            // 
            car_type_nameLabel.AutoSize = true;
            car_type_nameLabel.Location = new System.Drawing.Point(6, 16);
            car_type_nameLabel.Name = "car_type_nameLabel";
            car_type_nameLabel.Size = new System.Drawing.Size(55, 13);
            car_type_nameLabel.TabIndex = 5;
            car_type_nameLabel.Text = "Тип авто:";
            // 
            // car_type_nameTextBox
            // 
            this.car_type_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_typeBindingSource, "Car_type_name", true));
            this.car_type_nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.car_type_nameTextBox.Name = "car_type_nameTextBox";
            this.car_type_nameTextBox.Size = new System.Drawing.Size(289, 20);
            this.car_type_nameTextBox.TabIndex = 6;
            // 
            // cartypenameDataGridViewTextBoxColumn
            // 
            this.cartypenameDataGridViewTextBoxColumn.DataPropertyName = "Car_type_name";
            this.cartypenameDataGridViewTextBoxColumn.HeaderText = "Тип авто";
            this.cartypenameDataGridViewTextBoxColumn.Name = "cartypenameDataGridViewTextBoxColumn";
            this.cartypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 382);
            this.Controls.Add(this.carTypeGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.marksDataGridView);
            this.Controls.Add(this.addButton);
            this.Name = "CarTypesForm";
            this.Text = "CarTypesForm";
            this.Load += new System.EventHandler(this.CarTypesForm_Load);
            this.carTypeGroupBox.ResumeLayout(false);
            this.carTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_typeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox carTypeGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource car_typeBindingSource;
        private MilkWorkDataSetTableAdapters.Car_typeTableAdapter car_typeTableAdapter;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox car_type_nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartypenameDataGridViewTextBoxColumn;
    }
}