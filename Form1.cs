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
            Random random = new Random();
            int Xrnd = random.Next(38) * 15;
            int Yrnd = random.Next(30) * 15;
            bool isSnake = true;

            while (isSnake) {
                for (int i = 0; i < snakeSize; i++) {
                    if (snakeParts[i].Location == new Point(Xrnd, Yrnd))
                    {
                        Xrnd = random.Next(38) * 15;
                        Yrnd = random.Next(30) * 15;
                    }
                    else {
                        isSnake = false;
                    }
                }
            }

            if (isSnake == false) {
                foodLocation = new Point(Xrnd, Yrnd);
                food.Size = new Size(15, 15);
                food.BackColor = Color.Red;
                food.BorderStyle = BorderStyle.FixedSingle;
                gameField.Controls.Add(food);
            }
        }

        private void drawSnake()
        {
            snakeParts = new PictureBox[snakeSize];

            for (int i = 0; i < snakeSize; i++) {
                snakeParts[i] = new PictureBox();
                snakeParts[i].Size = new Size(15, 15);
                snakeParts[i].BackColor = Color.Green;
                snakeParts[i].BorderStyle = BorderStyle.FixedSingle;
                snakeParts[i].Location = new Point(location.X - (15 * i), location.Y);
                gameField.Controls.Add(snakeParts[i]);
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000 - (10 * trackBar.Value);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        private void Move()
        {
            Point point = new Point(0, 0);

            for (int i = 0; i < snakeSize; i++) {
                if (i == 0)
                {
                    point = snakeParts[i].Location;
                    if (direction == "Left")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X - 15, snakeParts[i].Location.Y);
                    }
                    if (direction == "Right")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X + 15, snakeParts[i].Location.Y);
                    }
                    if (direction == "Top")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X, snakeParts[i].Location.Y - 15);
                    }
                    if (direction == "Down")
                    {
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X - 15, snakeParts[i].Location.Y + 15);
                    }
                }
                else {
                    Point newPoint = snakeParts[i].Location;
                    snakeParts[i].Location = point;
                    point = newPoint;
                }
            }
        }
    }
}
