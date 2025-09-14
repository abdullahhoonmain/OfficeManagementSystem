using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OfficeManagementSystem
{
    class DbCon
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=officemanagementsystemdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public object Response { get; private set; }

        public bool UDI(String query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                return false;
            }
            catch (Exception ex1)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        public bool TestConnection()
        {
            try
            {
                con.Open();
                return true; // connection successful
            }
            catch (Exception ex)
            {
                return false; // connection failed
            }
            finally
            {
                con.Close();
            }
        }

       





    }

}