using John_Social_Club_Data.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Social_Club_Data.Data_Model
{
   public class ClubMemberModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Health Healthstatus { get; set; }
        public Occupation Occupation { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        public int NumberOfchildren { get; set; }
        public double Salary { get; set; }
    }
}
