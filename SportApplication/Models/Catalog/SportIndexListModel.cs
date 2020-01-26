using SportApplicationData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Models.Catalog
{
    public class SportIndexListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Individual { get; set; }
        public Category Category { get; set; }
        
    }
}
