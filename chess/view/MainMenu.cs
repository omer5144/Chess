using chess.vm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess.view
{
    public partial class MainMenu : Form
    {
        // MainMenu:
        // this class represent main menu form

        private readonly IViewmodel _vm; // the view-model

        public MainMenu(IViewmodel vm)
        {
            InitializeComponent();

            _vm = vm;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(20, 20);
            this.Size = new Size(624, 612);

            background.Location = new Point(12, 84);
            background.Size = new Size(600, 516);

            Close.Size = new Size(60, 60);
            Close.Location = new Point(552, 12);

            title.Location = new Point(90, 96);
            name.Location = new Point(14, 575);

            Play.Location = new Point(162, 300);
            Play.Size = new Size(300, 130);

            logo.Location = new Point(12, 12);
            logo.Size = new Size(60, 60);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Names f = new Names(_vm);
            f.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
