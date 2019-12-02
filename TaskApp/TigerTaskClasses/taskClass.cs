using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.TigerTaskClasses
{
    public class taskClass
    {
        //Getter setter properties
        //acts as a data carrier in our application
        public string TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string AssignedPerson { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
    }

    public class familyClass
    {
        public string FamilyMember { get; set; }
    }
}
