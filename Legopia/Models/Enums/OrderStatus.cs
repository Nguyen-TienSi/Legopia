namespace Legopia.Models.Enums
{
    public enum OrderStatus
    {
        Pending,    // Chờ xác nhận
        Processing, // Đang xử lý
        Shipped,    // Đã giao hàng
        Completed,  // Hoàn tất
        Cancelled   // Đã hủy
    }
}
