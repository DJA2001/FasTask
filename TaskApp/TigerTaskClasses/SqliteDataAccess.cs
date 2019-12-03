using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using TaskApp.TigerTaskClasses;

namespace TaskApp
{
    public class SqliteDataAccess
    {
        public static List<taskClass> LoadTasks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<taskClass>("select * from tbl_tasks", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<familyClass> LoadFamily()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<familyClass>("select * from tbl_family", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTask(taskClass task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_tasks (TaskTitle, AssignedPerson, Date, Time, Priority, Description) values (@TaskTitle, @AssignedPerson, @Date, @Time, @Priority, @Description)", task);
            }

        }

        public static void SaveFamily(familyClass family)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into tbl_family (FamilyMember) values (@FamilyMember)", family);
            }

        }

        public static void Delete(taskClass task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from tbl_tasks where TaskID=@TaskID", task);
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
