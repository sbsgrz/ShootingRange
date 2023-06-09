﻿namespace ShootingRange
{
    public abstract class ShooterBase : IShooter
    {
        protected const float Min = 0;
        protected const float Max = 10;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public delegate void ResultAddedDelegate(object sender, EventArgs e);
        public abstract event ResultAddedDelegate ResultAdded;

        public ShooterBase()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }

        public ShooterBase(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public abstract void AddResult(float result);

        public void AddResult(int result)
        {
            AddResult((float)result);
        }

        public void AddResult(string result)
        {
            if (float.TryParse(result, out float r))
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

        public abstract List<float> GetResults();

        public Statistics GetStatistics()
        {
            Statistics statistics= new Statistics(GetResults());
            return statistics;
        }

        
    }
}
