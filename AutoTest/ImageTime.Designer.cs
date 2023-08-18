namespace AutoTest
{
    partial class ImageTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageTime));
            StartAction = new Button();
            imgVoice = new PictureBox();
            imgRedCircle = new PictureBox();
            imgCross = new PictureBox();
            imgCircleGreen = new PictureBox();
            Result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ResultText = new Label();
            MoveBallButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgVoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgRedCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCross).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCircleGreen).BeginInit();
            SuspendLayout();
            // 
            // StartAction
            // 
            StartAction.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            StartAction.Location = new Point(245, 807);
            StartAction.Name = "StartAction";
            StartAction.Size = new Size(391, 85);
            StartAction.TabIndex = 0;
            StartAction.Text = "Empezar";
            StartAction.UseVisualStyleBackColor = true;
            StartAction.Click += StartAction_Click;
            StartAction.KeyDown += StartAction_KeyDown;
            // 
            // imgVoice
            // 
            imgVoice.Image = (Image)resources.GetObject("imgVoice.Image");
            imgVoice.Location = new Point(302, 275);
            imgVoice.Name = "imgVoice";
            imgVoice.Size = new Size(248, 239);
            imgVoice.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVoice.TabIndex = 1;
            imgVoice.TabStop = false;
            // 
            // imgRedCircle
            // 
            imgRedCircle.Image = (Image)resources.GetObject("imgRedCircle.Image");
            imgRedCircle.Location = new Point(302, 275);
            imgRedCircle.Name = "imgRedCircle";
            imgRedCircle.Size = new Size(248, 239);
            imgRedCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            imgRedCircle.TabIndex = 2;
            imgRedCircle.TabStop = false;
            // 
            // imgCross
            // 
            imgCross.Image = (Image)resources.GetObject("imgCross.Image");
            imgCross.Location = new Point(302, 275);
            imgCross.Name = "imgCross";
            imgCross.Size = new Size(248, 239);
            imgCross.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCross.TabIndex = 3;
            imgCross.TabStop = false;
            // 
            // imgCircleGreen
            // 
            imgCircleGreen.Image = (Image)resources.GetObject("imgCircleGreen.Image");
            imgCircleGreen.Location = new Point(302, 275);
            imgCircleGreen.Name = "imgCircleGreen";
            imgCircleGreen.Size = new Size(248, 239);
            imgCircleGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCircleGreen.TabIndex = 4;
            imgCircleGreen.TabStop = false;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(930, 1);
            Result.Margin = new Padding(3, 4, 3, 4);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.Size = new Size(621, 839);
            Result.TabIndex = 5;
            Result.TextAlign = HorizontalAlignment.Center;
            Result.KeyDown += Result_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(405, 46);
            label1.TabIndex = 6;
            label1.Text = "Q - Izquierda Circulo Rojo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(326, 46);
            label2.TabIndex = 7;
            label2.Text = "Z - Izquierda Vocina ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(510, 15);
            label3.Name = "label3";
            label3.Size = new Size(403, 46);
            label3.TabIndex = 8;
            label3.Text = "9 - Derecha Circulo Verde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(510, 93);
            label4.Name = "label4";
            label4.Size = new Size(270, 46);
            label4.TabIndex = 9;
            label4.Text = "3 - Derecha Cruz";
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = Color.FromArgb(0, 0, 192);
            ResultText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ResultText.Location = new Point(1043, 847);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(245, 67);
            ResultText.TabIndex = 10;
            ResultText.Text = "Resultado";
            // 
            // MoveBallButton
            // 
            MoveBallButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MoveBallButton.Location = new Point(1384, 845);
            MoveBallButton.Margin = new Padding(3, 4, 3, 4);
            MoveBallButton.Name = "MoveBallButton";
            MoveBallButton.Size = new Size(167, 69);
            MoveBallButton.TabIndex = 11;
            MoveBallButton.Text = "Pelotita";
            MoveBallButton.UseVisualStyleBackColor = true;
            MoveBallButton.Click += MoveBallButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(436, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 160);
            panel1.TabIndex = 12;
            // 
            // ImageTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 894);
            Controls.Add(panel1);
            Controls.Add(MoveBallButton);
            Controls.Add(ResultText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Result);
            Controls.Add(imgCircleGreen);
            Controls.Add(imgCross);
            Controls.Add(imgRedCircle);
            Controls.Add(imgVoice);
            Controls.Add(StartAction);
            Name = "ImageTime";
            Text = "Auto Test";
            WindowState = FormWindowState.Maximized;
            KeyDown += Main_KeyDown;
            Leave += ImageTime_Leave;
            ((System.ComponentModel.ISupportInitialize)imgVoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgRedCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCross).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCircleGreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartAction;
        private PictureBox imgVoice;
        private PictureBox imgRedCircle;
        private PictureBox imgCross;
        private PictureBox imgCircleGreen;
        private TextBox Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label ResultText;
        private Button MoveBallButton;
        private Panel panel1;
    }
}