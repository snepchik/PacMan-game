using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        public static Panel GameField { get; set; }
        public static Label Score1 {  get; set; }
        public static Label Win1 { get; set; }

        private PacMan pacman;
       
        private PacMan_Game pacMan_Game;
        private Ghost_Red Ghost_Red;
        private Ghost_Red Ghost_Red2;
        int SecondsInGame = 0;
  
       

        public Form1()
        {
            InitializeComponent();
      
            GameField = panel1;
            Score1 = Score;
            Win1 = Win;
            this.pacman = new PacMan(new Point(1,1));
            Ghost_Red = new Ghost_Red(new Point(6, 6),8);
            Ghost_Red2 = new Ghost_Red(new Point(20, 20),8);
            pacMan_Game = new PacMan_Game(pacman, Ghost_Red, Ghost_Red2);
            Console.WriteLine($"GameField Children: {GameField.Controls.Count}");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pacMan_Game.Update();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
               pacman.KeyListener(e); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SecondsInGame++;
            Time.Text = "Время: " + SecondsInGame.ToString();
            if (SecondsInGame > 180 && SecondsInGame < 190)
            {
                Time.Text = "Great!";
            }
        }
    }
}

