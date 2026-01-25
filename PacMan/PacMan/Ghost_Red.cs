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
    public class Ghost_Red : Enemy
    {

        public Ghost_Red(Point P, int tTMTemp = 7) : base(P, tTMTemp) { }

        public override void Move()
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
                if (stepsWithBoost >= 0)
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
        protected override bool SeekPacMan(Point ghostLoacation)
        {
            return base.SeekPacMan(ghostLoacation);
        }
        protected override void CathPackMan()
        {
            base.CathPackMan();
        }
    }
}
