

namespace AutoTest
{
    public partial class BallMove : Form
    {
        int Finish = 0;
        int velocity = 2;

        public BallMoveEntity BallMoveEntity = new BallMoveEntity();
        public BallMove()
        {
            InitializeComponent();

            this.Finish = Shape.Location.X + Shape.Width;
            this.BallMoveEntity.Finish = Finish;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Circle.Location = new Point(Circle.Location.X + velocity, Circle.Location.Y);
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
                this.velocity = 2;
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
                this.Circle.Location = new Point(32, Circle.Location.Y);
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
            ImageTime frm = new ImageTime();
            frm.Show();
            this.Hide();
        }
    }
}
