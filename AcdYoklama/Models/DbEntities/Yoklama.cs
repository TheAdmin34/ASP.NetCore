using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcdYoklama.Models.DbEntities
{
    public class Yoklama
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YoklamaId { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Ders_adi {  get; set; }
        public string Ders_saati { get; set; }
        public string Ders_ogretmeni { get; set; }
        public string Ders_konusu { get; set; }
        public string Ders_ogrencileri { get; set; }
    }
}
