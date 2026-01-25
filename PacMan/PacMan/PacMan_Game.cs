using System.Drawing;
using System.Windows.Forms;

namespace PacMan
{
    public class PacMan_Game
    {
        public PacMan pacman {  get; }
        private Ghost_Red _ghost_Red2;
        private Ghost_Red _ghost_Red;
        static public bool gameOver = false;
        public static int sizeOfCell { get; } = 16;
        public int maxWidth { get; } = Form1.GameField.Width;
        public int maxHeight { get; } = Form1.GameField.Height;
        public PacMan_Game(PacMan pacman, Ghost_Red ghost_red, Ghost_Red ghost_Red2)
        {
            Borrder.FillBorder();
            this.pacman = pacman;
            this._ghost_Red = ghost_red;
            _ghost_Red2 = ghost_Red2;
        }
        public void Update()
        {

            Timer gameTimer = new Timer();
            gameTimer.Interval = 37; 
            gameTimer.Tick += (s, e) =>
            {
                pacman.Move();
                Form1.Score1.Text = "Счёт: " + pacman.Score.ToString();
                _ghost_Red.Move();
                _ghost_Red2?.Move();
                if (gameOver)
                {
                  gameTimer.Stop();
                    Form1.Win1.Visible = true;
                    Form1.Win1.ForeColor = Color.Red;
                    if (pacman.Score > 800)
                    {
                        Form1.Win1.Font = new Font("Arial", 9);
                        Form1.Win1.Text = "Проигрыш.Неплохой счёт!";
                        Form1.Win1.Visible = true;
                    }
                    else
                    {
                        Form1.Win1.Visible = true;
                        Form1.Win1.Font = new Font("Arial", 9);
                        Form1.Win1.Text = "Проигрыш.Ты вообще играл?";
                    }
                    }
                if(pacman.Score >= 11000)
                {
                    gameTimer.Stop();
                    Form1.Win1.Visible = true;
                }
            };
            gameTimer.Start();
        }
    }
}

