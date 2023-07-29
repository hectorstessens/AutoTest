

using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace AutoTest
{
    public partial class BallMove : Form
    {
        int Finish = 0;
        int velocity = 2;
        bool invertFlag = true;
        int CirclePosition;

        int ShapeLocationOriginal;
        int ResultLocationOriginal;
        int CircleLocationOriginal;
        public BallMoveEntity BallMoveEntity = new BallMoveEntity();

        public BallMove()
        {
            InitializeComponent();


            this.Finish = Shape.Location.X + Shape.Width - Circle.Width;
            this.BallMoveEntity.Finish = Finish;
            this.CirclePosition = this.Circle.Location.X;

            ShapeLocationOriginal = Shape.Location.X;
            ResultLocationOriginal = Result.Location.X;
            CircleLocationOriginal = Circle.Location.X;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (invertFlag)
                Circle.Location = new Point(Circle.Location.X + velocity, Circle.Location.Y);
            else
                Circle.Location = new Point(Circle.Location.X - velocity, Circle.Location.Y);

            locationText.Text = $"Finish: {Finish} Location: {Circle.Location.X}";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            PressButton();
        }

        private void ShowResult()
        {
            Result.Text = this.BallMoveEntity.Result();
            if (this.BallMoveEntity.FinishResult())
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

        public void PressButton()
        {
            if (this.BallMoveEntity.IsFinish)
            {
                this.ShowResult();

                this.BallMoveEntity.Clean();

                Invert();

                this.velocity = 2;
                this.Finish = Shape.Location.X + (invertFlag ? Shape.Width - Circle.Width : 0);
                this.BallMoveEntity.Finish = Finish;


                return;
            }

            if (this.Timer.Enabled)
            {
                if (!this.BallMoveEntity.Level.Equals(BallMoveEntity.LevelTotal))
                {
                    this.velocity = velocity + (this.BallMoveEntity.Level / 4);
                    this.BallMoveEntity.Next(this.Circle.Location.X);
                    this.Result.Text = BallMoveEntity.Result();
                }

                this.Timer.Stop();
                this.Circle.Location = new Point(CirclePosition, Circle.Location.Y);
            }
            else
            {
                this.Timer.Start();
                this.Result.Text = BallMoveEntity.Result();
            }

            this.Level.Text = $"Nivel: {this.BallMoveEntity.Level}";
            this.Clean();
        }

        private void Clean()
        {
            this.ResultText.Text = "Resultado";
            this.ResultText.BackColor = Color.Blue;

        }
        private void BallMove_KeyDown(object sender, KeyEventArgs e)
        {
            PressKey(e);
        }

        private void StartButton_KeyDown(object sender, KeyEventArgs e)
        {
            PressKey(e);
        }

        private void BallMove_Load(object sender, EventArgs e)
        {

        }

        private void PressKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PressButton();
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (Application.OpenForms
            .OfType<ImageTime>()
            .ToList().Count == 0)
            {
                ImageTime frm = new ImageTime();
                frm.Show();
            }
            else
            {
                Application.OpenForms
                .OfType<ImageTime>()
                .ToList()
                .ForEach(form => form.Visible = true);
            }
        }


        public void Invert()
        {
            invertFlag = !invertFlag;
            if (invertFlag)
            {
                Circle.Location = new Point(CircleLocationOriginal, Circle.Location.Y);
                Result.Location = new Point(ResultLocationOriginal, Result.Location.Y);
                Shape.Location = new Point(ShapeLocationOriginal, Result.Location.Y);
            }
            else
            {
                int ResultLocation = Result.Location.X;
                int CircleLocation = Circle.Location.X;

                Circle.Location = new Point(ResultLocation + Result.Width, Circle.Location.Y);
                Result.Location = new Point(CircleLocation, Result.Location.Y);
                Shape.Location = new Point(CircleLocation + Result.Width, Result.Location.Y);
            }

            CirclePosition = Circle.Location.X;
        }

        private void BallMove_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BallMove_Leave(object sender, EventArgs e)
        {
        }
    }
}
