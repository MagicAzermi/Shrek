
namespace Shrek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.gameField = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameStart = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("AuntJudyBetter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHREK SPEED";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Cornsilk;
            this.trackBar.Location = new System.Drawing.Point(267, 9);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(203, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 5;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // gameField
            // 
            this.gameField.BackColor = System.Drawing.Color.OliveDrab;
            this.gameField.Location = new System.Drawing.Point(11, 84);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(750, 525);
            this.gameField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("AuntJudyBetter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "your name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(485, 38);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(205, 23);
            this.nameField.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.scoreNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("AuntJudyBetter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(792, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 525);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(246, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("AuntJudyBetter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leaderboard";
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.BackColor = System.Drawing.Color.White;
            this.scoreNumber.Font = new System.Drawing.Font("AuntJudyBetter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreNumber.Location = new System.Drawing.Point(132, 0);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(35, 39);
            this.scoreNumber.TabIndex = 1;
            this.scoreNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("AuntJudyBetter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "SCORE:";
            // 
            // gameStart
            // 
            this.gameStart.BackColor = System.Drawing.Color.Cornsilk;
            this.gameStart.Font = new System.Drawing.Font("AuntJudyBetter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameStart.Location = new System.Drawing.Point(792, 9);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(493, 52);
            this.gameStart.TabIndex = 6;
            this.gameStart.Text = "Start and Never Stop!";
            this.gameStart.UseVisualStyleBackColor = false;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 250;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1296, 628);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameField);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shrek the Game";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel gameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scoreNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.Timer gameTimer;
    }
}

