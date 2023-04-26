namespace ShootingRange 
{
    public class ShooterInMemory : ShooterBase
    {
        private List<int> results = new List<int>();
 
        public ShooterInMemory() : base() {}
        
        public ShooterInMemory(string firstName, string lastName) : base(firstName, lastName) { }
        
        public override void AddResult(int result)
        {
            if ((result >= Min) && (result <= Max))
                this.results.Add(result);
            else
                throw new Exception("Parameter out of range.");
        }

        public override List<int> GetResults()
        {
            return results;
        }
    }
}