using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Prodac16.WebUI.Models.Orm.Entity
{
    /// <summary>
    /// Kullanıcı bilgilerini tutacak olan tablo
    /// </summary>
    public class Kullanici:BaseEntity
    {
        [Required,StringLength(50)]
        public string KullaniciAdi { get; set; }
        [Required, StringLength(50)]
        public string Adi { get; set; }
        [Required, StringLength(50)]
        public string Soyadi { get; set; }
        [Required, StringLength(10)]
        public string SicilNo { get; set; }
        [StringLength(256)]
        public string EMailAdresi { get; set; }
        [StringLength(50)]
        public string Resim { get; set; }
        [Required,DataType(DataType.Password), StringLength(256)]
        public string Parola { get; set; }
        [Required]
        public int BolumID { get; set; }

        [ForeignKey("BolumID")]
        public virtual Bolum Bolum { get; set; }

        public int? GorevID { get; set; }
        [ForeignKey("GorevID")]
        public virtual Gorev Gorev { get; set; }
    }
}