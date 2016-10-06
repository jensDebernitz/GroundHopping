using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundHopping
{
    public partial class Form1 : Form
    {
        enum DataBaseEntrys
        {
            ID, 
            HeimManschaft,
            GastManschaft,
            Datum,
            Stadion,
            Stadt,
            Land,
            Ergebnis,
            Bundesland
        };


        private OleDbConnection con;
        private OleDbCommand sql;

        public Form1()
        {
            InitializeComponent();

            string connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                 "Data Source=..\\groundHooping.accdb";

            con = new OleDbConnection(connect);

            //Öffnen der Datenbank
            con.Open();

            sql = con.CreateCommand();

            // Set the Format type and the CustomFormat string.
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dd.MM.yyyy";

            readOutDataBaseAndInitialAutoComplete();

            //Filter Funktion des Save File Dialog
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Speichern CSV-Datei";

            //Die combox zum speichern des Bundeslandes soll standart mäßig auf Rheinland-Pfalz stehen
            comboBoxBundesland.SelectedIndex = 11;
        }

        /*
         * Funtkion zum auslesen der Datenbank um die Autovervollständigung zu erhalten,
         * sowie die comboboxen zu füllen für die filter funtion
         */
        private void readOutDataBaseAndInitialAutoComplete()
        {
            //Read out the Data Base for the Auto Complete function
            sql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = sql.ExecuteReader();

            string[] ManschaftsArray;
            string[] stadionArray;
            string[] landArray;
            string[] bundeslandArray;
            string[] stadtArray;

            ManschaftsArray = new string[0];
            stadionArray = new string[0];
            landArray = new string[0];
            bundeslandArray = new string[0];
            stadtArray = new string[0];

            //werte aus der Datenbank holen und in Temporäre Arrays speichern
            while (reader.Read())
            {
                string neuerVerein = reader[(int)DataBaseEntrys.HeimManschaft].ToString();

                if (isNotInList(ManschaftsArray, neuerVerein))
                {
                    Array.Resize(ref ManschaftsArray, ManschaftsArray.Length + 1);
                    ManschaftsArray[ManschaftsArray.Length - 1] = neuerVerein;
                    comboBoxFilterHeimManschaft.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseEntrys.GastManschaft].ToString();

                if (isNotInList(ManschaftsArray, neuerVerein))
                {
                    Array.Resize(ref ManschaftsArray, ManschaftsArray.Length + 1);
                    ManschaftsArray[ManschaftsArray.Length - 1] = neuerVerein;
                    comboBoxFilterGastManschaft.Items.Add(neuerVerein);
                }


                neuerVerein = reader[(int)DataBaseEntrys.Stadion].ToString();

                if (isNotInList(stadionArray, neuerVerein))
                {
                    Array.Resize(ref stadionArray, stadionArray.Length + 1);
                    stadionArray[stadionArray.Length - 1] = neuerVerein;
                    comboBoxFilterStadion.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseEntrys.Stadt].ToString();

                if (isNotInList(stadtArray, neuerVerein))
                {
                    Array.Resize(ref stadtArray, stadtArray.Length + 1);
                    stadtArray[stadtArray.Length - 1] = neuerVerein;
                    comboBoxFilterStadt.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseEntrys.Land].ToString();

                if (isNotInList(landArray, neuerVerein))
                {
                    Array.Resize(ref landArray, landArray.Length + 1);
                    landArray[landArray.Length - 1] = neuerVerein;
                    comboBoxFilterLand.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseEntrys.Bundesland].ToString();

                if (isNotInList(bundeslandArray, neuerVerein))
                {
                    Array.Resize(ref bundeslandArray, bundeslandArray.Length + 1);
                    bundeslandArray[bundeslandArray.Length - 1] = neuerVerein;
                    comboBoxFilterBundesland.Items.Add(neuerVerein);
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

        /*
         * Prüfen ob neuer string im string Array schon enthalten ist
         */
        private bool isNotInList(string[] inList, string newValue)
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

        /*
         * Click Funktion vom Auslese Button
         */
        private void button2_Click(object sender, EventArgs e)
        {
            sql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = sql.ExecuteReader();
            dataGridView1.Columns.Clear();

            //stelle denn Kopf der Tabelle her
            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            //Daten aus der Datenbank anzeigen
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                bool addedToDataGridView = false;

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    
                    //Wenn die Filter FUnktion aktiviert ist
                    //dann prüfe ob auch danach
                    if(checkBoxFilterEnable.Checked == true)
                    {
                        addedToDataGridView = checkFilter(ref row, ref reader, i);
                    }
                    else
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                }

                //Zeile zur Tabelle hinzufügen
                if(addedToDataGridView == true)
                {
                    dataGridView1.Rows.Add(row);
                }
                
            }
            reader.Close();
        }

        //Check der Filter Funktionen
        //TODO: Datum funktioniert noch nicht, deshalb auch die ComboBox ausgegraut
        private bool checkFilter(ref object[] row, ref OleDbDataReader reader, int i)
        {
            bool addedToDataGridView = false;

            //Filter funktioniert wie folg:
            //wenn die CheckBox Filter anwenden aktiviert ist,
            //wird nach welchen Filterkriterien gefiltert werden soll

            switch (comboBoxFilterTo.SelectedIndex)
            {
                case 0:
                    if (comboBoxFilterHeimManschaft.SelectedItem.ToString() == reader[(int)DataBaseEntrys.HeimManschaft].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 1:
                    if (comboBoxFilterGastManschaft.SelectedItem.ToString() == reader[(int)DataBaseEntrys.GastManschaft].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 2:
                    if (comboBoxFilterDatum.SelectedItem.ToString() == reader[(int)DataBaseEntrys.Datum].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 3:
                    if (comboBoxFilterBundesland.SelectedItem.ToString() == reader[(int)DataBaseEntrys.Bundesland].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 4:
                    if (comboBoxFilterStadion.SelectedItem.ToString() == reader[(int)DataBaseEntrys.Stadion].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 5:
                    if (comboBoxFilterStadt.SelectedItem.ToString() == reader[(int)DataBaseEntrys.Stadt].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 6:
                    if (comboBoxFilterLand.SelectedItem.ToString() == reader[(int)DataBaseEntrys.Land].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                default:
                    break;
            }

            return addedToDataGridView;
        }

        /*
         * Button 3 == Speichern Button
         * Hier werden die zuvor eingegebenen Daten in die datenbank geschrieben
         */
        private void button3_Click(object sender, EventArgs e)
        {
            sql.CommandText = "insert into groundHooping(Heimmanschaft, Gastmanschaft, Datum, Stadion, Stadt, Land, Ergebnis, Bundesland)" +
                   " values('" + textBoxHeimmanschaft.Text + "', '"
                              + textBoxGastmanschft.Text + "', '"
                              + dateTimePickerDate.Text + "', '"
                              + textBoxStadion.Text + "', '"
                              + textBoxStadt.Text + "', '"
                              + textBoxLand.Text + "', '"
                              + textBoxErgebnis.Text + "', '"
                              + comboBoxBundesland.SelectedItem.ToString() + "');";
            sql.ExecuteNonQuery();

            label8.Text = comboBoxBundesland.SelectedItem.ToString();

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

        /*
         * Funktion zum Schliessen der Anwendung
         * ACHTUNG: hier muss auch der zugriff der geöffneten Datenbank wieder geschlossen werden
         */
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Close();
            Close();
        }

        /*
         * Export Funktion 
         * Hier wird eine Datei gespeichert im CSV Format
         */
        private void exportNachCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = sql.ExecuteReader();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(path);


                string outString = String.Empty;

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    outString += reader.GetName(i).ToString();

                    if (i < reader.FieldCount - 1)
                    {
                        outString += ";";
                    }
                }
                
                sw.WriteLine(outString);
                outString = String.Empty;

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        outString += reader[i];
                        if (i < reader.FieldCount - 1)
                        {
                            outString += ";";
                        }
                    }
                    
                    sw.WriteLine(outString);
                    outString = String.Empty;
                }
                reader.Close();

                sw.Close();
            }
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about mAbout = new about();

            if(mAbout.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
