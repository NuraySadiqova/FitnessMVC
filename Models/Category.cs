using FitnessMVC.Models.Common;

namespace FitnessMVC.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Trainer>? Traniers { get; set; }

    }
}
