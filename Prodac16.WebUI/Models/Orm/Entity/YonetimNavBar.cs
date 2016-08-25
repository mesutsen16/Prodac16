using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prodac16.WebUI.Models.Orm.Entity
{
    public class YonetimNavBar:BaseEntity
    {
        [Required,StringLength(100)]
        public string Adi { get; set; }
        [Required,StringLength(150)]
        public string Url { get; set; }
        [StringLength(150)]
        public string CssClass { get; set; }
        public int Sira { get; set; }
    }
}