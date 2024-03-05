using System.ComponentModel.DataAnnotations;

namespace XtraBlog.Model
{
    public class Tags
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} this area dont allow null value")]
        [StringLength(50, ErrorMessage = "{0} uzunlugu {1} simvoldan cox ola bilmez")]
        [MaxLength(50)]
       public string Name { get; set; }
        public List<TagPost>?TagPost  { get; set; }
    }
}
