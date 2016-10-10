using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundHopping
{
    class dataBaseClubEntrys
    {
        private OleDbConnection mConnection;
        private OleDbCommand mSql;

        public dataBaseClubEntrys(ref OleDbConnection connection, ref OleDbCommand sql)
        {
            mConnection = connection;
            mSql = sql;
        }

        public void readClubList(ref DataGridView dataGridView)
        {
            mSql.CommandText = "select * from Vereine;";
            OleDbDataReader reader = mSql.ExecuteReader();
            dataGridView.Columns.Clear();

            //stelle denn Kopf der Tabelle her
            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            //Daten aus der Datenbank anzeigen
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                {

                    row[i] = reader[i];
                }

                dataGridView.Rows.Add(row);

            }
            reader.Close();
        }

        public void insertClubToDataBase(string club, int bundesLand)
        {
            mSql.CommandText =    "insert into Vereine(Verein, Bundesland)" 
                                + " values('" + club + "', '"
                                + bundesLand + "');";
            mSql.ExecuteNonQuery();
        }

        public void changeClubEntry(string club, int bundesland, string id)
        {
            string q =    "update Vereine set Verein='" 
                        + club
                        + "'where id=" + id;
            doSomething(q);

            q =   "update Vereine set Bundesland='" 
                + bundesland
                + "'where id=" + id;
            doSomething(q);
        }

        //tue etwas auf der Datenbank
        private void doSomething(string q)
        {
            mSql.CommandText = q;
            mSql.ExecuteNonQuery();
        }

    }
}
