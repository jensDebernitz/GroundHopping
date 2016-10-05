using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundHopping
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private OleDbCommand sql;

        public Form1()
        {
            InitializeComponent();

            string connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                 "Data Source=..\\groundHooping.accdb";
            //string connect = "Provider=Microsoft.JET.OLEDB.4.0;" +
            //     "Data Source=..\\groundHooping.mdb";

            con = new OleDbConnection(connect);
            con.Open();

            sql = con.CreateCommand();

            // Set the Format type and the CustomFormat string.
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dd.MM.yyyy";

            sql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = sql.ExecuteReader();

            string[] ManschaftsArray;
            string[] stadionArray;
            string[] landArray;
            string[] stadtArray;

            ManschaftsArray = new string[0];
            stadionArray = new string[0];
            landArray = new string[0];
            stadtArray = new string[0];


            while (reader.Read())
            {
                string neuerVerein = reader[1].ToString();

                if (isNotInList(ManschaftsArray, neuerVerein))
                {
                    Array.Resize(ref ManschaftsArray, ManschaftsArray.Length + 1);
                    ManschaftsArray[ManschaftsArray.Length - 1] = neuerVerein;
                }

                neuerVerein = reader[2].ToString();

                if (isNotInList(ManschaftsArray, neuerVerein))
                {
                    Array.Resize(ref ManschaftsArray, ManschaftsArray.Length + 1);
                    ManschaftsArray[ManschaftsArray.Length - 1] = neuerVerein;
                }


                neuerVerein = reader[4].ToString();

                if (isNotInList(stadionArray, neuerVerein))
                {
                    Array.Resize(ref stadionArray, stadionArray.Length + 1);
                    stadionArray[stadionArray.Length - 1] = neuerVerein;
                }

                neuerVerein = reader[5].ToString();

                if (isNotInList(stadtArray, neuerVerein))
                {
                    Array.Resize(ref stadtArray, stadtArray.Length + 1);
                    stadtArray[stadtArray.Length - 1] = neuerVerein;
                }

                neuerVerein = reader[6].ToString();

                if (isNotInList(landArray, neuerVerein))
                {
                    Array.Resize(ref landArray, landArray.Length + 1);
                    landArray[landArray.Length - 1] = neuerVerein;
                }


            }
            reader.Close();

            // Create the list to use as the custom source. 
            var sourceManschaften = new AutoCompleteStringCollection();
            sourceManschaften.AddRange(ManschaftsArray);

            // Create the list to use as the custom source. 
            var sourceStadion = new AutoCompleteStringCollection();
            sourceStadion.AddRange(stadionArray);

            // Create the list to use as the custom source. 
            var sourceStadt = new AutoCompleteStringCollection();
            sourceStadt.AddRange(stadtArray);

            // Create the list to use as the custom source. 
            var sourceLand = new AutoCompleteStringCollection();
            sourceLand.AddRange(landArray);

            textBoxHeimmanschaft.AutoCompleteCustomSource = sourceManschaften;
            textBoxHeimmanschaft.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxHeimmanschaft.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxGastmanschft.AutoCompleteCustomSource = sourceManschaften;
            textBoxGastmanschft.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxGastmanschft.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxStadion.AutoCompleteCustomSource = sourceStadion;
            textBoxStadion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStadion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxStadt.AutoCompleteCustomSource = sourceStadt;
            textBoxStadt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStadt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxLand.AutoCompleteCustomSource = sourceLand;
            textBoxLand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxLand.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        bool isNotInList(string[] inList, string newValue)
        {
            bool returnValue = true;

            for (int i = 0; i < inList.Length; i++)
            {
                if (newValue == inList[i])
                {
                    returnValue = false;
                }
            }
            return returnValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = sql.ExecuteReader();
            dataGridView1.Columns.Clear();


            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dataGridView1.Rows.Add(row);
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql.CommandText = "insert into groundHooping(Heimmanschaft, Gastmanschaft, Datum, Stadion, Stadt, Land, Ergebnis)" +
                   " values('" + textBoxHeimmanschaft.Text + "', '"
                              + textBoxGastmanschft.Text + "', '"
                              + dateTimePickerDate.Text + "', '"
                              + textBoxStadion.Text + "', '"
                              + textBoxStadt.Text + "', '"
                              + textBoxLand.Text + "', '"
                              + textBoxErgebnis.Text + "');";
            sql.ExecuteNonQuery();

            if (textBoxHeimmanschaft.Text.ToLower() == "1.fc köln"
                || textBoxGastmanschft.Text.ToLower() == "1.fc köln")
            {
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Erster Fussball Club Köln,\r\nErster Fussball Club Köln,\r\nErster Fussball Club Köln,\r\nErster FC Köln... ";
                string caption = "Erster Fussballclub Köln";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                }
            }
        }
    }
}
