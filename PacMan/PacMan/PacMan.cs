using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PacMan
{
    public  class PacMan
    {
        public int timeToMove { get; private set; } = 8;
        int tTMTemp = 0;
        int sizeOfCell = PacMan_Game.sizeOfCell;
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;
        public int Score { get; private set; }= 0;
        static PictureBox[,] border = Borrder.border;


       public static PictureBox pacman { get; private set; }

        
        public PacMan(Point p, int tTMTemp = 8)
        {
            timeToMove = tTMTemp;
            pacman = new PictureBox()
            {
                Location =new Point( p.X * sizeOfCell ,p.Y * sizeOfCell ),
                Size = new Size(sizeOfCell, sizeOfCell),
                

            };
            try
            {
                pacman.Image = Image.FromFile("D:\\visual studio\\projects\\PacMan\\PacMan\\Images\\PacMan.png");
            }
            catch {
                pacman.BackColor = Color.Yellow;
            }
            if (Form1.GameField == null)
            {
                throw new InvalidOperationException("GameField not initialized. Form must be created first.");
            }
            Form1.GameField.Controls.Add(pacman);

        }
        public void Move()
        {

            if (tTMTemp <= 0)
            {
                if (right)
                {
                    Point p = new Point() { X = pacman.Location.X + sizeOfCell, Y = pacman.Location.Y };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell}))
                    {
                        return;
                    }
                    else
                    {
                        pacman.Location = p;
                    }
                }
                else if (left)
                {
                    Point p = new Point() { X = pacman.Location.X - sizeOfCell, Y = pacman.Location.Y };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                        return;
                    }
                    else
                    {
                        pacman.Location = p;
                    }
                }
                else if (up)
                {
                    Point p = new Point() { X = pacman.Location.X, Y = pacman.Location.Y - sizeOfCell };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                        return;
                    }
                    else
                    {
                        pacman.Location = p;
                    }
                }
                else if (down)
                {
                    Point p = new Point() { X = pacman.Location.X, Y = pacman.Location.Y + sizeOfCell };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                        return;
                    }
                    else
                    {
                        pacman.Location = p;
                    }
                }
                tTMTemp = timeToMove;
                EatFood(new Point() { X = pacman.Location.X, Y = pacman.Location.Y });
               
               
            }
            else { tTMTemp--; }
            CathPackMan();
        }
  
        public  bool EatFood(Point p)
        {
            int x = p.X / sizeOfCell; 
            int y = p.Y / sizeOfCell;
            if (x < 0 || x >= Borrder.border.GetLength(1) || y < 0 || y >= Borrder.border.GetLength(0))
            {
                return false;
            }
            if (border[y, x] != null &&
          border[y, x].Tag != null &&
          (cell)border[y, x].Tag == cell.Food)
            {
                if (Form1.GameField != null && border[y, x] != null)
                {
                    Form1.GameField.Controls.Remove(border[y, x]);
                }
                border[y, x]?.Dispose();
                border[y,x] = null;
                
                Score = Score + 100;
                return true;
            }
            return false;
        }
        void CathPackMan()
        {
          
        }

        public void KeyListener(KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.D:
                    {
                        right = true;
                        left = false;
                        up = false;
                        down = false;
                        break;
                    }
                case Keys.A:
                    {
                        left = true;
                        right = false;
                        up = false;
                        down = false;
                        break;
                    }
                case Keys.W:
                    {
                        up = true;
                        left = false;
                        right = false;
                        down = false;
                        break;
                    }
                case Keys.S:
                    {
                        down = true;
                        left = false;
                        right = false;
                        up = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}

