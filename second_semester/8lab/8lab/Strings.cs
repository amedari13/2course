using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _8lab
{
    static class Strings
    {
        public static readonly string Connect_DB = ConfigurationManager.ConnectionStrings["8lab.Properties.Settings.userConnectionString"].ConnectionString;
        public static readonly string View_DB = "select* from(_STUDENT join _ADRESS on _STUDENT.ID= _ADRESS.ID);";
        public static readonly string Sort_DB = "select* from(_STUDENT join _ADRESS on _STUDENT.ID= _ADRESS.ID) order by AGE desc;";

        public static readonly string Del_fromDB = "delete from _ADRESS where ID >3; delete from _STUDENT where ID > 3";

        public static readonly string Edit_DB = "update _STUDENT set AGE = 19 where F_NAME = 'Daria'";


        static int index;
        static string[] names = { "Olga", "Maria", "Pavel", "Max", "Alex" };
        public static string Add_toDB()
        {
            using (SqlConnection connection = new SqlConnection(Connect_DB))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select top 1 ID from _STUDENT order by ID desc", connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "index");
                foreach (DataRow r in dataSet.Tables["index"].Rows)
                {
                    index = (int)r[0]; break;
                }
            }
            Random rand = new Random();
            index++;
            return "insert into _STUDENT(ID, AGE, F_NAME) values(" +
                index + ", " + rand.Next(18, 25) + ", '" + names[rand.Next(0, 4)] + "');" +
                "insert into _ADRESS(ID, CITY) values (" +
                index + ", 'Minsk');";

        }
    }
}