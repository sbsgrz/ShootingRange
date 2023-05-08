namespace ShootingRange.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserGetPoints_ShouldRemoveCorrectSum()
        {
            var shooter = new ShooterInMemory();

            shooter.AddResult(0);
            shooter.AddResult(2);
            shooter.AddResult(10);
                     
            Statistics stats = shooter.GetStatistics();
            Assert.AreEqual(12, stats.Sum);
        }

        [Test]
        public void WhenUserAddPoints_ShouldRemoveCorrectCount()
        {
            var shooter = new ShooterInMemory();

            shooter.AddResult(0);
            shooter.AddResult(2);
            shooter.AddResult(10);

            Statistics stats = shooter.GetStatistics();
            Assert.AreEqual(3, stats.Count);
        }

        [Test]
        public void WhenUserAddPoints_ShouldRemoveCorrectMax()
        {
            var shooter = new ShooterInMemory();

            shooter.AddResult(0);
            shooter.AddResult(2);
            shooter.AddResult(10);

            Statistics stats = shooter.GetStatistics();
            Assert.AreEqual(10, stats.Max);
        }

        [Test]
        public void WhenUserAddPoints_ShouldRemoveCorrectMin()
        {
            var shooter = new ShooterInMemory();

            shooter.AddResult(0);
            shooter.AddResult(10);

            Statistics stats = shooter.GetStatistics();
            Assert.AreEqual(0, stats.Min);
        }

        [Test]
        public void WhenUserAddPoints_ShouldRemoveCorrectAvg()
        {
            var shooter = new ShooterInMemory();

            shooter.AddResult(0);
            shooter.AddResult(10);
            shooter.AddResult(9);
            shooter.AddResult(5);

            Statistics stats = shooter.GetStatistics();
            Assert.AreEqual(6, stats.Avg);
        }
    }
}   