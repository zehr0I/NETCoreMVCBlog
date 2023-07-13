using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Yorum 
    {
        public string Yorumcu_Adi{ get; set; }
        public string Yorum_Konusu { get; set; }
        public bool Yorum_Durumu { get; set; }//iyi veya kötü yorum değerlendirme
        public DateTime Yorum_Tarihi{ get; set; }
    }
}
