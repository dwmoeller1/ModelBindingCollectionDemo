using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingCollectionDemo.Models
{
    public class EditParentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EditChildViewModel> Children { get; set; }
    }
}
