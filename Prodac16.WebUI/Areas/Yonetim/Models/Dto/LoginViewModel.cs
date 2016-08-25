using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prodac16.WebUI.Areas.Yonetim.Models.Dto
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş Bırakılamaz!")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Parola alanı boş bırakılamaz!"),DataType(DataType.Password)]
        public string Parola { get; set; }

    }
}