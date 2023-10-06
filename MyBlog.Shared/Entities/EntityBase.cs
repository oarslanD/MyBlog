using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Shared.Entities
{
    public class EntityBase
    {
        // Override için virtual

        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; } = "Admin";
        public virtual string ModifiedBy { get; set; } = "Admin";
        public virtual string Note { get; set; }
                       


    }
}
