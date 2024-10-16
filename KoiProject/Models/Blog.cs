public class Blog
{
    public int Id { get; set; }          // ID của bài viết
    public string Title { get; set; }    // Tiêu đề bài viết
    public string Content { get; set; }  // Nội dung bài viết
    public string Author { get; set; }   // Tác giả bài viết
    public DateTime PublishedDate { get; set; } // Ngày xuất bản
    public string Category { get; set; } // Danh mục bài viết (nếu cần)
}
