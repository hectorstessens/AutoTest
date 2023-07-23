namespace AutoTest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            StartAction = new Button();
            StarImg1 = new PictureBox();
            CircleImg2 = new PictureBox();
            TriangleImg3 = new PictureBox();
            SquareImg4 = new PictureBox();
            Result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ResultText = new Label();
            ((System.ComponentModel.ISupportInitialize)StarImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CircleImg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TriangleImg3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SquareImg4).BeginInit();
            SuspendLayout();
            // 
            // StartAction
            // 
            StartAction.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            StartAction.Location = new Point(318, 623);
            StartAction.Margin = new Padding(3, 2, 3, 2);
            StartAction.Name = "StartAction";
            StartAction.Size = new Size(342, 64);
            StartAction.TabIndex = 0;
            StartAction.Text = "Empezar";
            StartAction.UseVisualStyleBackColor = true;
            StartAction.Click += StartAction_Click;
            StartAction.KeyDown += StartAction_KeyDown;
            // 
            // StarImg1
            // 
            StarImg1.Image = (Image)resources.GetObject("StarImg1.Image");
            StarImg1.Location = new Point(183, 11);
            StarImg1.Margin = new Padding(3, 2, 3, 2);
            StarImg1.Name = "StarImg1";
            StarImg1.Size = new Size(235, 214);
            StarImg1.TabIndex = 1;
            StarImg1.TabStop = false;
            // 
            // CircleImg2
            // 
            CircleImg2.Image = (Image)resources.GetObject("CircleImg2.Image");
            CircleImg2.Location = new Point(519, 11);
            CircleImg2.Margin = new Padding(3, 2, 3, 2);
            CircleImg2.Name = "CircleImg2";
            CircleImg2.Size = new Size(226, 228);
            CircleImg2.TabIndex = 2;
            CircleImg2.TabStop = false;
            // 
            // TriangleImg3
            // 
            TriangleImg3.Image = (Image)resources.GetObject("TriangleImg3.Image");
            TriangleImg3.Location = new Point(183, 322);
            TriangleImg3.Margin = new Padding(3, 2, 3, 2);
            TriangleImg3.Name = "TriangleImg3";
            TriangleImg3.Size = new Size(226, 229);
            TriangleImg3.TabIndex = 3;
            TriangleImg3.TabStop = false;
            // 
            // SquareImg4
            // 
            SquareImg4.Image = (Image)resources.GetObject("SquareImg4.Image");
            SquareImg4.Location = new Point(519, 337);
            SquareImg4.Margin = new Padding(3, 2, 3, 2);
            SquareImg4.Name = "SquareImg4";
            SquareImg4.Size = new Size(238, 214);
            SquareImg4.TabIndex = 4;
            SquareImg4.TabStop = false;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(814, 1);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.Size = new Size(560, 630);
            Result.TabIndex = 5;
            Result.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 276);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 6;
            label1.Text = "Mano Izquierda - 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 276);
            label2.Name = "label2";
            label2.Size = new Size(230, 37);
            label2.TabIndex = 7;
            label2.Text = "Mano Derecha - 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 569);
            label3.Name = "label3";
            label3.Size = new Size(212, 37);
            label3.TabIndex = 8;
            label3.Text = "Pie Izquierdo - 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(533, 569);
            label4.Name = "label4";
            label4.Size = new Size(275, 37);
            label4.TabIndex = 9;
            label4.Text = "Derecho Izquierdo - 4";
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = Color.FromArgb(0, 0, 192);
            ResultText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ResultText.Location = new Point(1000, 654);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(198, 54);
            ResultText.TabIndex = 10;
            ResultText.Text = "Resultado";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(ResultText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Result);
            Controls.Add(SquareImg4);
            Controls.Add(TriangleImg3);
            Controls.Add(CircleImg2);
            Controls.Add(StarImg1);
            Controls.Add(StartAction);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Auto Test";
            WindowState = FormWindowState.Maximized;
            KeyDown += Main_KeyDown;
            ((System.ComponentModel.ISupportInitialize)StarImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CircleImg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TriangleImg3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SquareImg4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartAction;
        private PictureBox StarImg1;
        private PictureBox CircleImg2;
        private PictureBox TriangleImg3;
        private PictureBox SquareImg4;
        private TextBox Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label ResultText;
    }
}