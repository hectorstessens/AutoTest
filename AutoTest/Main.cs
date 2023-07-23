using System.Linq.Expressions;

namespace AutoTest
{
    public partial class Main : Form
    {
        ImageTimeSelection ImageTimeSelection = new ImageTimeSelection();
        int NumberImage = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void StartAction_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            Clean();
            this.ImageTimeSelection.Start();
            this.ShowImage();

        }

        private void Clean()
        {
            StarImg1.Visible = false;
            CircleImg2.Visible = false;
            TriangleImg3.Visible = false;
            SquareImg4.Visible = false;
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
                    StarImg1.Visible = true;
                    break;
                case 2:
                    CircleImg2.Visible = true;
                    break;
                case 3:
                    TriangleImg3.Visible = true;
                    break;
                case 4:
                    SquareImg4.Visible = true;
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
            if (e.KeyCode == Keys.Enter)
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
                    case Keys.D1:
                        number = 1;
                        break;
                    case Keys.D2:
                        number = 2;
                        break;
                    case Keys.D3:
                        number = 3;
                        break;
                    case Keys.D4:
                        number = 4;
                        break;
                    default:
                        break;
                }

                this.ImageTimeSelection.SelectNumberImage(number, NumberImage);
                this.ShowImage();
                this.ShowResult();
            }
        }
    }
}