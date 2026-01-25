using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public  abstract class Enemy
    {
        protected int timeToMove = 7;
        protected int tTMTemp = 7;
        protected int tTMWithBoost = 3;
        protected int stepsWithBoost = 0;
        public PictureBox ghost_red { get; private set; }
        protected int sizeOfCell = PacMan_Game.sizeOfCell;
        protected Random random = new Random();
        protected bool right = false;
        protected bool left = false;
        protected bool up = true;
        protected bool down = false;
        public Enemy(Point P, int tTMTemp = 7)
        {
            timeToMove = tTMTemp;
            ghost_red = new PictureBox()
            {
                Location = new Point(P.X * sizeOfCell, P.Y * sizeOfCell),
                Size = new Size(sizeOfCell, sizeOfCell),


            };
            try
            {
                ghost_red.Image = Image.FromFile("D:\\visual studio\\projects\\PacMan\\PacMan\\Images\\Ghost_Red.png");
            }
            catch
            {
                ghost_red.BackColor = Color.Red;
            }
            if (Form1.GameField == null)
            {
                throw new InvalidOperationException("GameField not initialized. Form must be created first.");
            }
            Form1.GameField.Controls.Add(ghost_red);
        }
        protected virtual void CathPackMan()
        {
            Point ghostLoc = new Point() { X = ghost_red.Location.X / sizeOfCell, Y = ghost_red.Location.Y / sizeOfCell };
            Point locationPacman = new Point(PacMan.pacman.Location.X / sizeOfCell, PacMan.pacman.Location.Y / sizeOfCell);
            if (ghostLoc.Equals(locationPacman))
            {
                Console.WriteLine("Конец!");
                PacMan_Game.gameOver = true;
            }
        }
      protected virtual bool SeekPacMan(Point ghostLoacation)
        {
            Point locationPacman = new Point(PacMan.pacman.Location.X / sizeOfCell, PacMan.pacman.Location.Y / sizeOfCell);
            Point locationGhost = new Point(ghostLoacation.X / sizeOfCell, ghostLoacation.Y / sizeOfCell);
            //проверка по оси Y вверх
            for (int i = locationGhost.Y - 1; i > 0; i--)
            {
                Point search = new Point { X = locationGhost.X, Y = i };
                if (search.Equals(locationPacman))
                {
                    up = true;
                    right = false;
                    left = false;
                    down = false;
                    return true;
                }
                else if (Borrder.CheckCollision(search))
                {
                    break;
                }
            }
            //проверка по оси Y вниз
            for (int i = locationGhost.Y + 1; i < Borrder.border.GetLength(0) - 1; i++)
            {
                Point search = new Point { X = locationGhost.X, Y = i };
                if (search.Equals(locationPacman))
                {
                    down = true;
                    right = false;
                    left = false;
                    up = false;
                    return true;
                }
                else if (Borrder.CheckCollision(search))
                {
                    break;
                }
            }
            //проверка по оси X вправо
            for (int i = locationGhost.X + 1; i < Borrder.border.GetLength(1) - 1; i++)
            {
                Point search = new Point { X = i, Y = locationGhost.Y };
                if (search.Equals(locationPacman))
                {
                    right = true;
                    down = false;
                    left = false;
                    up = false;
                    return true;
                }
                else if (Borrder.CheckCollision(search))
                {
                    break;
                }
            }
            // по оси X влево
            for (int i = locationGhost.X - 1; i > 0; i--)
            {
                Point search = new Point { X = i, Y = locationGhost.Y };
                if (search.Equals(locationPacman))
                {
                    left = true;
                    right = false;
                    up = false;
                    down = false;
                    return true;
                }
                else if (Borrder.CheckCollision(search))
                {
                    break;
                }
            }
            return false;

       }
    
        public abstract void  Move();
    }
}
