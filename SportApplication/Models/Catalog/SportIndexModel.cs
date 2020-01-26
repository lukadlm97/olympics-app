using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Models.Catalog
{
    public class SportIndexModel
    {
        public IEnumerable<SportIndexListModel> Sports { get; set; }
    }
}
