using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcdYoklama.Models
{
    public class EmployeeViewModel
    {
        public int OgrenciId { get; set; }

        [DisplayName("Öğrenci Adı")]
        public string Ogrenci_adi { get; set; }

        [DisplayName("Öğrenci No")]
        public string Ogrenci_no { get; set; }

        [DisplayName("Öğrenci Sınıfı")]
        public string Ogrenci_sinif { get; set; }

        [DisplayName("Öğrenci Url")]
        public string Ogrenci_url { get; set; }


        [DisplayName("Name")]
        public string FullName {
            get { return Ogrenci_adi + " " + Ogrenci_no; }
        }    
    }
}
