using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using John_Social_Club_Data.Data_Model;
using System.Data;
using System.Data.SqlClient;
using John_Social_Club_Data.Queries;

namespace John_Social_Club_Data.DataLayer
{
   public class ClubMemberAccess : IClubMemberAccess
    {

        public string AddMember(ClubMemberModel clubmember)
        {
            try {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["socialclubdb"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = Script.Insert;

                    command.Parameters.AddWithValue("@Name", clubmember.Name);
                    command.Parameters.AddWithValue("@DateOfBirth", (DateTime)clubmember.DateOfBirth);
                    command.Parameters.AddWithValue("@Occupation", clubmember.Occupation);
                    command.Parameters.AddWithValue("@Health", clubmember.Healthstatus);
                    command.Parameters.AddWithValue("@MaritialStatus", clubmember.MaritialStatus);
                    command.Parameters.AddWithValue("@NoOfChildren", clubmember.NumberOfchildren);
                    command.Parameters.AddWithValue("@Salary", clubmember.Salary);

                    command.Connection = con;
                    command.Connection.Open();
                    var rowsaffected =Convert.ToString( command.ExecuteNonQuery());
                    con.Close();

                    return rowsaffected;
                }

            }
            catch (Exception ex)
            {
                return ex.Message ;
            }
        }
    }
}

