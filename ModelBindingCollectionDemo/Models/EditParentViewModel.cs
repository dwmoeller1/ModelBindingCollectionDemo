using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingCollectionDemo.Models
{
    public class EditParentViewModel
    {
        [Microsoft.AspNetCore.Mvc.HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EditChildViewModel> Children { get; set; }
    }
}
