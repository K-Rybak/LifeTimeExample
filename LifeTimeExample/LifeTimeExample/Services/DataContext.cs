namespace LifeTimeExample.Services
{
    public class DataContext
    {
        static readonly Random _rand = new Random();
        public DataContext()
        {
            RowCount = _rand.Next(1, 1_000_000_000);
        }

        public int RowCount { get; }
    }
}
