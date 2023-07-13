using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi 
    {
        public DateTime Gonderi_Zamani { get; set; }
        public string Gonderi_Baslik { get; set; }
        public string Gonderi_Icerik{ get; set; }
        public string Gonderi_Çesit { get; set; }
    }
}
