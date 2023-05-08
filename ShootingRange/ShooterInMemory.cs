namespace ShootingRange 
{
    public class ShooterInMemory : ShooterBase
    {
        private List<float> results = new List<float>();
        public override event ResultAddedDelegate? ResultAdded;

        public ShooterInMemory() : base() {}
        
        public ShooterInMemory(string firstName, string lastName) : base(firstName, lastName) { }
        
        public override void AddResult(float result)
        {
            if ((result >= Min) && (result <= Max))
            {
                this.results.Add(result);
                if (ResultAdded != null)
                    ResultAdded(this, new EventArgs());
            }
            else
                throw new Exception("Parameter out of range.");
        }

        public override List<float> GetResults()
        {
            return results;
        }
    }
}