using John_Social_Club_Data.Data_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Social_Club_Data.DataLayer
{
    interface IClubMemberAccess
    {
        string AddMember(ClubMemberModel clubmember);
    }
}
