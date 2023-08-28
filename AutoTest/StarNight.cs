using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTest
{
    public partial class StarNight : Form
    {
        int PositionX;
        int PositionY;
        int count = 0;
        int countSee = 0;
        int countTotal = 30;
        int countNotVisible = 0;
        public StarNight()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Start();

        }
        public void Start()
        {
            this.ResultLabel.Visible = false;
            this.timer.Enabled = true;
            this.btnEmpezar.Visible = false;
        }

        public void RandomPlace()
        {
            bool visible = new Random().Next(0, 2) == 1;
            count++;
            if (visible)
            {
                this.Star.Visible = true;
                PositionX = new Random().Next(0, this.Width);
                PositionY = new Random().Next(0, this.Height);

                this.Star.Location = new Point(this.PositionX, this.PositionY);
            }
            else
            {
                this.Star.Visible = false;
                countNotVisible++;
            }


            if (count == countTotal)
            {
                this.ResultLabel.Visible = true;
                this.ResultLabel.Text = $"Total Vistos {countSee}; Total {countTotal - countNotVisible}";
                this.timer.Enabled = false;
                this.btnEmpezar.Visible = false;
                this.count = 0;
                this.countSee = 0;
                this.countNotVisible = 0;
                this.Star.Visible = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RandomPlace();
        }

        public void Select(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                this.countSee++;
            }
        }

        private void StarNight_KeyDown(object sender, KeyEventArgs e)
        {
            Select(e);
        }

        private void btnEmpezar_KeyDown(object sender, KeyEventArgs e)
        {
            Select(e);
        }

        private void StarNight_Load(object sender, EventArgs e)
        {

        }
    }
}
