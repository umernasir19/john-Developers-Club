using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Social_Club_Data.Queries
{
   public abstract class Script
    {
        public static readonly String Insert = "Insert Into " + 
            "ClubMembers(Name,DateOfBirth,Occupation,Health,Maritialstatus,NoOfChildrens,Salary)" +
            "Values(@Name,@DateOfBirth,@Occupation,@Health,@MaritialStatus,@NoOfChildren,@Salary)";


    }
}
