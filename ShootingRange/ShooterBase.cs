namespace ShootingRange
{
    public abstract class ShooterBase : IShooter
    {
        protected const int Min = 0;
        protected const int Max = 10;
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public delegate void ResultAddedDelegate(object sender, EventArgs e);
        public abstract event ResultAddedDelegate ResultAdded;

        public ShooterBase()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        public ShooterBase(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public abstract void AddResult(int result);

        public void AddResult(float result)
        {
            AddResult((int)result);
        }

        public void AddResult(string result)
        {
            if (int.TryParse(result, out int r))
                this.AddResult(r);
            else
                throw new Exception("Wrong string format.");
        }

        public void AddResult(double result)
        {
            AddResult((int)result);
        }

        public void AddResult(char result)
        {
            if (char.IsDigit(result))
                AddResult(char.GetNumericValue(result));
            else
                throw new Exception("Wrong char.");
        }

        public abstract List<int> GetResults();

        public Statistics GetStatistics()
        {
            Statistics statistics= new Statistics(GetResults());
            return statistics;
        }

        
    }
}
