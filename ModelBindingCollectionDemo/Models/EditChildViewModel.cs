using System.ComponentModel.DataAnnotations;

namespace ModelBindingCollectionDemo.Models
{
    public class EditChildViewModel
    {
        [Microsoft.AspNetCore.Mvc.HiddenInput(DisplayValue =false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}