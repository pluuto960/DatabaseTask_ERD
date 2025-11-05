using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ItemGroup
    {
        public int ItemGroupID { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
