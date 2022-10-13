namespace BaseApi.Models
{
    public class Blog : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
        public bool IsPublic { get; set; }
        public string Position { get; set; }
        public string Thumbs { get; set; }
    }
}
