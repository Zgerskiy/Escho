namespace Route.Forms
{
    partial class MarksForm
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
            System.Windows.Forms.Label mark_nameLabel;
            this.addButton = new System.Windows.Forms.Button();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.marknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkWorkDataSet = new Route.MilkWorkDataSet();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.markGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mark_nameTextBox = new System.Windows.Forms.TextBox();
            this.markTableAdapter = new Route.MilkWorkDataSetTableAdapters.MarkTableAdapter();
            this.tableAdapterManager = new Route.MilkWorkDataSetTableAdapters.TableAdapterManager();
            mark_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).BeginInit();
            this.markGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mark_nameLabel
            // 
            mark_nameLabel.AutoSize = true;
            mark_nameLabel.Location = new System.Drawing.Point(6, 16);
            mark_nameLabel.Name = "mark_nameLabel";
            mark_nameLabel.Size = new System.Drawing.Size(43, 13);
            mark_nameLabel.TabIndex = 0;
            mark_nameLabel.Text = "Марка:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // marksDataGridView
            // 
            this.marksDataGridView.AllowUserToAddRows = false;
            this.marksDataGridView.AllowUserToDeleteRows = false;
            this.marksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksDataGridView.AutoGenerateColumns = false;
            this.marksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marknameDataGridViewTextBoxColumn});
            this.marksDataGridView.DataSource = this.markBindingSource;
            this.marksDataGridView.Location = new System.Drawing.Point(12, 41);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.ReadOnly = true;
            this.marksDataGridView.RowHeadersVisible = false;
            this.marksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksDataGridView.Size = new System.Drawing.Size(340, 242);
            this.marksDataGridView.TabIndex = 1;
            // 
            // marknameDataGridViewTextBoxColumn
            // 
            this.marknameDataGridViewTextBoxColumn.DataPropertyName = "Mark_name";
            this.marknameDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.marknameDataGridViewTextBoxColumn.Name = "marknameDataGridViewTextBoxColumn";
            this.marknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "Mark";
            this.markBindingSource.DataSource = this.milkWorkDataSet;
            // 
            // milkWorkDataSet
            // 
            this.milkWorkDataSet.DataSetName = "MilkWorkDataSet";
            this.milkWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.removeButton.Location = new System.Drawing.Point(184, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // markGroupBox
            // 
            this.markGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markGroupBox.Controls.Add(this.cancelButton);
            this.markGroupBox.Controls.Add(this.saveButton);
            this.markGroupBox.Controls.Add(mark_nameLabel);
            this.markGroupBox.Controls.Add(this.mark_nameTextBox);
            this.markGroupBox.Enabled = false;
            this.markGroupBox.Location = new System.Drawing.Point(12, 289);
            this.markGroupBox.MaximumSize = new System.Drawing.Size(280, 90);
            this.markGroupBox.MinimumSize = new System.Drawing.Size(280, 90);
            this.markGroupBox.Name = "markGroupBox";
            this.markGroupBox.Size = new System.Drawing.Size(280, 90);
            this.markGroupBox.TabIndex = 4;
            this.markGroupBox.TabStop = false;
            this.markGroupBox.Text = "Информация о марке";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(90, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mark_nameTextBox
            // 
            this.mark_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mark_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.markBindingSource, "Mark_name", true));
            this.mark_nameTextBox.Location = new System.Drawing.Point(9, 32);
            this.mark_nameTextBox.Name = "mark_nameTextBox";
            this.mark_nameTextBox.Size = new System.Drawing.Size(265, 20);
            this.mark_nameTextBox.TabIndex = 1;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
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
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.markGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.marksDataGridView);
            this.Controls.Add(this.addButton);
            this.MinimumSize = new System.Drawing.Size(320, 430);
            this.Name = "MarksForm";
            this.Text = "Справочник марок";
            this.Load += new System.EventHandler(this.MarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkWorkDataSet)).EndInit();
            this.markGroupBox.ResumeLayout(false);
            this.markGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox markGroupBox;
        private MilkWorkDataSet milkWorkDataSet;
        private System.Windows.Forms.BindingSource markBindingSource;
        private MilkWorkDataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox mark_nameTextBox;
        private MilkWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}