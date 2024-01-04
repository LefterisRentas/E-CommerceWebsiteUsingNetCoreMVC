using System.ComponentModel.DataAnnotations;

namespace E_CommerceWebsiteUsingNetCoreMVC.Models
{
    public class Category
    {
        //TODO: Make name unique for each category
        [Key]
        public int Id { get; set; }
        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "The valid range for this field is from 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
