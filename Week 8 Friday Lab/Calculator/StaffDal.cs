using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StaffRecordDemo
{
    public class StaffDal
    {
        public List<Staff> GetAll()
        {
            SqlConnection connetion =new SqlConnection(@"server= (localdb)\MSSQLLocalDB;initial catalogue=WorkerDB; integrated security=true");
            if (connetion.State==ConnectionState.Closed)
            {
                connetion.Open();
            }
            SqlCommand command =new SqlCommand("Select * Staff");
            SqlDataReader reader = command.ExecuteReader();
            return List<Staff>
        }
    }
}