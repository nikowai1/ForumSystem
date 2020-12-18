using System.Collections.Generic;

namespace ForumSystem.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexCategoryViewModel> Categories { get; set; }
    }
}
