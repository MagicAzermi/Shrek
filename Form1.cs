using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrek
{
    public partial class Form1 : Form
    {
        //snake cfg
        PictureBox[] snakeParts;
        int snakeSize = 5;
        Point location = new Point(120, 120);
        string direction = "Right";
        bool changingDirection = false;

        //food cfg
        PictureBox food = new PictureBox();
        Point foodLocation = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            //starting new game
            gameField.Controls.Clear();
            snakeParts = null;
            scoreNumber.Text = "0";
            snakeSize = 5;
            direction = "Right";
            location = new Point(120, 120);

            drawSnake();
            drawFood();
            gameTimer.Start();

            trackBar.Enabled = false;
            gameStart.Enabled = false;
            nameField.Enabled = false;
        }

        private void drawFood()
        {
            
        }

        private void drawSnake()
        {
            snakeParts = new PictureBox[snakeSize];
        }
    }
}
