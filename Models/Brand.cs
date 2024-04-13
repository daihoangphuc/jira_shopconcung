using System.ComponentModel.DataAnnotations;

namespace Jira_ShopConCung.Models
{
    public class Brand
    {

        [Key]

        public int BrandId { get; set; }
        [StringLength(30)]

        public string? BrandName { get; set; }
    }
}
