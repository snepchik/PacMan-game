using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PacMan
{
    static  class Borrder
    {
       public static PictureBox[,] border = new PictureBox[25, 25];
        static private int SizeOfBorder = PacMan_Game.sizeOfCell;
        static private int SizeOfFood = SizeOfBorder / 3;
        static Borrder()
        {
      
        }
        public static void FillBorder()
        {
          
            if (Form1.GameField == null)
            {
                throw new InvalidOperationException("GameField not initialized. Form must be created first.");
            }
            int x = 0;
            int y = 0;
            for (x = 0; x < border.GetLength(1); x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord
                    
                };
              
           
                 Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 0;
            y = 0;
            for (y = 0; y < border.GetLength(1); y++)
            {


                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord
                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
             x = border.GetLength(0) - 1; y = 0;
            for (y = 0; y < border.GetLength(1); y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord
                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 0; y = border.GetLength(0) - 1;
            for (x = 0; x < border.GetLength(1); x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor= Color.Blue,
                    Tag = cell.Bord
                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 2;y = 2;

            for(; x < 8; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord
                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 14; y = 2;
            for (; y < 13; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord
                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 1; y = border.GetLength(0) - 2;
            border[y,x] = new PictureBox
            {
                Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                Size = new Size(SizeOfBorder, SizeOfBorder),
                BackColor = Color.Blue,
                Tag = cell.Bord
            };
            Form1.GameField.Controls.Add(border[y, x]);
            x = 3; y = border.GetLength(0) - 3;
            for (; x < 13; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 7; y = 4;
            for (; y < 13; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 9; y = 4;
            for (; y < 13; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 3; y = 16;
            for (; x < 23; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 3; y = 12;
            for (; x < 23; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 3; y = 19;
            for (; x < 11; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 13; y = 19;
            for (; x < 20; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 22; y = 19;
            for (; y < 23; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 15; y = 21;
            for (; y < 23; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 3; y = 16;
            for (; y < 19; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 3; y = 16;
            for (; y < 19; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 16; y = 1;
            for (; y < 9; y++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 18; y = 2;
            for (; x < 23; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 18; y = 5;
            for (; x < 23; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            x = 18; y = 8;
            for (; x < 23; x++)
            {
                border[y, x] = new PictureBox
                {
                    Location = new Point(x * SizeOfBorder, y * SizeOfBorder),
                    Size = new Size(SizeOfBorder, SizeOfBorder),
                    BackColor = Color.Blue,
                    Tag = cell.Bord

                };
                Form1.GameField.Controls.Add(border[y, x]);
            }
            FillFood();

        }
        static void FillFood()
        {
            int x = 5; int y = 1;

            // Проверьте, что в этих ячейках


            // Если Tag = Bord, значит здесь уже есть стена!
            // И вы ее перезаписываете едой

            for (; x < 10; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }

            x = 1; y = 1;

            for (; x < 3; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 10; y = 10;
            for (; x < 14; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 17; y = 1;
            for (; x < 24; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 8; y = 8;
            for (; y < 12; y++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 15; y = 1;
            for (; y < 12; y++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 3; y = 17;
            for (; x < 10; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 3; y = 18;
            for (; x < 10; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 23; y = 18;
            for (; y < 24; y++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 23; y = 18;
            for (; y < 24; y++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 1; y = 4;
            for (; y < 22; y++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }

            }
            x = 4; y = 23;
            for (; x < 22; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 4; y = 13;
            for (; x < 24; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
            x = 4; y = 11;
            for (; x < 8; x++)
            {
                if (CanPlaceFoodAt(x, y))
                {
                    border[y, x] = new PictureBox
                    {
                        Location = new Point(x * SizeOfBorder + SizeOfBorder / 2, y * SizeOfBorder + SizeOfBorder / 2),
                        Size = new Size(SizeOfFood, SizeOfFood),
                        BackColor = Color.White,
                        Tag = cell.Food
                    };
                    border[y, x].BringToFront();
                    Form1.GameField.Controls.Add(border[y, x]);
                }
            }
        }

        static bool CanPlaceFoodAt(int x, int y)
        {
            // 1. Проверяем границы
            if (x < 0 || x >= border.GetLength(1) || y < 0 || y >= border.GetLength(0))
                return false;

            // 2. Если клетка уже занята (стена или другая еда)
            if (border[y, x] != null)
            {
                // Можно перезаписать только если это не стена
                if (border[y, x].Tag != null && (cell)border[y, x].Tag == cell.Bord)
                    return false; // Здесь стена - нельзя разместить еду

                // Если здесь уже есть еда или что-то другое, удаляем старый PictureBox
                Form1.GameField.Controls.Remove(border[y, x]);
                border[y, x].Dispose();
            }

            return true;
        }
        public static bool CheckCollision(Point p)
        {
            int xIndex = p.X;
            int yIndex = p.Y;
            if (xIndex < 0 || xIndex >= border.GetLength(1) ||
        yIndex < 0 || yIndex >= border.GetLength(0))
            {
                return true; 
            }
            if (border[yIndex, xIndex] != null &&
         border[yIndex, xIndex].Tag != null &&
         (cell)border[yIndex, xIndex].Tag == cell.Bord)
            {
                return true;
            }

            return false;
        }
    }
}

