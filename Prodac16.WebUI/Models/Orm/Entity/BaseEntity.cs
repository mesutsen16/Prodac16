using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prodac16.WebUI.Models.Orm.Entity
{
    /// <summary>
    /// Bu Base Model Class olarak tanımlandı. Tüm modeller bu sınıftan türetilecek. bu şekilde tüm modellerde ortak olan is, isdeleted, isupdated, addDate, updateddate, deleteddate özelliklerini kopyalar.
    /// </summary>
    public class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;

        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }
        private bool _isDeleted = false;

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        private DateTime? _deletedDate;

        public DateTime? DeletedDate
        {
            get { return _deletedDate; }
            set { _deletedDate = value; }
        }


        private DateTime? _updatedDate;

        public DateTime? UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }
        private bool _isUpdated = false;

        public bool IsUpdated
        {
            get { return _isUpdated; }
            set { _isUpdated = value; }
        }
    }
}