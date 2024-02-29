using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcdYoklama.Models.DbEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OgrenciId { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Ogrenci_adi {  get; set; }
        public string Ogrenci_no { get; set; }
        public string Ogrenci_sinif { get; set; }
        public string Ogrenci_url { get; set; }

    }
}
