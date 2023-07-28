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
            Shape.Location = new Point(740, 133);
            Shape.Margin = new Padding(3, 4, 3, 4);
            Shape.Name = "Shape";
            Shape.Size = new Size(472, 695);
            Shape.TabIndex = 2;
            // 
            // Circle
            // 
            Circle.Image = (Image)resources.GetObject("Circle.Image");
            Circle.Location = new Point(32, 413);
            Circle.Margin = new Padding(3, 4, 3, 4);
            Circle.Name = "Circle";
            Circle.Size = new Size(77, 84);
            Circle.SizeMode = PictureBoxSizeMode.StretchImage;
            Circle.TabIndex = 2;
            Circle.TabStop = false;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(205, 865);
            StartButton.Margin = new Padding(3, 4, 3, 4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(269, 64);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += Start_Click;
            StartButton.KeyDown += StartButton_KeyDown;
            // 
            // locationText
            // 
            locationText.AutoSize = true;
            locationText.Location = new Point(56, 43);
            locationText.Name = "locationText";
            locationText.Size = new Size(66, 20);
            locationText.TabIndex = 4;
            locationText.Text = "Location";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.Location = new Point(243, 43);
            Level.Name = "Level";
            Level.Size = new Size(58, 20);
            Level.TabIndex = 5;
            Level.Text = "Nivel: 1";
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(1212, 133);
            Result.Margin = new Padding(3, 4, 3, 4);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.Size = new Size(362, 695);
            Result.TabIndex = 6;
            Result.TextAlign = HorizontalAlignment.Center;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = Color.FromArgb(0, 0, 192);
            ResultText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ResultText.Location = new Point(872, 857);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(245, 67);
            ResultText.TabIndex = 11;
            ResultText.Text = "Resultado";
            // 
            // ImageButton
            // 
            ImageButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ImageButton.Location = new Point(1289, 855);
            ImageButton.Margin = new Padding(3, 4, 3, 4);
            ImageButton.Name = "ImageButton";
            ImageButton.Size = new Size(186, 69);
            ImageButton.TabIndex = 12;
            ImageButton.Text = "Imagenes";
            ImageButton.UseVisualStyleBackColor = true;
            ImageButton.Click += ImageButton_Click;
            // 
            // BallMove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1746, 954);
            Controls.Add(ImageButton);
            Controls.Add(ResultText);
            Controls.Add(Result);
            Controls.Add(Level);
            Controls.Add(locationText);
            Controls.Add(Shape);
            Controls.Add(StartButton);
            Controls.Add(Circle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BallMove";
            Text = "BallMove";
            WindowState = FormWindowState.Maximized;
            Load += BallMove_Load;
            KeyDown += BallMove_KeyDown;
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
    }
}