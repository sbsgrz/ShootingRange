namespace ShootingRange
{
    public class Statistics
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Sum { get; private set; }
        public int Count { get; private set; }
        public float Avg 
        { 
            get
            {
                return Sum / Count;
            }
        }
        public float focusOnTheShield { get; set; }

        public Statistics(List <int> results)
        {
            Min = results.Min(); Max = results.Max();
            Sum = results.Sum(); Count = results.Count();
            focusOnTheShield = Max - Min;
        }
    }
}
