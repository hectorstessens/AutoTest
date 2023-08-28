namespace AutoTest
{
    partial class StarNight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarNight));
            Star = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            btnEmpezar = new Button();
            ResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Star).BeginInit();
            SuspendLayout();
            // 
            // Star
            // 
            Star.Image = (Image)resources.GetObject("Star.Image");
            Star.Location = new Point(329, 174);
            Star.Margin = new Padding(3, 2, 3, 2);
            Star.Name = "Star";
            Star.Size = new Size(21, 19);
            Star.SizeMode = PictureBoxSizeMode.StretchImage;
            Star.TabIndex = 0;
            Star.TabStop = false;
            Star.Visible = false;
            // 
            // timer
            // 
            timer.Interval = 1500;
            timer.Tick += timer_Tick;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpezar.Location = new Point(467, 493);
            btnEmpezar.Margin = new Padding(3, 2, 3, 2);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(244, 58);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.KeyDown += btnEmpezar_KeyDown;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLabel.ForeColor = Color.White;
            ResultLabel.Location = new Point(22, 7);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(88, 37);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "Result";
            // 
            // StarNight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1106, 562);
            Controls.Add(ResultLabel);
            Controls.Add(btnEmpezar);
            Controls.Add(Star);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StarNight";
            Text = "StarNight";
            WindowState = FormWindowState.Maximized;
            Load += StarNight_Load;
            KeyDown += StarNight_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Star).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Star;
        private System.Windows.Forms.Timer timer;
        private Button btnEmpezar;
        private Label ResultLabel;
    }
}