using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class ChangeRequest:WorkItem
    {
        protected int OriginalId { get; set; }
        public ChangeRequest(int OriginalId,String Title,String Description,TimeSpan Joblength) : base(Title, Description, Joblength)
        {
            this.Id = getNextId();
            this.OriginalId = OriginalId;
        }

    }
}
