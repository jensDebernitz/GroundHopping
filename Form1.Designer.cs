namespace GroundHopping
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStadt = new System.Windows.Forms.TextBox();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.textBoxStadion = new System.Windows.Forms.TextBox();
            this.textBoxGastmanschaft = new System.Windows.Forms.TextBox();
            this.textBoxHeimmanschaft = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNachCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBundesland = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFilterEnable = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxFilterTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterLand = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterStadt = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterStadion = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterBundesland = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterDatum = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterGastManschaft = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterHeimManschaft = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelCountryPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ergebnis";
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Location = new System.Drawing.Point(488, 97);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(100, 20);
            this.textBoxErgebnis.TabIndex = 31;
            this.textBoxErgebnis.Text = "1:1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Land";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stadt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stadion";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "MM/dd/yy";
            this.dateTimePickerDate.Location = new System.Drawing.Point(316, 50);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gastmanschaft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Heimmanschaft";
            // 
            // textBoxStadt
            // 
            this.textBoxStadt.Location = new System.Drawing.Point(168, 97);
            this.textBoxStadt.Name = "textBoxStadt";
            this.textBoxStadt.Size = new System.Drawing.Size(145, 20);
            this.textBoxStadt.TabIndex = 22;
            this.textBoxStadt.Text = "Koblenz";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Location = new System.Drawing.Point(319, 97);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(145, 20);
            this.textBoxLand.TabIndex = 21;
            this.textBoxLand.Text = "Deutschland";
            // 
            // textBoxStadion
            // 
            this.textBoxStadion.Location = new System.Drawing.Point(17, 97);
            this.textBoxStadion.Name = "textBoxStadion";
            this.textBoxStadion.Size = new System.Drawing.Size(145, 20);
            this.textBoxStadion.TabIndex = 20;
            this.textBoxStadion.Text = "Koblenz";
            // 
            // textBoxGastmanschaft
            // 
            this.textBoxGastmanschaft.Location = new System.Drawing.Point(165, 50);
            this.textBoxGastmanschaft.Name = "textBoxGastmanschaft";
            this.textBoxGastmanschaft.Size = new System.Drawing.Size(145, 20);
            this.textBoxGastmanschaft.TabIndex = 19;
            this.textBoxGastmanschaft.Text = "Eintracht Frankfurt";
            // 
            // textBoxHeimmanschaft
            // 
            this.textBoxHeimmanschaft.Location = new System.Drawing.Point(14, 50);
            this.textBoxHeimmanschaft.Name = "textBoxHeimmanschaft";
            this.textBoxHeimmanschaft.Size = new System.Drawing.Size(145, 20);
            this.textBoxHeimmanschaft.TabIndex = 18;
            this.textBoxHeimmanschaft.Text = "Tus Koblenz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 193);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportierenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // exportierenToolStripMenuItem
            // 
            this.exportierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportNachCSVToolStripMenuItem});
            this.exportierenToolStripMenuItem.Name = "exportierenToolStripMenuItem";
            this.exportierenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exportierenToolStripMenuItem.Text = "Exportieren";
            // 
            // exportNachCSVToolStripMenuItem
            // 
            this.exportNachCSVToolStripMenuItem.Name = "exportNachCSVToolStripMenuItem";
            this.exportNachCSVToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportNachCSVToolStripMenuItem.Text = "Export nach CSV";
            this.exportNachCSVToolStripMenuItem.Click += new System.EventHandler(this.exportNachCSVToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.überToolStripMenuItem.Text = "Info über Ground Hopping";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxBundesland);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxErgebnis);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxStadt);
            this.groupBox1.Controls.Add(this.textBoxLand);
            this.groupBox1.Controls.Add(this.textBoxStadion);
            this.groupBox1.Controls.Add(this.textBoxGastmanschaft);
            this.groupBox1.Controls.Add(this.textBoxHeimmanschaft);
            this.groupBox1.Location = new System.Drawing.Point(184, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 171);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partie Eingeben";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Bundesland";
            // 
            // comboBoxBundesland
            // 
            this.comboBoxBundesland.DisplayMember = "11";
            this.comboBoxBundesland.FormattingEnabled = true;
            this.comboBoxBundesland.Items.AddRange(new object[] {
            "kein Deutschland",
            "Baden-Württemberg",
            "Bayern",
            "Berlin",
            "Brandenburg",
            "Bremen",
            "Hamburg",
            "Hessen",
            "Mecklenburg - Vorpommern",
            "Niedersachsen",
            "Nordrhein - Westfalen",
            "Rheinland - Pfalz",
            "Saarland",
            "Sachsen - Anhalt",
            "Schleswig - Holstein",
            "Thüringen"});
            this.comboBoxBundesland.Location = new System.Drawing.Point(523, 50);
            this.comboBoxBundesland.Name = "comboBoxBundesland";
            this.comboBoxBundesland.Size = new System.Drawing.Size(148, 21);
            this.comboBoxBundesland.TabIndex = 33;
            this.comboBoxBundesland.ValueMember = "11";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFilterEnable);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBoxFilterTo);
            this.groupBox2.Controls.Add(this.comboBoxFilterLand);
            this.groupBox2.Controls.Add(this.comboBoxFilterStadt);
            this.groupBox2.Controls.Add(this.comboBoxFilterStadion);
            this.groupBox2.Controls.Add(this.comboBoxFilterBundesland);
            this.groupBox2.Controls.Add(this.comboBoxFilterDatum);
            this.groupBox2.Controls.Add(this.comboBoxFilterGastManschaft);
            this.groupBox2.Controls.Add(this.comboBoxFilterHeimManschaft);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(184, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 178);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Einstellen";
            // 
            // checkBoxFilterEnable
            // 
            this.checkBoxFilterEnable.AutoSize = true;
            this.checkBoxFilterEnable.Location = new System.Drawing.Point(17, 147);
            this.checkBoxFilterEnable.Name = "checkBoxFilterEnable";
            this.checkBoxFilterEnable.Size = new System.Drawing.Size(107, 17);
            this.checkBoxFilterEnable.TabIndex = 58;
            this.checkBoxFilterEnable.Text = "Filtern anwenden";
            this.checkBoxFilterEnable.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Filtern nach";
            // 
            // comboBoxFilterTo
            // 
            this.comboBoxFilterTo.FormattingEnabled = true;
            this.comboBoxFilterTo.Items.AddRange(new object[] {
            "Heimmanschaft",
            "Gastmanschaft",
            "Datum",
            "Bundesland",
            "Stadion",
            "Stadt",
            "Land"});
            this.comboBoxFilterTo.Location = new System.Drawing.Point(438, 108);
            this.comboBoxFilterTo.Name = "comboBoxFilterTo";
            this.comboBoxFilterTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterTo.TabIndex = 56;
            // 
            // comboBoxFilterLand
            // 
            this.comboBoxFilterLand.FormattingEnabled = true;
            this.comboBoxFilterLand.Location = new System.Drawing.Point(298, 109);
            this.comboBoxFilterLand.Name = "comboBoxFilterLand";
            this.comboBoxFilterLand.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterLand.TabIndex = 55;
            // 
            // comboBoxFilterStadt
            // 
            this.comboBoxFilterStadt.FormattingEnabled = true;
            this.comboBoxFilterStadt.Location = new System.Drawing.Point(150, 109);
            this.comboBoxFilterStadt.Name = "comboBoxFilterStadt";
            this.comboBoxFilterStadt.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterStadt.TabIndex = 54;
            // 
            // comboBoxFilterStadion
            // 
            this.comboBoxFilterStadion.FormattingEnabled = true;
            this.comboBoxFilterStadion.Location = new System.Drawing.Point(14, 109);
            this.comboBoxFilterStadion.Name = "comboBoxFilterStadion";
            this.comboBoxFilterStadion.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterStadion.TabIndex = 53;
            // 
            // comboBoxFilterBundesland
            // 
            this.comboBoxFilterBundesland.FormattingEnabled = true;
            this.comboBoxFilterBundesland.Location = new System.Drawing.Point(438, 43);
            this.comboBoxFilterBundesland.Name = "comboBoxFilterBundesland";
            this.comboBoxFilterBundesland.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterBundesland.TabIndex = 52;
            // 
            // comboBoxFilterDatum
            // 
            this.comboBoxFilterDatum.Enabled = false;
            this.comboBoxFilterDatum.FormattingEnabled = true;
            this.comboBoxFilterDatum.Location = new System.Drawing.Point(298, 43);
            this.comboBoxFilterDatum.Name = "comboBoxFilterDatum";
            this.comboBoxFilterDatum.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterDatum.TabIndex = 51;
            // 
            // comboBoxFilterGastManschaft
            // 
            this.comboBoxFilterGastManschaft.FormattingEnabled = true;
            this.comboBoxFilterGastManschaft.Location = new System.Drawing.Point(150, 43);
            this.comboBoxFilterGastManschaft.Name = "comboBoxFilterGastManschaft";
            this.comboBoxFilterGastManschaft.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterGastManschaft.TabIndex = 50;
            // 
            // comboBoxFilterHeimManschaft
            // 
            this.comboBoxFilterHeimManschaft.FormattingEnabled = true;
            this.comboBoxFilterHeimManschaft.Location = new System.Drawing.Point(17, 43);
            this.comboBoxFilterHeimManschaft.Name = "comboBoxFilterHeimManschaft";
            this.comboBoxFilterHeimManschaft.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilterHeimManschaft.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Land";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Stadt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Stadion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Bundesland";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Datum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Gastmanschaft";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Heimmanschaft";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 641);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Löschen";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(94, 641);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 42;
            this.buttonChange.Text = "Ändern";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Auslesen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCountryPoints);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(923, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 369);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info\'s";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Länderpunkte";
            // 
            // labelCountryPoints
            // 
            this.labelCountryPoints.AutoSize = true;
            this.labelCountryPoints.Location = new System.Drawing.Point(87, 20);
            this.labelCountryPoints.Name = "labelCountryPoints";
            this.labelCountryPoints.Size = new System.Drawing.Size(41, 13);
            this.labelCountryPoints.TabIndex = 1;
            this.labelCountryPoints.Text = "label18";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ground Hopping Studio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStadt;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.TextBox textBoxStadion;
        private System.Windows.Forms.TextBox textBoxGastmanschaft;
        private System.Windows.Forms.TextBox textBoxHeimmanschaft;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNachCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBundesland;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxFilterLand;
        private System.Windows.Forms.ComboBox comboBoxFilterStadt;
        private System.Windows.Forms.ComboBox comboBoxFilterStadion;
        private System.Windows.Forms.ComboBox comboBoxFilterBundesland;
        private System.Windows.Forms.ComboBox comboBoxFilterDatum;
        private System.Windows.Forms.ComboBox comboBoxFilterGastManschaft;
        private System.Windows.Forms.ComboBox comboBoxFilterHeimManschaft;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxFilterEnable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxFilterTo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCountryPoints;
        private System.Windows.Forms.Label label17;
    }
}

