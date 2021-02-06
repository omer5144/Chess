using chess.pattern;
using chess.vm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess.view
{
    public partial class Play : Form, IObserver
    {
        // Play:
        // this class represent the game form:

        private readonly Board _board; // board view component
        private readonly IViewmodel _vm; // the view-model
        private Point _lastPoint; // last point that pressed
        private readonly string _player1; // name of white player
        private readonly string _player2; // name of black player

        public Play(IViewmodel vm, string _player1, string _player2)
        {
            _vm = vm;
            _vm.Retry();
            _vm.Add(this);

            InitializeComponent();
            this.Size = new Size(700, 700);

            _board = new Board(new Size(600, 600), new Point(12, 12), BoardPressed);
            _lastPoint = new Point(-1, -1);

            this._player1 = _player1;
            this._player2 = _player2;
        }

        private void View_Load(object sender, EventArgs e)
        {
            _vm.ComputeBoard();
            this.Controls.Add(_board);

            this.Location = new Point(20, 20);
            this.Size = new Size(885, 624);

            wood.Size = new Size(249, 600);
            wood.Location = new Point(624, 12);

            back.Size = new Size(225, 75);
            back.Location = new Point(636, 525);

            retry.Size = new Size(225, 75);
            retry.Location = new Point(636, 438);

            background1.Size = new Size(225, 75);
            background1.Location = new Point(636, 24);

            background2.Size = new Size(225, 75);
            background2.Location = new Point(636, 111);

            name1.Location = new Point(650, 40);
            name1.Text = _player1;

            name2.Location = new Point(650, 127);
            name2.Text = _player2;

            color1.Size = new Size(57, 57);
            color1.Location = new Point(795, 33);

            color2.Size = new Size(57, 57);
            color2.Location = new Point(795, 120);

            turn1.Size = new Size(65, 65);
            turn1.Location = new Point(791, 28);
            turn1.Visible = true;

            turn2.Size = new Size(65, 65);
            turn2.Location = new Point(791, 115);
            turn2.Visible = false;

            crown.Size = new Size(45, 45);
            crown.Visible = false;
        }

        public void BoardPressed(object sender, MouseEventArgs e)
        {
            Board b;
            int x, y;
            if (sender is Board)
            {
                x = e.X;
                y = e.Y;
                b = sender as Board;
            }    
            else
            {
                PictureBox pic = sender as PictureBox;
                x = e.X+pic.Location.X;
                y = e.Y+pic.Location.Y;
                b = pic.Parent as Board;
            }

            x /= (b.Width / 8);
            y /= (b.Height / 8);

            Point point = new Point(y, x);
            if(_vm.GetPoints().Contains(point))
            {
                _vm.MovePiece(_lastPoint, point);
                _lastPoint = new Point(-1, -1);
                _vm.ComputeBoard();

                turn1.Visible = !turn1.Visible;
                turn2.Visible = !turn2.Visible;
            }
            else
            {
                _vm.ComputePoints(point);
                _lastPoint = point;
            }
        }

        public void Update(string data, Observable o)
        {
            if (data.Equals("points"))
            {
                _board.DrawOptions(_vm.GetPoints());
            }
            else if (data.Equals("board"))
            {
                _board.DrawPieces(_vm.GetBoard());
                _board.DrawOptions(_vm.GetPoints());
            }
            else if(data.StartsWith("win"))
            {
                turn1.Visible = true;
                turn2.Visible = true;
                _board.Enabled = false;

                if (data.EndsWith("black"))
                {
                    crown.Location = new Point(801, 126);
                    crown.BackColor = Color.Gray;
                }
                else
                {
                    crown.Location = new Point(801, 39);
                    crown.BackColor = Color.White;
                }
                crown.Visible = true;
            }
        }

        private void retry_Click(object sender, EventArgs e)
        {
            _vm.Remove(this);
            this.Hide();

            Play f = new Play(_vm, name1.Text, name2.Text);
            f.View_Load(this, null);
            _vm.Add(f);
            f.Show();


        }

        private void back_Click(object sender, EventArgs e)
        {
            _vm.Remove(this);
            this.Hide();

            MainMenu f = new MainMenu(_vm);
            f.Show();
        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
