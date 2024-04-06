using System;
using System.Data.SqlClient;

class clsDatabase
{
    public static SqlConnection con;
     public static bool OpenConnection()
     {
         try
         {
             con = new SqlConnection("SERVER=MEE\\MYB2014996;Database=DVDLibrary;uid=mylogin;pwd=mylogin");
             con.Open();

         }
         catch (Exception)
         {
             return false;
         }
         return true;

     }

     public static bool CloseConnection()
     {
         try
         {
             con.Close();
         }
         catch (Exception)
         {
             return false;
             throw;
         }
         return true;
     }


