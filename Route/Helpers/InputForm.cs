using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route.Helpers
{
    public partial class InputForm : Form
    {
        public InputForm(string formTitle, string textTitle)
        {
            InitializeComponent();
            this.Text = formTitle;
            titleLabel.Text = textTitle;
        }

        public string Value = "";

        private void saveButton_Click(object sender, EventArgs e)
        {
            Value = inputTextBox.Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
