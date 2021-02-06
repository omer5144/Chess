using chess.vm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess.view
{
    public partial class Names : Form
    {
        // Names:
        // this class represent the names input form

        private readonly IViewmodel _vm; // the view-model

        public Names(IViewmodel vm)
        {
            InitializeComponent();

            _vm = vm;
        }

        private void Names_Load(object sender, EventArgs e)
        {
            this.Location = new Point(20, 20);
            this.Size = new Size(324, 324);

            board.Location = new Point(12, 12);
            board.Size = new Size(300, 300);

            close.Size = new Size(40, 40);
            close.Location = new Point(260, 24);

            label1.Location = new Point(30, 30);
            label2.Location = new Point(30, 100);
            label3.Location = new Point(30, 150);
            label4.Location = new Point(13, 285);

            textBox1.Location = new Point(120, 100);
            textBox2.Location = new Point(120, 150);

            start.Location = new Point(40, 200);
            start.Size = new Size(244, 70);
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                label4.Text = "*player1, enter name";
                label4.Visible = true;
                return;
            }
            else if (textBox1.Text.Length > 5)
            {
                label4.Text = "*player1, enter 5 letters or less";
                label4.Visible = true;
                return;
            }
            else if (textBox2.Text.Length <= 0)
            {
                label4.Text = "*player2, enter name";
                label4.Visible = true;
                return;
            }
            else if (textBox2.Text.Length > 5)
            {
                label4.Text = "*player2, enter 5 letters or less";
                label4.Visible = true;
                return;
            }
            this.Hide();

            try
            {
                Play f = new Play(_vm, textBox1.Text, textBox2.Text);
                f.Show();
            }
            catch
            {
                Error f = new Error();
                f.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu(_vm);
            f.Show();
            this.Hide();
        }

        private void Names_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
