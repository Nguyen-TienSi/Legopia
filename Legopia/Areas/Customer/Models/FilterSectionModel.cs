namespace Legopia.Areas.Customer.Models
{
    public class FilterSectionModel
    {
        public required string Title { get; set; }
        public string SectionKey { get; set; } = Guid.NewGuid().ToString("N");
        public ICollection<FilterItemModel>? Filters { get; set; }
    }
}
