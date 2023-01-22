namespace CarRacingGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crash = new System.Windows.Forms.PictureBox();
            this.myCar = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.crash);
            this.panel1.Controls.Add(this.myCar);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.road);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // crash
            // 
            this.crash.Image = global::CarRacingGame.Properties.Resources.explosion;
            this.crash.Location = new System.Drawing.Point(287, 329);
            this.crash.Name = "crash";
            this.crash.Size = new System.Drawing.Size(48, 41);
            this.crash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crash.TabIndex = 2;
            this.crash.TabStop = false;
            // 
            // myCar
            // 
            this.myCar.Image = global::CarRacingGame.Properties.Resources.araba8;
            this.myCar.Location = new System.Drawing.Point(227, 359);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(69, 134);
            this.myCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCar.TabIndex = 1;
            this.myCar.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::CarRacingGame.Properties.Resources.araba9;
            this.car2.Location = new System.Drawing.Point(338, 56);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(69, 134);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::CarRacingGame.Properties.Resources.araba5;
            this.car1.Location = new System.Drawing.Point(73, 56);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(69, 134);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // road
            // 
            this.road.Image = global::CarRacingGame.Properties.Resources.yol;
            this.road.Location = new System.Drawing.Point(-1, -252);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(513, 775);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(12, 593);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(507, 56);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(302, 541);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(31, 33);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 668);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox road;
        private PictureBox myCar;
        private PictureBox car2;
        private PictureBox car1;
        private Button btnStartGame;
        private Label label1;
        private Label lblScore;
        private PictureBox crash;
        private System.Windows.Forms.Timer timer1;
    }
}