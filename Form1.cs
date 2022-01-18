using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrek
{
    public partial class Form1 : Form
    {
        //snake cfg
        PictureBox[] snakeParts;
        int snakeSize;
        Point location;
        string direction;
        bool changingDirection;


        //food cfg
        PictureBox food = new PictureBox();
        Point foodLocation;

        static String path = Path.GetFullPath("C:/Users/Суслан/Documents/GitHub/LazyProject/Shrek");
        static String dbName = "data.mdf";
        string connectionString = @"Data Source=(Localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + dbName + "; Integrated Security=True;";

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
            int Xrnd = random.Next(50) * 15;
            int Yrnd = random.Next(35) * 15;
            bool isSnake = true;

            while (isSnake) {
                for (int i = 0; i < snakeSize; i++) {
                    if (snakeParts[i].Location == new Point(Xrnd, Yrnd))
                    {
                        Xrnd = random.Next(50) * 15;
                        Yrnd = random.Next(35) * 15;
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
                food.Location = foodLocation;
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
            gameTimer.Interval = 150 - (10 * trackBar.Value);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }

#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private void Move()
#pragma warning restore CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
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
                        snakeParts[i].Location = new Point(snakeParts[i].Location.X, snakeParts[i].Location.Y + 15);
                    }
                }
                else {
                    Point newPoint = snakeParts[i].Location;
                    snakeParts[i].Location = point;
                    point = newPoint;
                }
            }

            if (snakeParts[0].Location == foodLocation) {
                eatFood();
                drawFood();
            }

            if (snakeParts[0].Location.X < 0 || snakeParts[0].Location.X >= 750 || snakeParts[0].Location.Y < 0 || snakeParts[0].Location.Y >= 525) {
                stopGame();
            }

            for (int i = 3; i < snakeSize; i++) {
                if (snakeParts[0].Location == snakeParts[i].Location) {
                    stopGame();
                }
            }

                changingDirection = false;
        }

        private void eatFood()
        {
            snakeSize++;

            PictureBox[] pastSnake = snakeParts;
            gameField.Controls.Clear();
            snakeParts = new PictureBox[snakeSize];

            for (int i = 0; i < snakeSize; i++) {
                snakeParts[i] = new PictureBox();
                snakeParts[i].Size = new Size(15, 15);
                snakeParts[i].BackColor = Color.Green;
                snakeParts[i].BorderStyle = BorderStyle.FixedSingle;

                if (i == 0)
                {
                    snakeParts[i].Location = foodLocation;
                }

                else {
                    snakeParts[i].Location = pastSnake[i - 1].Location;
                }
                gameField.Controls.Add(snakeParts[i]);
            }

            int currentGameScore = Int32.Parse(scoreNumber.Text);
            int newGameScore = currentGameScore + 1;
            scoreNumber.Text = newGameScore + "";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) { 
            if (keyData ==(Keys.Up) && direction != "Down" && changingDirection != true){
                direction = "Top";
                changingDirection = true;
            }

            if (keyData == (Keys.Down) && direction != "Top" && changingDirection != true)
            {
                direction = "Down";
                changingDirection = true;
            }

            if (keyData == (Keys.Right) && direction != "Left" && changingDirection != true)
            {
                direction = "Right";
                changingDirection = true;
            }

            if (keyData == (Keys.Left) && direction != "Right" && changingDirection != true)
            {
                direction = "Left";
                changingDirection = true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void stopGame() 
        {
            gameTimer.Stop();
            gameStart.Enabled = true;
            trackBar.Enabled = true;
            nameField.Enabled = true;

            Label over = new Label();
            over.Text = "Ты\nПроиграл";
            over.ForeColor = Color.Green;
            over.Font = new Font("Arial", 100, FontStyle.Bold);
            over.Size = over.PreferredSize;
            over.TextAlign = ContentAlignment.MiddleCenter;
            over.BringToFront();

            int X = gameField.Width / 2 - over.Width / 2;
            int Y = gameField.Height / 2 - over.Height / 2;
            over.Location = new Point(X, Y);

            gameField.Controls.Add(over);
            over.BringToFront();

            AddScoretoDB();
            UpdateBoard();
        }

        private void AddScoretoDB()
        {
            throw new NotImplementedException();
        }

        private void UpdateBoard()
        {
            string query = "SELECT Id,Date,PlayerName,CurrentScore FROM scoreBoard";

            using(SqlConnection connection = new SqlConnection(connectionString)) {

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                var ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);
            }
        }
    }
}
