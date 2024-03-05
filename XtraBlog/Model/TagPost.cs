namespace XtraBlog.Model
{
    public class TagPost
    {
        public int Id { get; set; }
        public int TagsID { get; set; }
        public int PostID { get; set; }
        public Post Post { get; set; }
        public Tags Tags { get; set; }

    }
}
