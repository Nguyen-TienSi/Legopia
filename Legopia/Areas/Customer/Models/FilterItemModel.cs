namespace Legopia.Areas.Customer.Models
{
    public class FilterItemModel
    {
        public required string Label { get; set; }
        public int Count { get; set; }
        public bool Selected { get; set; }
    }
}
