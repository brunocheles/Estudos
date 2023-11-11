using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    public class DataBase
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\Development\\Projects\\CSharp\\MyContab\\MyContab\\database\\database.db; Version=3;");
        
        public void connect()
        {
            conn.Open();
        }
        public void disconnect()
        {
            conn.Close();
        }

        public void insertOrUpdate(string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, conn);
            cmd.ExecuteNonQuery();
        }
        public SQLiteTransaction beginTran()
        {
             return conn.BeginTransaction();
        }
        public void commitTran(SQLiteTransaction transaction)
        {
            transaction.Commit();   
        }
        public void rollbackTran(SQLiteTransaction transaction)
        {
            transaction.Rollback();
        }
    }
}
