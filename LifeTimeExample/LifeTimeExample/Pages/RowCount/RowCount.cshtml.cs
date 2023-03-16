using LifeTimeExample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LifeTimeExample.Pages.RowCount
{
    public class RowCountModel : PageModel
    {
        private readonly Repository _repository;
        private readonly DataContext _context;
        public RowCountModel(Repository repository, DataContext context)
        {
            _repository= repository;
            _context= context;
        }
        public void OnGet()
        {
            DataContextCount = _context.RowCount;
            RepositoryCount = _repository.RowCount;
        }

        public int DataContextCount { get; set; }
        public int RepositoryCount { get; set; }
    }
}
