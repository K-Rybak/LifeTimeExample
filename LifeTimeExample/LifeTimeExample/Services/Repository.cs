namespace LifeTimeExample.Services
{
    public class Repository
    {
        private readonly DataContext _context;
        public Repository(DataContext context) 
        {
            _context = context;
        }

        public int RowCount => _context.RowCount;
    }
}
