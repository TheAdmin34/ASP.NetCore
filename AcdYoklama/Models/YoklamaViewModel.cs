using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcdYoklama.Models
{
    public class YoklamaViewModel
    {
        public int YoklamaId { get; set; }

        [DisplayName("Ders Adı")]
        public string Ders_adi { get; set; }

        [DisplayName("Ders Saati")]
        public string Ders_saati { get; set; }

        [DisplayName("Ders Öğretmeni")]
        public string Ders_ogretmeni { get; set; }

        [DisplayName("Ders Konusu")]
        public string Ders_konusu { get; set; }

        [DisplayName("Ders Öğrencileri")]
        public string Ders_ogrencileri { get; set; }


        [DisplayName("Name")]
        public string FullName {
            get { return Ders_adi + " " + Ders_saati; }
        }    
    }
}
