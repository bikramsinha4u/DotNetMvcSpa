using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [Display(Description = "Product Name")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "Product Name must be between {2} to {1} characters.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Introduction Date is required.")]
        [Display(Description = "Introduction Date")]
        [Range(typeof(DateTime), "1/1/2000", "12/31/2020", ErrorMessage = "Introduction Date must be between {1} & {2}")]
        public DateTime IntroductionDate { get; set; }

        [Required(ErrorMessage = "URL is required.")]
        [Display(Description = "URL")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "URL must be between {2} to {1} characters.")]
        public string Url { get; set; }

        [Range(1, 9999, ErrorMessage = "{0} must be between {1} to {2}.")]
        public decimal Price { get; set; }
    }
}
