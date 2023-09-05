namespace FlappyBird
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
            components = new System.ComponentModel.Container();
            Bird = new PictureBox();
            pipe_top = new PictureBox();
            pipe_down = new PictureBox();
            ground = new PictureBox();
            scoretext = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            enemy1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            SuspendLayout();
            // 
            // Bird
            // 
            Bird.Image = Properties.Resources.Bird1;
            Bird.Location = new Point(115, 317);
            Bird.Name = "Bird";
            Bird.Size = new Size(142, 125);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 0;
            Bird.TabStop = false;
            // 
            // pipe_top
            // 
            pipe_top.Image = Properties.Resources.pipe_down;
            pipe_top.Location = new Point(912, -34);
            pipe_top.Name = "pipe_top";
            pipe_top.Size = new Size(156, 408);
            pipe_top.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_top.TabIndex = 1;
            pipe_top.TabStop = false;
            // 
            // pipe_down
            // 
            pipe_down.Image = Properties.Resources.pipe_up;
            pipe_down.Location = new Point(546, 629);
            pipe_down.Name = "pipe_down";
            pipe_down.Size = new Size(184, 1139);
            pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_down.TabIndex = 2;
            pipe_down.TabStop = false;
            // 
            // ground
            // 
            ground.BackColor = Color.FromArgb(128, 255, 255);
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-109, 1031);
            ground.Name = "ground";
            ground.Size = new Size(1519, 248);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.BackColor = Color.WhiteSmoke;
            scoretext.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            scoretext.Location = new Point(26, 34);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(365, 109);
            scoretext.TabIndex = 4;
            scoretext.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = Properties.Resources.Bird1;
            enemy1.Location = new Point(931, 110);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(115, 97);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 5;
            enemy1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(1292, 1222);
            Controls.Add(enemy1);
            Controls.Add(scoretext);
            Controls.Add(ground);
            Controls.Add(pipe_down);
            Controls.Add(pipe_top);
            Controls.Add(Bird);
            Name = "Form1";
            Text = "FlappyBird";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_top).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bird;
        private PictureBox pipe_top;
        private PictureBox pipe_down;
        private PictureBox ground;
        private Label scoretext;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox enemy1;
    }
}