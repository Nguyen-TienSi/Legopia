namespace Legopia.Areas.Admin.Models
{
    public class SidebarItemModel
    {
        public string Title { get; set; } = string.Empty;
        public string? Icon { get; set; } // e.g., "bi bi-house-door"
        public string? Url { get; set; }
        public List<SidebarItemModel>? SubItems { get; set; }
    }
}
