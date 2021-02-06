using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chess.view
{
    public class Board:Panel
    {
        // Board:
        // this class represent board view component

        private readonly int _w; // width of single cube
        private readonly int _h; // height of single cube
        private readonly PictureBox[,] _pieces; // matrix of pictures of pieces
        private readonly List<PictureBox> _options; // list of pictures of option points
        private readonly MouseEventHandler _function; // press function

        public Board(Size size, Point location, MouseEventHandler function) :base()
        {
            base.Size = size;
            base.Location = location;
            _w = size.Width / 8;
            _h = size.Height / 8;

            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf("\\bin");
            path = path.Substring(0, x) + "\\bin\\Debug\\board.png";

            base.BackgroundImage = Image.FromFile(path);

            base.BackgroundImageLayout = ImageLayout.Stretch;

            this.MouseClick += function;
            _function = function;

            _pieces = new PictureBox[8,8];
            _options = new List<PictureBox>();
        }

        // remove points from screen
        private void DeleteOptions()
        {
            foreach(PictureBox pic in _options)
            {
                base.Controls.Remove(pic);
            }
            _options.Clear();
        }
        
        // remove pieces from screen
        private void DeletePieces()
        {
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if(_pieces[i,j] != null)
                    {
                        base.Controls.Remove(_pieces[i, j]);
                        _pieces[i, j] = null;
                    }
                }
            }
        }

        // draw options on screen
        public void  DrawOptions(List<Point> options)
        {
            DeleteOptions();

            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf("\\bin");
            path = path.Substring(0, x);

            foreach (Point point in options)
            {
                PictureBox pic = new PictureBox
                {
                    ImageLocation = path + "\\bin\\Debug\\choose.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(_w / 3, _h / 3),
                    Location = new Point((point.Y * _w) + _w / 3, (point.X * _h) + _h / 3)
                };
                pic.MouseClick += new MouseEventHandler(_function);
                pic.Name = "option";
                base.Controls.Add(pic);
                pic.BringToFront();

                _options.Add(pic);

            }
        }
        
        // draw pieces on screen
        public void DrawPieces(string[,] matrix)
        {
            DeletePieces();

            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf("\\bin");
            path = path.Substring(0, x);

            base.Controls.Clear();

            
            for (int i =0;i<8;i++)
                for(int j=0;j<8;j++)
                {
                    if (matrix[i, j].Equals("none"))
                        continue;
                    else
                    {
                        PictureBox pic = new PictureBox
                        {
                            ImageLocation = path + "\\bin\\Debug\\" + matrix[i, j] + ".png",
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(_w * 8 / 10, _h * 8 / 10),
                            Location = new Point(j * _w + _w / 10, i * _h + _h / 10)
                        };
                        pic.MouseClick += _function;
                        pic.Name = "piece";
                        pic.SendToBack();
                        if ((i+j)%2==1)
                            pic.BackColor = Color.Gray;
                        else
                            pic.BackColor = Color.White;
                        base.Controls.Add(pic);

                        _pieces[i, j] = pic;
                    }
                }
        } 
    }
}
