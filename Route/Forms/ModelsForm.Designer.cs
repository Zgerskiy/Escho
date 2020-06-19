namespace Route.Forms
{
    partial class ModelsForm
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
            System.Windows.Forms.Label model_nameLabel;
            System.Windows.Forms.Label mark_nameLabel;
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.modelsDataGridView = new System.Windows.Forms.DataGridView();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markTableAdapter = new Route.MilkWorkDataSetTableAdapters.MarkTableAdapter();
            this.modelTableAdapter = new Route.MilkWorkDataSetTableAdapters.ModelTableAdapter();
            this.modelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            this.model_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mark_nameComboBox = new System.Windows.Forms.ComboBox();
            model_nameLabel = new System.Windows.Forms.Label();
            mark_nameLabel = new System.Windows.Forms.Label();
            this.modelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // modelGroupBox
            // 
            this.modelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelGroupBox.Controls.Add(model_nameLabel);
            this.modelGroupBox.Controls.Add(this.model_nameTextEdit);
            this.modelGroupBox.Controls.Add(mark_nameLabel);
            this.modelGroupBox.Controls.Add(this.mark_nameComboBox);
            this.modelGroupBox.Controls.Add(this.cancelButton);
            this.modelGroupBox.Controls.Add(this.saveButton);
            this.modelGroupBox.Enabled = false;
            this.modelGroupBox.Location = new System.Drawing.Point(12, 286);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.Size = new System.Drawing.Size(776, 124);
            this.modelGroupBox.TabIndex = 9;
            this.modelGroupBox.TabStop = false;
            this.modelGroupBox.Text = "Информация о модели";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 97);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 97);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(174, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // modelsDataGridView
            // 
            this.modelsDataGridView.AllowUserToAddRows = false;
            this.modelsDataGridView.AllowUserToDeleteRows = false;
            this.modelsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsDataGridView.AutoGenerateColumns = false;
            this.modelsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelnameDataGridViewTextBoxColumn,
            this.marknameDataGridViewTextBoxColumn});
            this.modelsDataGridView.DataSource = this.modelBindingSource;
            this.modelsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.modelsDataGridView.Name = "modelsDataGridView";
            this.modelsDataGridView.ReadOnly = true;
            this.modelsDataGridView.RowHeadersVisible = false;
            this.modelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelsDataGridView.Size = new System.Drawing.Size(776, 239);
            this.modelsDataGridView.TabIndex = 6;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.milkWorkDataSet;
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
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "Mark";
            this.markBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // modelnameDataGridViewTextBoxColumn
            // 
            this.modelnameDataGridViewTextBoxColumn.DataPropertyName = "Model_name";
            this.modelnameDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelnameDataGridViewTextBoxColumn.Name = "modelnameDataGridViewTextBoxColumn";
            this.modelnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marknameDataGridViewTextBoxColumn
            // 
            this.marknameDataGridViewTextBoxColumn.DataPropertyName = "Mark_name";
            this.marknameDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.marknameDataGridViewTextBoxColumn.Name = "marknameDataGridViewTextBoxColumn";
            this.marknameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tableAdapterManager.MarkTableAdapter = this.markTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
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
            // model_nameLabel
            // 
            model_nameLabel.AutoSize = true;
            model_nameLabel.Location = new System.Drawing.Point(7, 16);
            model_nameLabel.Name = "model_nameLabel";
            model_nameLabel.Size = new System.Drawing.Size(49, 13);
            model_nameLabel.TabIndex = 5;
            model_nameLabel.Text = "Модель:";
            // 
            // model_nameTextEdit
            // 
            this.model_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Model_name", true));
            this.model_nameTextEdit.Location = new System.Drawing.Point(6, 32);
            this.model_nameTextEdit.Name = "model_nameTextEdit";
            this.model_nameTextEdit.Size = new System.Drawing.Size(212, 20);
            this.model_nameTextEdit.TabIndex = 6;
            // 
            // mark_nameLabel
            // 
            mark_nameLabel.AutoSize = true;
            mark_nameLabel.Location = new System.Drawing.Point(6, 54);
            mark_nameLabel.Name = "mark_nameLabel";
            mark_nameLabel.Size = new System.Drawing.Size(43, 13);
            mark_nameLabel.TabIndex = 7;
            mark_nameLabel.Text = "Марка:";
            // 
            // mark_nameComboBox
            // 
            this.mark_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelBindingSource, "Id_mark", true));
            this.mark_nameComboBox.DataSource = this.markBindingSource;
            this.mark_nameComboBox.DisplayMember = "Mark_name";
            this.mark_nameComboBox.FormattingEnabled = true;
            this.mark_nameComboBox.Location = new System.Drawing.Point(6, 70);
            this.mark_nameComboBox.Name = "mark_nameComboBox";
            this.mark_nameComboBox.Size = new System.Drawing.Size(212, 21);
            this.mark_nameComboBox.TabIndex = 8;
            this.mark_nameComboBox.ValueMember = "Id_mark";
            // 
            // ModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.modelGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.modelsDataGridView);
            this.Controls.Add(this.addButton);
            this.Name = "ModelsForm";
            this.Text = "ModelsForm";
            this.Load += new System.EventHandler(this.ModelsForm_Load);
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView modelsDataGridView;
        private System.Windows.Forms.Button addButton;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource markBindingSource;
        private MilkWorkDataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private MilkWorkDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private DevExpress.XtraEditors.TextEdit model_nameTextEdit;
        private System.Windows.Forms.ComboBox mark_nameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marknameDataGridViewTextBoxColumn;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}