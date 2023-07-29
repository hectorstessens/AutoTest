using System.Text;

namespace AutoTest
{
    public class ImageTimeEntity
    {
        private DateTime StartTime;
        private DateTime FinishTime;

        private int Iteration = 20;
        private int CurrentIteration = 0;
        private double SecondTotal = 0;
        private double SecondsAverage = 0;
        private int TotalCorrect = 0;
        public bool IsFinish { get; private set; }
        
        public bool FinishResult() 
        {
            if (SecondsAverage < 4 && TotalCorrect >= 16)
                return true;
            else
                return false;
        }
        public void Start()
        {
            this.ImagesList = new List<ImageTimeSelectionRow>();
            this.StartTime = DateTime.Now;
            this.CurrentIteration = 0;
            this.IsFinish = false;
            this.SecondTotal = 0;
        }

        public int GetRandomNumber()
        {
            if (!this.IsFinish)
                return new Random().Next(1, 5);
            else
                return 0;
        }

        public void SelectNumberImage(int number, int numberImage)
        {
            if (!IsFinish) 
            { 
                CurrentIteration++;
                if (number == numberImage)
                    CorrectImage();
                else
                    IncorrectImage();

                if (CurrentIteration == Iteration) 
                { 
                    IsFinish = true;
                    this.FinishTime = DateTime.Now;
                }
            }
        }
        private void CorrectImage()
        {
            this.ImagesList.Add(
                new ImageTimeSelectionRow() { Date = DateTime.Now, IsCorrect = true });
        }

        private void IncorrectImage()
        {
            this.ImagesList.Add(
                new ImageTimeSelectionRow() { Date = DateTime.Now, IsCorrect = false });
        }

        public string Stop()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Start Time {this.StartTime.ToString()}");
            DateTime PreviusTime = this.StartTime;
            int c = 0;
            foreach (var item in ImagesList)
            {
                c++;
                sb.AppendLine();
                var seconds = (item.Date - PreviusTime).TotalSeconds;
                sb.Append($"Iteración {c} segundos en respuesta {seconds.ToString()} , Correcto: {item.IsCorrect}");
                PreviusTime = item.Date;
                this.SecondTotal = this.SecondTotal + seconds;
            }

            sb.AppendLine();
            this.TotalCorrect = this.ImagesList.Count(m => m.IsCorrect);
            this.SecondsAverage =   this.SecondTotal / Iteration;

            sb.Append($"Total Correctas:{this.TotalCorrect} , Tiempo Promedio: {this.SecondsAverage}");

            return sb.ToString();
        }

        public string Result() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Start Time {this.StartTime.ToString()}");
            DateTime PreviusTime = this.StartTime;
            int c = 0;
            foreach (var item in ImagesList)
            {
                c++;
                sb.AppendLine();
                var seconds = (PreviusTime - item.Date).TotalSeconds;
                sb.Append($"Iteración {c} segundos en respuesta {seconds.ToString()} , Correcto: { item.IsCorrect }");
                PreviusTime = item.Date;
            }

            return sb.ToString();

        }
        public List<ImageTimeSelectionRow> ImagesList { get; set; }  = new List<ImageTimeSelectionRow>();
    }

    public class ImageTimeSelectionRow
    {
        public DateTime Date { get; set; }
        public bool IsCorrect { get; set; }
    }
}
