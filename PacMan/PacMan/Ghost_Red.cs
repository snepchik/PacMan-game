using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{   
    public class Ghost_Red
    {
        int timeToMove = 7;
        int tTMTemp = 7;
        int tTMWithBoost = 3;
        int stepsWithBoost = 0;
        public PictureBox ghost_red { get; private set; }
        int sizeOfCell = PacMan_Game.sizeOfCell;
        Random random = new Random();
        bool right = false;
        bool left = false;
        bool up = true;
        bool down = false;

        public Ghost_Red(Point P, int tTMTemp = 7)
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
        public void Move()
        {
            if (tTMTemp <= 0)
            {
                SeekPacMan(ghost_red.Location);
                if (right)
                {
                    Point p = new Point() { X = ghost_red.Location.X + sizeOfCell, Y = ghost_red.Location.Y };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                        
                        
                            WhereNext();
                        
                       
                        stepsWithBoost = 4;
                    }
                    else
                    {
                     
                            ghost_red.Location = p;
                        
                       
                        
                            
                        
                    }
                }
                else if (left)
                {
                    Point p = new Point() { X = ghost_red.Location.X - sizeOfCell, Y = ghost_red.Location.Y };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                  
                            WhereNext();
                        

                        stepsWithBoost = 4;
                    }
                    else
                    {
                      
                            ghost_red.Location = p;
                        
                    }
                }
                else if (up)
                {
                    Point p = new Point() { X = ghost_red.Location.X, Y = ghost_red.Location.Y - sizeOfCell };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                       
                            WhereNext();
                        

                        stepsWithBoost = 4;
                    }
                    else
                    {
                       
                            ghost_red.Location = p;
                        
                    }
                }
                else if (down)
                {
                    Point p = new Point() { X = ghost_red.Location.X, Y = ghost_red.Location.Y + sizeOfCell };
                    if (Borrder.CheckCollision(new Point { X = p.X / sizeOfCell, Y = p.Y / sizeOfCell }))
                    {
                        
                            WhereNext();
                        

                        stepsWithBoost = 4;
                    }
                    else
                    {
                        
                            ghost_red.Location = p;
                        
                    }

                }
                if(stepsWithBoost >= 0)
                {

                    stepsWithBoost--;
                    tTMTemp = tTMWithBoost;
                }
                else tTMTemp = timeToMove;
                CathPackMan();
            }
            else { tTMTemp--; }
            
            void WhereNext()
            {

                int rand = random.Next(0, 101);
                switch (rand)
                {
                    case int i when i <= 25 && right != true:
                        {
                            right = true;
                            left = false;
                            up = false;
                            down = false;
                            break;
                        }
                    case int i when i <= 50 && i > 25 && left != true:
                        {
                            left = true;
                            up = false;
                            down = false;
                            right = false;
                            break;
                        }
                    case int i when i <= 75 && i > 50 && up != true:
                        {
                            up = true;
                            left = false;
                            down = false;
                            right = false;

                            break;
                        }
                    case int i when i <= 100 && i > 75 && down != true:
                        {
                            down = true;
                            left = false;
                            right = false;
                            up = false;
                            break;
                        }
                    default:
                        {
                            WhereNext();
                            break;
                        }
                }
            }

        }
        void CathPackMan()
        {
            Point ghostLoc = new Point() { X = ghost_red.Location.X / sizeOfCell, Y = ghost_red.Location.Y / sizeOfCell };
            Point locationPacman = new Point(PacMan.pacman.Location.X / sizeOfCell, PacMan.pacman.Location.Y / sizeOfCell);
            if (ghostLoc.Equals(locationPacman)){
                Console.WriteLine("Конец!");
                PacMan_Game.gameOver = true;
            }
        }
        bool SeekPacMan(Point ghostLoacation)
        {
            Point locationPacman = new Point(PacMan.pacman.Location.X / sizeOfCell, PacMan.pacman.Location.Y / sizeOfCell);
            Point locationGhost = new Point(ghostLoacation.X / sizeOfCell, ghostLoacation.Y / sizeOfCell);
            //проверка по оси Y вверх
            for(int i = locationGhost.Y-1;i > 0;i--)
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
            for (int i = locationGhost.Y +1; i < Borrder.border.GetLength(0) - 1; i++)
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
            for (int i = locationGhost.X -1 ; i > 0; i--)
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
    }
}
