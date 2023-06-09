﻿namespace ShootingRange
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float FocusOnTheShield { get; set; }

        public float Avg 
        { 
            get
            {
                return Sum / Count;
            }
        }
        
        public Statistics(List <float> results)
        {
            Count = results.Count();
            if( Count > 0 )
            {
                Min = results.Min();
                Max = results.Max();
                Sum = results.Sum();
                FocusOnTheShield = Max - Min;
            }
        }
    }
}
