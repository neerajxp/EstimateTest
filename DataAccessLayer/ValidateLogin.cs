using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class ValidateLogin
    {
        public bool Validate(IUserDetails IUserDetailsObj)
        {
            // EstimatorDbContext db = new EstimatorDbContext();
            string cs = ConfigurationManager.ConnectionStrings["EstimatorDbContext"].ConnectionString;
            // UserDetail userDetails = new UserDetail();
            using (SqlConnection cn = new SqlConnection(cs))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "sp_ValidateUser";
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 200).Value = IUserDetailsObj.UserName;
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 200).Value = IUserDetailsObj.UserPassword;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //IUserDetailsObj.UserId
                    return true;
                }
                else
                    return false;
            }
        }
    }
}