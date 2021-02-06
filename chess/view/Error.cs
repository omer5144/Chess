using System;
using System.Windows.Forms;

namespace chess.view
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {

        }

        private void Error_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
