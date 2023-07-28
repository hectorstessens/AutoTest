using System.Text;

namespace AutoTest
{

    public class BallMoveEntity
    {
        public int Finish {get; set;}
        public int LevelTotal { get { return 10 + 1; } }
        public int Level { get; private set; } = 1;

        public bool IsFinish { get { return this.Level == this.LevelTotal ; } }

        public List<BallMoveRow> BallMoveRows { get; set; } = new List<BallMoveRow>();

        public int Next(int position) 
        {
            if (this.Level < this.LevelTotal)
            {
                this.Level = this.Level + 1;
                this.BallMoveRows.Add(new BallMoveRow(position, DateTime.Now, this.Level));
            }
            return Level;
        }       

        public void Clean() 
        {
            this.BallMoveRows = new List<BallMoveRow>();
            this.Level = 1;
        }

        public string Result()
        {
            StringBuilder sb = new StringBuilder();
            int c = 0;

            foreach (var item in BallMoveRows)
            {
                c++;
                sb.AppendLine();
                sb.Append($"{c} - Paro en {item.Position}  , Correcto: {item.IsOk(this.Finish)} , Finish : {this.Finish}");
            }

            sb.AppendLine();
           
            return sb.ToString();
        }

        public bool FinishResult()
        {
            if (this.BallMoveRows.Where(m => m.IsOk(this.Finish)).ToList().Count > 4)
                return true;
            else
                return false;
        }
    }

    public class BallMoveRow
    {
        public BallMoveRow(int position, DateTime date, int level)
        {
            this.Position = position;
            this.Date = date;
            this.Level = level;
        }

        public int Position { get; set; }
        public DateTime Date { get; set; }
        public int Level { get; set; }

        public bool IsOk(int finish) 
        {
            int positionMax = Position + 100;
            int positionMin = Position - 100;

            return  finish > positionMin && finish < positionMax;
        }
    }
}
