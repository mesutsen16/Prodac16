using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prodac16.WebUI.Models.Orm.Entity
{
    public class Gorev:BaseEntity
    {
        [Required]
        public int BolumID { get; set; }
        [Required,StringLength(30)]
        public string GorevAdi { get; set; }
        [ForeignKey("BolumID")]
        public virtual Bolum Bolum { get; set; }
        
    }
}