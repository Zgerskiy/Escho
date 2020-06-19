namespace Route.Forms
{
    partial class MainForm
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
            this.carsButton = new System.Windows.Forms.Button();
            this.shopsButton = new System.Windows.Forms.Button();
            this.routsButton = new System.Windows.Forms.Button();
            this.shopRequestsButton = new System.Windows.Forms.Button();
            this.marksButton = new System.Windows.Forms.Button();
            this.modelsButton = new System.Windows.Forms.Button();
            this.carTypesButton = new System.Windows.Forms.Button();
            this.unitsButton = new System.Windows.Forms.Button();
            this.prodTypeButtons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carsButton
            // 
            this.carsButton.Location = new System.Drawing.Point(22, 12);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(129, 23);
            this.carsButton.TabIndex = 0;
            this.carsButton.Text = "Автомобили";
            this.carsButton.UseVisualStyleBackColor = true;
            this.carsButton.Click += new System.EventHandler(this.carsButton_Click);
            // 
            // shopsButton
            // 
            this.shopsButton.Location = new System.Drawing.Point(22, 41);
            this.shopsButton.Name = "shopsButton";
            this.shopsButton.Size = new System.Drawing.Size(129, 23);
            this.shopsButton.TabIndex = 1;
            this.shopsButton.Text = "Магазины";
            this.shopsButton.UseVisualStyleBackColor = true;
            this.shopsButton.Click += new System.EventHandler(this.shopsButton_Click);
            // 
            // routsButton
            // 
            this.routsButton.Location = new System.Drawing.Point(22, 70);
            this.routsButton.Name = "routsButton";
            this.routsButton.Size = new System.Drawing.Size(129, 23);
            this.routsButton.TabIndex = 2;
            this.routsButton.Text = "Маршруты";
            this.routsButton.UseVisualStyleBackColor = true;
            this.routsButton.Click += new System.EventHandler(this.routsButton_Click);
            // 
            // shopRequestsButton
            // 
            this.shopRequestsButton.Location = new System.Drawing.Point(22, 99);
            this.shopRequestsButton.Name = "shopRequestsButton";
            this.shopRequestsButton.Size = new System.Drawing.Size(129, 23);
            this.shopRequestsButton.TabIndex = 3;
            this.shopRequestsButton.Text = "Заявки";
            this.shopRequestsButton.UseVisualStyleBackColor = true;
            this.shopRequestsButton.Click += new System.EventHandler(this.shopRequestsButton_Click);
            // 
            // marksButton
            // 
            this.marksButton.Location = new System.Drawing.Point(22, 141);
            this.marksButton.Name = "marksButton";
            this.marksButton.Size = new System.Drawing.Size(129, 23);
            this.marksButton.TabIndex = 4;
            this.marksButton.Text = "Марки";
            this.marksButton.UseVisualStyleBackColor = true;
            this.marksButton.Click += new System.EventHandler(this.marksButton_Click);
            // 
            // modelsButton
            // 
            this.modelsButton.Location = new System.Drawing.Point(22, 170);
            this.modelsButton.Name = "modelsButton";
            this.modelsButton.Size = new System.Drawing.Size(129, 23);
            this.modelsButton.TabIndex = 5;
            this.modelsButton.Text = "Модели";
            this.modelsButton.UseVisualStyleBackColor = true;
            this.modelsButton.Click += new System.EventHandler(this.modelsButton_Click);
            // 
            // carTypesButton
            // 
            this.carTypesButton.Location = new System.Drawing.Point(22, 213);
            this.carTypesButton.Name = "carTypesButton";
            this.carTypesButton.Size = new System.Drawing.Size(129, 23);
            this.carTypesButton.TabIndex = 6;
            this.carTypesButton.Text = "Типы авто";
            this.carTypesButton.UseVisualStyleBackColor = true;
            this.carTypesButton.Click += new System.EventHandler(this.carTypesButton_Click);
            // 
            // unitsButton
            // 
            this.unitsButton.Location = new System.Drawing.Point(22, 257);
            this.unitsButton.Name = "unitsButton";
            this.unitsButton.Size = new System.Drawing.Size(129, 23);
            this.unitsButton.TabIndex = 7;
            this.unitsButton.Text = "Единицы измерения";
            this.unitsButton.UseVisualStyleBackColor = true;
            this.unitsButton.Click += new System.EventHandler(this.unitsButton_Click);
            // 
            // prodTypeButtons
            // 
            this.prodTypeButtons.Location = new System.Drawing.Point(22, 286);
            this.prodTypeButtons.Name = "prodTypeButtons";
            this.prodTypeButtons.Size = new System.Drawing.Size(129, 23);
            this.prodTypeButtons.TabIndex = 8;
            this.prodTypeButtons.Text = "Типы продуктов";
            this.prodTypeButtons.UseVisualStyleBackColor = true;
            this.prodTypeButtons.Click += new System.EventHandler(this.prodTypeButtons_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodTypeButtons);
            this.Controls.Add(this.unitsButton);
            this.Controls.Add(this.carTypesButton);
            this.Controls.Add(this.modelsButton);
            this.Controls.Add(this.marksButton);
            this.Controls.Add(this.shopRequestsButton);
            this.Controls.Add(this.routsButton);
            this.Controls.Add(this.shopsButton);
            this.Controls.Add(this.carsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carsButton;
        private System.Windows.Forms.Button shopsButton;
        private System.Windows.Forms.Button routsButton;
        private System.Windows.Forms.Button shopRequestsButton;
        private System.Windows.Forms.Button marksButton;
        private System.Windows.Forms.Button modelsButton;
        private System.Windows.Forms.Button carTypesButton;
        private System.Windows.Forms.Button unitsButton;
        private System.Windows.Forms.Button prodTypeButtons;
    }
}