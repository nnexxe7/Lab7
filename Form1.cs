using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            this.Width = 600;
            this.Height = 800;
            player.SoundLocation = "muzyka.wav";
            player.Play();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            PointF[] tree = new PointF[]
            {
                new PointF(12, 5),
                new PointF(16, 9),
                new PointF(13, 9),
                new PointF(19, 16),
                new PointF(13, 16),
                new PointF(21, 25),
                new PointF(3, 25),
                new PointF(11, 16),
                new PointF(5, 16),
                new PointF(11, 9),
                new PointF(8, 9)
            };

            PointF[] stump = new PointF[]
            {
                new PointF(10, 25),
                new PointF(14, 25),
                new PointF(14, 32),
                new PointF(10, 32)

            };

            PointF[] star = new PointF[]
            {
                new PointF(12,5),
                new PointF(14,6),
                new PointF(13,4),
                new PointF(15,3),
                new PointF(13,3),
                new PointF(12,1),
                new PointF(11,3),
                new PointF(9,3),
                new PointF(11,4),
                new PointF(10,6),
            };

            PointF[] gifts1 = new PointF[]
            {
                new PointF(6, 26),
                new PointF(9, 26),
                new PointF(9, 29),
                new PointF(6, 29),
            };

            PointF[] gifts2 = new PointF[]
            {
                new PointF(15, 26),
                new PointF(18, 26),
                new PointF(18, 29),
                new PointF(15, 29),
            };

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(tree);
                Matrix m = new Matrix();
                m.Scale(20, 20);
                path.Transform(m);
                e.Graphics.FillPath(Brushes.Green, path);

                foreach (PointF p in path.PathPoints)
                {
                    int s = 15;
                    PointF q = p;
                    q.X -= (s / 2);
                    q.Y -= (s / 2);

                    if (new Random(Guid.NewGuid().GetHashCode()).Next(0, tree.Length) > tree.Length / 2)
                    {
                        Random rnd = new Random();
                        int color = rnd.Next(1, 8);
                        if (color == 1)
                        {
                            e.Graphics.FillEllipse(Brushes.Red, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 2)
                        {
                            e.Graphics.FillEllipse(Brushes.Blue, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 3)
                        {
                            e.Graphics.FillEllipse(Brushes.Orange, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 4)
                        {
                            e.Graphics.FillEllipse(Brushes.Purple, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 5)
                        {
                            e.Graphics.FillEllipse(Brushes.Brown, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 6)
                        {
                            e.Graphics.FillEllipse(Brushes.Black, new RectangleF(q.X, q.Y, s, s));
                        }
                        if (color == 7)
                        {
                            e.Graphics.FillEllipse(Brushes.Pink, new RectangleF(q.X, q.Y, s, s));
                        }

                    }
                }
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(stump);
                Matrix m = new Matrix();
                m.Scale(20, 20);
                path.Transform(m);
                e.Graphics.FillPath(Brushes.Brown, path);
            }


            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(star);
                Matrix n = new Matrix();
                n.Scale(20, 20);
                path.Transform(n);
                e.Graphics.FillPath(Brushes.Yellow, path);
            }
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(gifts1);
                Matrix b = new Matrix();
                b.Scale(20, 20);
                path.Transform(b);
                e.Graphics.FillPath(Brushes.Red, path);
            }
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(gifts2);
                Matrix v = new Matrix();
                v.Scale(20, 20);
                path.Transform(v);
                e.Graphics.FillPath(Brushes.Blue, path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
