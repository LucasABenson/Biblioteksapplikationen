using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bibliotekapplikationen
{
    public partial class ErrorForm : Form
    {
       private string ErrorMsg;
       public ErrorForm(string _errorMsg)
        {
            ErrorMsg = _errorMsg;
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            label1.Text = ErrorMsg;
        }
    }
}
