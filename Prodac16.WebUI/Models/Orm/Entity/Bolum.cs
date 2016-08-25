using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prodac16.WebUI.Models.Orm.Entity
{
    public class Bolum:BaseEntity
    {
        [Required, StringLength(50)]
        public string BolumAdi { get; set; }
        public virtual List<Gorev> Gorevs { get; set; }
        public virtual List<Kullanici> Kullanicis { get; set; }
    }
}