using System.Linq.Expressions;

namespace AutoTest
{
    public partial class ImageTime : Form
    {

        const int Voice = 1;
        const int RedCircle = 2;
        const int Cross = 3;
        const int GreenCircle = 4;

        ImageTimeEntity ImageTimeSelection = new ImageTimeEntity();
        int NumberImage = 0;
        public ImageTime()
        {
            InitializeComponent();
        }

        private void StartAction_Click(object sender, EventArgs e)
        {
            Start();
            
        }

        private void Start()
        {
            StartAction.Visible = false;
            Clean();
            this.ImageTimeSelection.Start();
            this.ShowImage();
        }

        private void Clean()
        {
            imgVoice.Visible = false;
            imgRedCircle.Visible = false;
            imgCross.Visible = false;
            imgCircleGreen.Visible = false;
            Result.Text = string.Empty;
            ResultText.Text = "Resultado";
            ResultText.BackColor = Color.Gray;
        }

        private void ShowImage()
        {
            this.NumberImage = ImageTimeSelection.GetRandomNumber();

            Clean();
            switch (this.NumberImage)
            {
                case 1:
                    imgVoice.Visible = true;
                    break;
                case 2:
                    imgRedCircle.Visible = true;
                    break;
                case 3:
                    imgCross.Visible = true;
                    break;
                case 4:
                    imgCircleGreen.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void ShowResult()
        {
            if (this.ImageTimeSelection.IsFinish)
            {
                Result.Text = this.ImageTimeSelection.Stop();
                StartAction.Visible = true;
                if (this.ImageTimeSelection.FinishResult())
                {
                    ResultText.Text = "Aprobado!!!!!";
                    ResultText.BackColor = Color.Green;
                }
                else
                {
                    ResultText.Text = "No Aprobado!!!";
                    ResultText.BackColor = Color.Red;

                }
            }
            else
            {
                Result.Text = this.ImageTimeSelection.Result();
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            SelectImage(e);
        }

        private void StartAction_KeyDown(object sender, KeyEventArgs e)
        {
            SelectImage(e);
        }

        private void SelectImage(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                this.Start();
            }
            else
            {
                Clean();
                Thread.Sleep(500);

                int number = 0;

                switch (e.KeyCode)
                {
                    case Keys.Z:
                        number = Voice;
                        break;
                    case Keys.Q:
                        number = RedCircle;
                        break;
                    case Keys.NumPad3:
                        number = Cross;
                        break;
                    case Keys.NumPad9:
                        number = GreenCircle;
                        break;
                    default:
                        break;
                }

                this.ImageTimeSelection.SelectNumberImage(number, NumberImage);
                this.ShowImage();
                this.ShowResult();
            }
        }

        private void MoveBallButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (Application.OpenForms
            .OfType<BallMove>()
            .ToList().Count == 0)
            {
                BallMove frm = new BallMove();
                frm.Show();
            }
            else
            {
                Application.OpenForms
                .OfType<BallMove>()
                .ToList()
                .ForEach(form => form.Visible = true);
            }
        }

        private void ImageTime_Leave(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Result_KeyDown(object sender, KeyEventArgs e)
        {
            SelectImage(e);
        }
    }
}