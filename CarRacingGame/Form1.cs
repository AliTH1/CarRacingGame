using System.Diagnostics.Eventing.Reader;

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
            crash.Visible = false;

            myCarSpeed = 5;
            otherCarSpeed = 5;
            pointsEarned = 0;

            // The coordinate of the car - My Car
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
            if (myCar.Left + myCar.Width > 510) { rightDirection = false; }

            // Other car
            car1.Top += otherCarSpeed;
            car2.Top += otherCarSpeed;

            // TODO - Random position cars
            if (car1.Top < 650) { car1.Top = 50; }
            if(car2.Top < 650) { car2.Top = 50; }
        }
    }
}