namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            enemy1.BackColor = Color.Transparent;
            Bird.Top += gravity;
            pipe_down.Left -= pipeSpeed;
            pipe_top.Left -= pipeSpeed;
            enemy1.Left -= pipeSpeed + 5;

            scoretext.Text = "Score: " + score.ToString();

            if (pipe_down.Left < -150)
            {
                pipe_down.Left = 1500;
                pipe_down.Location = new Point(pipe_down.Left, new Random().Next(100, 1001));
                score++;
            }
            if (pipe_top.Left < -180)
            {
                pipe_top.Left = 1500;
                score++;
            }
            if (enemy1.Left < -150)
            {
                enemy1.Left = 1500;
            }

            if (Bird.Bounds.IntersectsWith(pipe_down.Bounds) ||
                Bird.Bounds.IntersectsWith(pipe_top.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) ||
                Bird.Bounds.IntersectsWith(enemy1.Bounds))
            {
                endgame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endgame()
        {
            gameTimer.Stop();
            scoretext.Text += "Game Over!!!";

        }
    }
}