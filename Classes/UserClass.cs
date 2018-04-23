using System;
using System.Data;
using System.Data.SqlClient;

namespace ChattApp.Classes
{
    class UserClass
    {
        DataAccessLayer.DataAccessLayerClass DAL = new DataAccessLayer.DataAccessLayerClass();
        DataTable dt = new DataTable();

        public void Register_User( String user_name, String first_name, String last_name, String password)
        {
            // This method just for register user info to database
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar,45);
            param[0].Value = user_name;

            param[1] = new SqlParameter("@first_name", SqlDbType.VarChar,45);
            param[1].Value = first_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 45);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 45);
            param[3].Value = password;

            

            DAL.ExcutionCommand("register_user", param);

            DAL.close();
        }

        public DataTable User_Login(String user_name, String password)
        {
            //This method for check if user exist in db or not ?
            DAL.Open();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar,45);
            param[0].Value = user_name;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar,45);
            param[1].Value = password;

            dt = DAL.SelectData("user_login", param);
            return dt;
        }
        public void InsertStatusForFirstTime(int userID, int status)
        {
            //This method to change status of user if he close program it shows offline
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userId", SqlDbType.Int);
            param[0].Value = userID;

            param[1] = new SqlParameter("@status", SqlDbType.Int);
            param[1].Value = status;

            DAL.ExcutionCommand("InsertStatusForFirstTime", param);
            DAL.close();
        }
        public void Update_Status(int userID,int status)
        {
            //This method to change status of user if he close program it shows offline
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userId", SqlDbType.Int);
            param[0].Value = userID;

            param[1] = new SqlParameter("@status", SqlDbType.Int);
            param[1].Value = status;

            DAL.ExcutionCommand("updateStatus", param);
            DAL.close();
        }
        public DataTable get_Last_User_ID()
        {
            // Get users where if they are online
            DAL.Open();
            dt = DAL.SelectData("getLastUserID", null);

            return dt;
        }

        public DataTable Get_Online_Users(int usesrID)
        {
            // Get users where if they are online
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@userID", SqlDbType.Int);
            param[0].Value = usesrID;

            dt = DAL.SelectData("getUsersOnline", param);

            return dt;
        }
        public DataTable Verify_Add_New_user(String user_name,String first_name,String last_name)
        {
            // This method to check if any info of user exist in db 
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 45);
            param[0].Value = user_name;

            param[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 45);
            param[1].Value = first_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 45);
            param[2].Value = last_name;

            dt = DAL.SelectData("verifyAddingUser", param);

            return dt;
        }
    }
}
