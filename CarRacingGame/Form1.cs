using CarRacingGame.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Media;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pointsEarned = 0;
        int speedRoad = 5;
        int myCarSpeed = 5;

        bool leftDirection = false;
        bool rightDirection = false;

        int otherCarSpeed = 5;

        Random rnd = new Random();


        public void StartGame()
        {
            btnStartGame.Enabled = false;
            crash.Left = 165;
            crash.Top = 294;
            crash.Visible = false;

            myCarSpeed = 5;
            otherCarSpeed = 5;
            pointsEarned = 0;

            // The coordinate of the car - My car
            myCar.Left = 160;
            myCar.Top = 300;

            // The coordinate of the car - Other car
            car1.Left = 30;
            car1.Top = 50;

            car2.Left = 320;
            car2.Top = 50;

            // Direction
            leftDirection = false;
            rightDirection = false;

            // Timer
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
            EnableSound();
        }


        private void EnableSound()
        {
            SoundPlayer sound = new SoundPlayer();
            string soundPath = Application.StartupPath + "\\music.wav";
            sound.SoundLocation = soundPath;
            sound.Play();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Points
            pointsEarned++;
            lblScore.Text = pointsEarned.ToString();

            // Road
            road.Top += speedRoad;

            if (road.Top > 400)
            {
                road.Top = -100;
            }

            // Direction
            if (leftDirection) { myCar.Left -= myCarSpeed; }
            if (rightDirection) { myCar.Left += myCarSpeed; }

            // Control
            if (myCar.Left <= 1) { leftDirection = false; }
            if (myCar.Left + myCar.Width > panel1.Width) { rightDirection = false; }

            // Other car
            car1.Top += otherCarSpeed;
            car2.Top += otherCarSpeed;

            // Positions cars
            if (car1.Top > panel1.Height) 
            {
                ChangeCar1();
                car1.Left = rnd.Next(20, 50);
                car1.Top = rnd.Next(40, 140) * -1;
            }
            if(car2.Top > panel1.Height) 
            {

                ChangeCar2();
                car2.Left = rnd.Next(150, 350);
                car2.Top = rnd.Next(40, 140) * -1;
            }

            if(myCar.Bounds.IntersectsWith(car1.Bounds) || myCar.Bounds.IntersectsWith(car2.Bounds))
            {
                GameOver();
            }
            //while(car1.Top > 65)
        }

        private void ChangeCar1()
        {
            int ordinal = rnd.Next(1, 7);

            switch (ordinal)
            {
                case 1: car1.Image = Resources.araba1; break;
                case 2: car1.Image = Resources.araba1; break;
                case 3: car1.Image = Resources.araba2; break;
                case 4: car1.Image = Resources.araba3; break;
                case 5: car1.Image = Resources.araba4; break;
                case 6: car1.Image = Resources.araba5; break;
                case 7: car1.Image = Resources.araba6; break;
            }
        }


        private void ChangeCar2()
        {
            int ordinal = rnd.Next(1, 6);

            switch (ordinal)
            {
                case 1: car2.Image = Resources.araba1; break;
                case 2: car2.Image = Resources.araba2; break;
                case 3: car2.Image = Resources.araba3; break;
                case 4: car2.Image = Resources.araba4; break;
                case 5: car2.Image = Resources.araba5; break;
                case 6: car2.Image = Resources.araba6; break;
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            Settings1.Default.highScore = Convert.ToInt32(lblScore.Text);

            if(Convert.ToInt32(lblScore.Text) >= Settings1.Default.highScore)
            {
                lbl_highScore.Text = Settings1.Default.highScore.ToString();
            }

            btnStartGame.Enabled = true;
            crash.Visible = true;
            myCar.Controls.Add(crash);
            crash.Location = new Point(7, -5);
            crash.BringToFront();
            crash.BackColor = Color.Transparent;
            MessageBox.Show("Game Over. Points earned: " + lblScore.Text, "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && myCar.Left > 0) { leftDirection = true; }
            if(e.KeyCode == Keys.Right && myCar.Left + myCar.Width < panel1.Width) { rightDirection = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) { leftDirection = false; }
            if (e.KeyCode == Keys.Right) { rightDirection = false; }
        }
    }
}