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
        enum DataBaseGroundHoppingEntrys
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

        enum DataBaseClubEntrys
        {
            ID,
            Club,
            Bundesland
        };


        private OleDbConnection mCon;
        private OleDbCommand mSql;
        private Int64 mCountryCounter;

        private dataBaseClubEntrys mDataBaseClubEntrys;

        public Form1()
        {
            InitializeComponent();

            string connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                 "Data Source=..\\groundHooping.accdb";

            mCon = new OleDbConnection(connect);

            //Öffnen der Datenbank
            mCon.Open();

            mSql = mCon.CreateCommand();

            mDataBaseClubEntrys = new dataBaseClubEntrys(ref mCon, ref mSql);

            // Set the Format type and the CustomFormat string.
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dd.MM.yyyy";

            readOutDataBaseAndInitialAutoComplete();

            //Filter Funktion des Save File Dialog
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Speichern CSV-Datei";

            //Die combox zum speichern des Bundeslandes soll standart mäßig auf Rheinland-Pfalz stehen
            comboBoxBundesland.SelectedIndex = 11;
            comboBoxFilterTo.SelectedIndex = 0;
            readOutTable();
            mDataBaseClubEntrys.readClubList(ref dataGridView2);
        }

        /*
         * Funtkion zum auslesen der Datenbank um die Autovervollständigung zu erhalten,
         * sowie die comboboxen zu füllen für die filter funtion
         */
        private void readOutDataBaseAndInitialAutoComplete()
        {
            //Read out the Data Base for the Auto Complete function
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

            comboBoxFilterHeimManschaft.Items.Clear();
            comboBoxFilterGastManschaft.Items.Clear();
            comboBoxFilterBundesland.Items.Clear();
            comboBoxFilterStadion.Items.Clear();
            comboBoxFilterStadt.Items.Clear();
            comboBoxFilterLand.Items.Clear();
            comboBoxFilterDatum.Items.Clear();
            comboBoxHeimmanschaft.Items.Clear();
            comboBoxGastmanschaft.Items.Clear();
            mCountryCounter = 0;

            miscClass misc = new miscClass();

            //Read out the Data Base for the Auto Complete function
            mSql.CommandText = "select * from Vereine;";
            OleDbDataReader reader = mSql.ExecuteReader();
            //werte aus der Datenbank holen und in Temporäre Arrays speichern
            while (reader.Read())
            {
                string neuerVerein = reader[(int)DataBaseClubEntrys.Club].ToString();

                if (misc.isNotInList(ManschaftsArray, neuerVerein))
                {
                    Array.Resize(ref ManschaftsArray, ManschaftsArray.Length + 1);
                    ManschaftsArray[ManschaftsArray.Length - 1] = neuerVerein;
                    comboBoxFilterHeimManschaft.Items.Add(neuerVerein);
                    comboBoxFilterGastManschaft.Items.Add(neuerVerein);
                    comboBoxHeimmanschaft.Items.Add(neuerVerein);
                    comboBoxGastmanschaft.Items.Add(neuerVerein);
                }
            }

            reader.Close();

            mSql.CommandText = "select * from groundHooping;";
            reader = mSql.ExecuteReader();
            //werte aus der Datenbank holen und in Temporäre Arrays speichern
            while (reader.Read())
            {
                string neuerVerein = reader[(int)DataBaseGroundHoppingEntrys.HeimManschaft].ToString();

                neuerVerein = reader[(int)DataBaseGroundHoppingEntrys.Stadion].ToString();

                if (misc.isNotInList(stadionArray, neuerVerein))
                {
                    Array.Resize(ref stadionArray, stadionArray.Length + 1);
                    stadionArray[stadionArray.Length - 1] = neuerVerein;
                    comboBoxFilterStadion.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseGroundHoppingEntrys.Stadt].ToString();

                if (misc.isNotInList(stadtArray, neuerVerein))
                {
                    Array.Resize(ref stadtArray, stadtArray.Length + 1);
                    stadtArray[stadtArray.Length - 1] = neuerVerein;
                    comboBoxFilterStadt.Items.Add(neuerVerein);
                }

                neuerVerein = reader[(int)DataBaseGroundHoppingEntrys.Land].ToString();

                if (misc.isNotInList(landArray, neuerVerein))
                {
                    Array.Resize(ref landArray, landArray.Length + 1);
                    landArray[landArray.Length - 1] = neuerVerein;
                    comboBoxFilterLand.Items.Add(neuerVerein);

                    //Länderspielpunkte inkrementieren
                    mCountryCounter++;
                }

                neuerVerein = reader[(int)DataBaseGroundHoppingEntrys.Bundesland].ToString();

                if (misc.isNotInList(bundeslandArray, neuerVerein))
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

            comboBoxHeimmanschaft.AutoCompleteCustomSource = sourceManschaften;
            comboBoxHeimmanschaft.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxHeimmanschaft.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxGastmanschaft.AutoCompleteCustomSource = sourceManschaften;
            comboBoxGastmanschaft.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxGastmanschaft.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxStadion.AutoCompleteCustomSource = sourceStadion;
            textBoxStadion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStadion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxStadt.AutoCompleteCustomSource = sourceStadt;
            textBoxStadt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStadt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxLand.AutoCompleteCustomSource = sourceLand;
            textBoxLand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxLand.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxEntryClub.AutoCompleteCustomSource = sourceManschaften;
            textBoxEntryClub.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxEntryClub.AutoCompleteSource = AutoCompleteSource.CustomSource;

            labelCountryPoints.Text = mCountryCounter.ToString();
            comboBoxHeimmanschaft.SelectedIndex = 0;
            comboBoxGastmanschaft.SelectedIndex = 0;
        }

        /*
         * Click Funktion vom Auslese Button
         */
        private void button2_Click(object sender, EventArgs e)
        {
            readOutTable();
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
                    if (comboBoxFilterHeimManschaft.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.HeimManschaft].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 1:
                    if (comboBoxFilterGastManschaft.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.GastManschaft].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 2:
                    if (comboBoxFilterDatum.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.Datum].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 3:
                    if (comboBoxFilterBundesland.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.Bundesland].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 4:
                    if (comboBoxFilterStadion.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.Stadion].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 5:
                    if (comboBoxFilterStadt.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.Stadt].ToString())
                    {
                        row[i] = reader[i];
                        addedToDataGridView = true;
                    }
                    break;
                case 6:
                    if (comboBoxFilterLand.SelectedItem.ToString() == reader[(int)DataBaseGroundHoppingEntrys.Land].ToString())
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
            checkBoxFilterEnable.Checked = false;

            if (comboBoxHeimmanschaft.SelectedIndex == -1
                || comboBoxGastmanschaft.SelectedIndex == -1)
            {
                string message = "Falsche Eingabe der Daten ";
                string caption = "Falsche Eingabe der Daten ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                }
                return;
            }

            mSql.CommandText = "insert into groundHooping(Heimmanschaft, Gastmanschaft, Datum, Stadion, Stadt, Land, Ergebnis, Bundesland)" +
                   " values('" + comboBoxHeimmanschaft.SelectedItem.ToString() + "', '"
                              + comboBoxGastmanschaft.SelectedItem.ToString() + "', '"
                              + dateTimePickerDate.Text + "', '"
                              + textBoxStadion.Text + "', '"
                              + textBoxStadt.Text + "', '"
                              + textBoxLand.Text + "', '"
                              + textBoxErgebnis.Text + "', '"
                              + comboBoxBundesland.SelectedItem.ToString() + "');";
            mSql.ExecuteNonQuery();

            label8.Text = comboBoxBundesland.SelectedItem.ToString();

            if (comboBoxHeimmanschaft.SelectedItem.ToString().ToLower() == "1.fc köln"
                || comboBoxGastmanschaft.SelectedItem.ToString().ToLower() == "1.fc köln")
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

            readOutDataBaseAndInitialAutoComplete();
            readOutTable();
        }

        /*
         * Funktion zum Schliessen der Anwendung
         * ACHTUNG: hier muss auch der zugriff der geöffneten Datenbank wieder geschlossen werden
         */
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mCon.Close();
            Close();
        }

        /*
         * Export Funktion 
         * Hier wird eine Datei gespeichert im CSV Format
         */
        private void exportNachCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = mSql.ExecuteReader();

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

        //öffnen des Über Pop Ups
        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about mAbout = new about();

            if (mAbout.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //tue etwas auf der Datenbank
        private void doSomething(string q)
        {
            mSql.CommandText = q;
            mSql.ExecuteNonQuery();
            readOutTable();
            readOutDataBaseAndInitialAutoComplete();

        }


        //lösche aktuelle Zeile
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;

            string q = "delete from groundHooping where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);
        }

        //lese komplette daten bank aus
        public void readOutTable()
        {
            mSql.CommandText = "select * from groundHooping;";
            OleDbDataReader reader = mSql.ExecuteReader();
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
                    if (checkBoxFilterEnable.Checked == true)
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
                if (addedToDataGridView == true)
                {
                    dataGridView1.Rows.Add(row);
                }

            }
            reader.Close();
            checkBoxFilterEnable.Checked = false;
        }

        //wenn die erste Spalte nicht null ist können wir nicht löschen und nicht ändern
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                buttonDelete.Enabled = false;
                buttonChange.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
                buttonChange.Enabled = true;
            }

            
        }

        //ändere daten der aktuell angewählten zeile
        private void buttonChange_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;

            string q = "update groundHooping set Heimmanschaft='" + comboBoxHeimmanschaft.SelectedItem.ToString()
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Gastmanschaft='" + comboBoxGastmanschaft.SelectedItem.ToString()
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Datum='" + dateTimePickerDate.Text
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Stadion='" + textBoxStadion.Text
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Stadt='" + textBoxStadt.Text
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Land='" + textBoxLand.Text
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Ergebnis='" + textBoxErgebnis.Text
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);

            q = "update groundHooping set Bundesland='" + comboBoxBundesland.SelectedItem.ToString()
                + "'where id=" + dataGridView1[columnIndex, rowIndex].Value.ToString();
            doSomething(q);
        }

        private void metroButtonReadOut_Click(object sender, EventArgs e)
        {
            readOutTable();
        }

        private void buttonSaveClub_Click(object sender, EventArgs e)
        {
            if (textBoxEntryClub.Text != String.Empty
                && comboBoxBundeslandEntry.SelectedIndex != -1
                )
            {
                mDataBaseClubEntrys.insertClubToDataBase(textBoxEntryClub.Text, comboBoxBundeslandEntry.SelectedIndex);
                mDataBaseClubEntrys.readClubList(ref dataGridView2);
                readOutTable();
                readOutDataBaseAndInitialAutoComplete();
            }
        }

        private void comboBoxHeimmanschaft_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSql.CommandText = "select * from Vereine;";
            OleDbDataReader reader = mSql.ExecuteReader();

            //Daten aus der Datenbank anzeigen
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                {

                    if(reader[(int)DataBaseClubEntrys.Club].ToString() == comboBoxHeimmanschaft.SelectedItem.ToString())
                    {
                        comboBoxBundesland.SelectedIndex = (int)reader[(int)DataBaseClubEntrys.Bundesland];
                    }
                }
            }
            reader.Close();
        }

        private void buttonReadOutClub_Click(object sender, EventArgs e)
        {
            mDataBaseClubEntrys.readClubList(ref dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {                                  
            textBoxClubChange.Text = dataGridView2[1, e.RowIndex].Value.ToString();
            comboBoxBundeslandChange.SelectedIndex = (int)dataGridView2[2, e.RowIndex].Value;
        }

        private void buttonChangeClub_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            int columnIndex = dataGridView2.CurrentCell.ColumnIndex;

            mDataBaseClubEntrys.changeClubEntry(textBoxClubChange.Text,
                                                (int)comboBoxBundeslandChange.SelectedIndex,
                                                dataGridView2[columnIndex, rowIndex].Value.ToString());
            doSomething(q);
            mDataBaseClubEntrys.readClubList(ref dataGridView2);
        }
    }
}
