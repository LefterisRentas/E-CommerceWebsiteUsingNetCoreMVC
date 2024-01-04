using System.ComponentModel.DataAnnotations;

namespace E_CommerceWebsiteUsingNetCoreMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Category Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
