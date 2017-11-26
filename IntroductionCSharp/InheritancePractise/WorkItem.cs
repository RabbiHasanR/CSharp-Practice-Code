using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class WorkItem
    {
        private static int getId;
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan Joblength { get; set; }
        static WorkItem()
        {
            getId =0;
        }
        public WorkItem()
        {
            this.Id = 0;
            this.Title = "Default Title";
            this.Description = "Default Description";
            this.Joblength = new TimeSpan();
        }
        public WorkItem(string Title,string Description,TimeSpan JobLength)
        {
            this.Id = getNextId();
            this.Title = Title;
            this.Description = Description;
            this.Joblength = Joblength;
        }
       
        public int getNextId()
        {
            return getId++;
        }
        public void update(String Title,TimeSpan Joblength)
        {
            this.Title = Title;
            this.Joblength = Joblength;
        }
        public override string ToString()
        {
            return String.Format("{0}-{1}",this.Id,this.Title);
        }
    }
}
