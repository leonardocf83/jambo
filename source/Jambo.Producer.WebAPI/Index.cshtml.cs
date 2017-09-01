using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Jambo.Producer.Application.Queries;

namespace Jambo.Producer.WebAPI
{
    public class IndexModel : PageModel
    {
        private readonly IBlogQueries _blogQueries;

        public IndexModel(IBlogQueries blogQueries)
        {
            _blogQueries = blogQueries ?? throw new ArgumentNullException(nameof(blogQueries));
        }

        public void OnGet()
        {
        }
    }
}