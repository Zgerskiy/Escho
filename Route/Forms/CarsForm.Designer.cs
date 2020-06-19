namespace Route
{
    partial class CarsForm
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
            System.Windows.Forms.Label car_numberLabel;
            System.Windows.Forms.Label car_type_nameLabel;
            System.Windows.Forms.Label mark_nameLabel;
            System.Windows.Forms.Label model_nameLabel;
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.carViewTableAdapter = new Route.MilkWorkDataSetTableAdapters.CarViewTableAdapter();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.modelNameComboBox = new System.Windows.Forms.ComboBox();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.car_numberTextBox = new System.Windows.Forms.TextBox();
            this.car_type_nameComboBox = new System.Windows.Forms.ComboBox();
            this.cartypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mark_nameComboBox = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.car_typeTableAdapter = new Route.MilkWorkDataSetTableAdapters.Car_typeTableAdapter();
            this.markTableAdapter = new Route.MilkWorkDataSetTableAdapters.MarkTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new Route.MilkWorkDataSetTableAdapters.ModelTableAdapter();
            car_numberLabel = new System.Windows.Forms.Label();
            car_type_nameLabel = new System.Windows.Forms.Label();
            mark_nameLabel = new System.Windows.Forms.Label();
            model_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.carGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_numberLabel
            // 
            car_numberLabel.AutoSize = true;
            car_numberLabel.Location = new System.Drawing.Point(15, 16);
            car_numberLabel.Name = "car_numberLabel";
            car_numberLabel.Size = new System.Drawing.Size(89, 13);
            car_numberLabel.TabIndex = 0;
            car_numberLabel.Text = "Рег номер авто:";
            // 
            // car_type_nameLabel
            // 
            car_type_nameLabel.AutoSize = true;
            car_type_nameLabel.Location = new System.Drawing.Point(15, 55);
            car_type_nameLabel.Name = "car_type_nameLabel";
            car_type_nameLabel.Size = new System.Drawing.Size(93, 13);
            car_type_nameLabel.TabIndex = 2;
            car_type_nameLabel.Text = "Тип автомобиля:";
            // 
            // mark_nameLabel
            // 
            mark_nameLabel.AutoSize = true;
            mark_nameLabel.Location = new System.Drawing.Point(273, 15);
            mark_nameLabel.Name = "mark_nameLabel";
            mark_nameLabel.Size = new System.Drawing.Size(107, 13);
            mark_nameLabel.TabIndex = 4;
            mark_nameLabel.Text = "Марка автомобиля:";
            // 
            // model_nameLabel
            // 
            model_nameLabel.AutoSize = true;
            model_nameLabel.Location = new System.Drawing.Point(273, 55);
            model_nameLabel.Name = "model_nameLabel";
            model_nameLabel.Size = new System.Drawing.Size(113, 13);
            model_nameLabel.TabIndex = 8;
            model_nameLabel.Text = "Модель автомобиля:";
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnumberDataGridViewTextBoxColumn,
            this.cartypenameDataGridViewTextBoxColumn,
            this.marknameDataGridViewTextBoxColumn,
            this.modelnameDataGridViewTextBoxColumn});
            this.carsDataGridView.DataSource = this.carViewBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 36);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowHeadersVisible = false;
            this.carsDataGridView.RowHeadersWidth = 20;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(776, 222);
            this.carsDataGridView.TabIndex = 0;
            this.carsDataGridView.SelectionChanged += new System.EventHandler(this.carsDataGridView_SelectionChanged);
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "Рег. номер авто";
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            this.carnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartypenameDataGridViewTextBoxColumn
            // 
            this.cartypenameDataGridViewTextBoxColumn.DataPropertyName = "Car_type_name";
            this.cartypenameDataGridViewTextBoxColumn.HeaderText = "Тип авто";
            this.cartypenameDataGridViewTextBoxColumn.Name = "cartypenameDataGridViewTextBoxColumn";
            this.cartypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marknameDataGridViewTextBoxColumn
            // 
            this.marknameDataGridViewTextBoxColumn.DataPropertyName = "Mark_name";
            this.marknameDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.marknameDataGridViewTextBoxColumn.Name = "marknameDataGridViewTextBoxColumn";
            this.marknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelnameDataGridViewTextBoxColumn
            // 
            this.modelnameDataGridViewTextBoxColumn.DataPropertyName = "Model_name";
            this.modelnameDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelnameDataGridViewTextBoxColumn.Name = "modelnameDataGridViewTextBoxColumn";
            this.modelnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carViewBindingSource
            // 
            this.carViewBindingSource.DataMember = "CarView";
            this.carViewBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carViewTableAdapter
            // 
            this.carViewTableAdapter.ClearBeforeFill = true;
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(model_nameLabel);
            this.carGroupBox.Controls.Add(this.modelNameComboBox);
            this.carGroupBox.Controls.Add(this.cancelButton);
            this.carGroupBox.Controls.Add(this.saveButton);
            this.carGroupBox.Controls.Add(car_numberLabel);
            this.carGroupBox.Controls.Add(this.car_numberTextBox);
            this.carGroupBox.Controls.Add(car_type_nameLabel);
            this.carGroupBox.Controls.Add(this.car_type_nameComboBox);
            this.carGroupBox.Controls.Add(mark_nameLabel);
            this.carGroupBox.Controls.Add(this.mark_nameComboBox);
            this.carGroupBox.Enabled = false;
            this.carGroupBox.Location = new System.Drawing.Point(12, 264);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(776, 174);
            this.carGroupBox.TabIndex = 1;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Информация об авто";
            // 
            // modelNameComboBox
            // 
            this.modelNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carViewBindingSource, "Mark_name", true));
            this.modelNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carViewBindingSource, "Id_model", true));
            this.modelNameComboBox.DataSource = this.modelBindingSource;
            this.modelNameComboBox.DisplayMember = "Model_name";
            this.modelNameComboBox.FormattingEnabled = true;
            this.modelNameComboBox.Location = new System.Drawing.Point(272, 71);
            this.modelNameComboBox.Name = "modelNameComboBox";
            this.modelNameComboBox.Size = new System.Drawing.Size(239, 21);
            this.modelNameComboBox.TabIndex = 9;
            this.modelNameComboBox.ValueMember = "Id_model";
            this.modelNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.modelNameComboBox_SelectionChangeCommitted);
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "Mark";
            this.markBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(95, 138);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // car_numberTextBox
            // 
            this.car_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carViewBindingSource, "Car_number", true));
            this.car_numberTextBox.Location = new System.Drawing.Point(14, 32);
            this.car_numberTextBox.Name = "car_numberTextBox";
            this.car_numberTextBox.Size = new System.Drawing.Size(239, 20);
            this.car_numberTextBox.TabIndex = 1;
            // 
            // car_type_nameComboBox
            // 
            this.car_type_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carViewBindingSource, "Id_car_type", true));
            this.car_type_nameComboBox.DataSource = this.cartypeBindingSource;
            this.car_type_nameComboBox.DisplayMember = "Car_type_name";
            this.car_type_nameComboBox.FormattingEnabled = true;
            this.car_type_nameComboBox.Location = new System.Drawing.Point(14, 71);
            this.car_type_nameComboBox.Name = "car_type_nameComboBox";
            this.car_type_nameComboBox.Size = new System.Drawing.Size(239, 21);
            this.car_type_nameComboBox.TabIndex = 3;
            this.car_type_nameComboBox.ValueMember = "Id_car_type";
            // 
            // cartypeBindingSource
            // 
            this.cartypeBindingSource.DataMember = "Car_type";
            this.cartypeBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // mark_nameComboBox
            // 
            this.mark_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carViewBindingSource, "Mark_name", true));
            this.mark_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carViewBindingSource, "Id_mark", true));
            this.mark_nameComboBox.DataSource = this.markBindingSource;
            this.mark_nameComboBox.DisplayMember = "Mark_name";
            this.mark_nameComboBox.FormattingEnabled = true;
            this.mark_nameComboBox.Location = new System.Drawing.Point(272, 31);
            this.mark_nameComboBox.Name = "mark_nameComboBox";
            this.mark_nameComboBox.Size = new System.Drawing.Size(239, 21);
            this.mark_nameComboBox.TabIndex = 5;
            this.mark_nameComboBox.ValueMember = "Id_mark";
            this.mark_nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.mark_nameComboBox_SelectionChangeCommitted);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_typeTableAdapter = this.car_typeTableAdapter;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CarViewTableAdapter = this.carViewTableAdapter;
            this.tableAdapterManager.Locality_typeTableAdapter = null;
            this.tableAdapterManager.LocalityTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = this.markTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Product_typeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductViewTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.Request_structTableAdapter = null;
            this.tableAdapterManager.Route_structTableAdapter = null;
            this.tableAdapterManager.Route_structViewTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Shop_requestTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.ShopViewTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Route.MilkWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_typeTableAdapter
            // 
            this.car_typeTableAdapter.ClearBeforeFill = true;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 7);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(190, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.carGroupBox);
            this.Controls.Add(this.carsDataGridView);
            this.Name = "CarsForm";
            this.Text = "Справочник авто";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource carViewBindingSource;
        private MilkWorkDataSetTableAdapters.CarViewTableAdapter carViewTableAdapter;
        private System.Windows.Forms.GroupBox carGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox car_numberTextBox;
        private System.Windows.Forms.ComboBox car_type_nameComboBox;
        private System.Windows.Forms.ComboBox mark_nameComboBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private MilkWorkDataSetTableAdapters.Car_typeTableAdapter car_typeTableAdapter;
        private System.Windows.Forms.BindingSource cartypeBindingSource;
        private MilkWorkDataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.BindingSource markBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox modelNameComboBox;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private MilkWorkDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
    }
}