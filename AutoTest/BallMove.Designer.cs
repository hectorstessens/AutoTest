namespace AutoTest
{
    partial class BallMove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BallMove));
            Timer = new System.Windows.Forms.Timer(components);
            Shape = new Panel();
            Circle = new PictureBox();
            StartButton = new Button();
            locationText = new Label();
            Level = new Label();
            Result = new TextBox();
            ResultText = new Label();
            ImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Circle).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 10;
            Timer.Tick += Timer_Tick;
            // 
            // Shape
            // 
            Shape.BackColor = Color.Yellow;
            Shape.Location = new Point(648, 100);
            Shape.Name = "Shape";
            Shape.Size = new Size(413, 521);
            Shape.TabIndex = 2;
            // 
            // Circle
            // 
            Circle.Image = (Image)resources.GetObject("Circle.Image");
            Circle.Location = new Point(28, 310);
            Circle.Name = "Circle";
            Circle.Size = new Size(67, 63);
            Circle.SizeMode = PictureBoxSizeMode.StretchImage;
            Circle.TabIndex = 2;
            Circle.TabStop = false;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(186, 624);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(235, 57);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += Start_Click;
            StartButton.KeyDown += StartButton_KeyDown;
            // 
            // locationText
            // 
            locationText.AutoSize = true;
            locationText.Location = new Point(28, 9);
            locationText.Name = "locationText";
            locationText.Size = new Size(53, 15);
            locationText.TabIndex = 4;
            locationText.Text = "Location";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.Location = new Point(225, 9);
            Level.Name = "Level";
            Level.Size = new Size(46, 15);
            Level.TabIndex = 5;
            Level.Text = "Nivel: 1";
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(1061, 100);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.Size = new Size(317, 522);
            Result.TabIndex = 6;
            Result.TextAlign = HorizontalAlignment.Center;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = Color.FromArgb(0, 0, 192);
            ResultText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ResultText.Location = new Point(762, 624);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(198, 54);
            ResultText.TabIndex = 11;
            ResultText.Text = "Resultado";
            // 
            // ImageButton
            // 
            ImageButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ImageButton.Location = new Point(1127, 630);
            ImageButton.Name = "ImageButton";
            ImageButton.Size = new Size(163, 52);
            ImageButton.TabIndex = 12;
            ImageButton.Text = "Imagenes";
            ImageButton.UseVisualStyleBackColor = true;
            ImageButton.Click += ImageButton_Click;
            // 
            // BallMove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 749);
            Controls.Add(ImageButton);
            Controls.Add(ResultText);
            Controls.Add(Result);
            Controls.Add(Level);
            Controls.Add(locationText);
            Controls.Add(Shape);
            Controls.Add(StartButton);
            Controls.Add(Circle);
            Name = "BallMove";
            Text = "BallMove";
            WindowState = FormWindowState.Maximized;
            FormClosed += BallMove_FormClosed;
            Load += BallMove_Load;
            KeyDown += BallMove_KeyDown;
            Leave += BallMove_Leave;
            ((System.ComponentModel.ISupportInitialize)Circle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Panel Shape;
        private PictureBox Circle;
        private Button StartButton;
        private Label locationText;
        private Label Level;
        private TextBox Result;
        private Label ResultText;
        private Button ImageButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}