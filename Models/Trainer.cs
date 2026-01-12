using FitnessMVC.Models.Common;

namespace FitnessMVC.Models
{
    public class Trainer:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
