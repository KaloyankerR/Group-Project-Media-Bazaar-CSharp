using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MessageForm : Form
    {
        public string status;
        public string message;
        public MessageForm(string _status)
        {
            InitializeComponent();
            this.status = _status;
            label1.Text = $"Give reason for {status} request:";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            message = richTextBox1.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            message = richTextBox1.Text;
            this.Close();
        }
    }
}
