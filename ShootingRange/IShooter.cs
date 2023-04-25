
namespace ShootingRange
{
    public interface IShooter
    {
        public string firstName { get; }
        public string lastName { get; }


        void AddResult(int result);
        void AddResult(float result);
        void AddResult(string result);
        void AddResult(double result);
        void AddResult(char result);

        Statistics GetStatistics();
    }
}
