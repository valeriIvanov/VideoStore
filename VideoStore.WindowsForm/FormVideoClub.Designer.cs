namespace VideoStore.PresentationLayer
{
    partial class FormVideoClub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlVideoClub = new System.Windows.Forms.TabControl();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.buttonShowAllMovies = new System.Windows.Forms.Button();
            this.buttonSerchMovieName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMovies = new System.Windows.Forms.GroupBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAdult = new System.Windows.Forms.CheckBox();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonInsertMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSerchPerson = new System.Windows.Forms.Button();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPersonID = new System.Windows.Forms.TextBox();
            this.labelPeopleName = new System.Windows.Forms.Label();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.labelPeopleYear = new System.Windows.Forms.Label();
            this.buttonUpdatePerson = new System.Windows.Forms.Button();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.buttonInsertPerson = new System.Windows.Forms.Button();
            this.textBoxPersonYear = new System.Windows.Forms.TextBox();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOderPersonName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSechOrderByPersonName = new System.Windows.Forms.Button();
            this.buttonInsertOrder = new System.Windows.Forms.Button();
            this.textBoxOrderMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewОverdueOrders = new System.Windows.Forms.DataGridView();
            this.buttonAllOrders = new System.Windows.Forms.Button();
            this.tabControlVideoClub.SuspendLayout();
            this.tabPageMovies.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.groupBoxMovies.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОverdueOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVideoClub
            // 
            this.tabControlVideoClub.Controls.Add(this.tabPageMovies);
            this.tabControlVideoClub.Controls.Add(this.tabPageCustomer);
            this.tabControlVideoClub.Controls.Add(this.tabPageRequest);
            this.tabControlVideoClub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVideoClub.Location = new System.Drawing.Point(0, 0);
            this.tabControlVideoClub.Name = "tabControlVideoClub";
            this.tabControlVideoClub.SelectedIndex = 0;
            this.tabControlVideoClub.Size = new System.Drawing.Size(1171, 489);
            this.tabControlVideoClub.TabIndex = 1;
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPageMovies.Controls.Add(this.groupBox2);
            this.tabPageMovies.Controls.Add(this.groupBoxMovies);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(1163, 463);
            this.tabPageMovies.TabIndex = 0;
            this.tabPageMovies.Text = "Филми";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dataGridViewMovie);
            this.groupBox2.Controls.Add(this.buttonShowAllMovies);
            this.groupBox2.Controls.Add(this.buttonSerchMovieName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(424, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 449);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(413, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Всички филми";
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovie.Size = new System.Drawing.Size(679, 378);
            this.dataGridViewMovie.TabIndex = 17;
            this.dataGridViewMovie.TabStop = false;
            this.dataGridViewMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellClick);
            this.dataGridViewMovie.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewMovie_DataBindingComplete);
            // 
            // buttonShowAllMovies
            // 
            this.buttonShowAllMovies.Location = new System.Drawing.Point(416, 422);
            this.buttonShowAllMovies.Name = "buttonShowAllMovies";
            this.buttonShowAllMovies.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAllMovies.TabIndex = 23;
            this.buttonShowAllMovies.Text = "Изведи";
            this.buttonShowAllMovies.UseVisualStyleBackColor = true;
            this.buttonShowAllMovies.Click += new System.EventHandler(this.buttonShowAllMovies_Click);
            // 
            // buttonSerchMovieName
            // 
            this.buttonSerchMovieName.Location = new System.Drawing.Point(254, 422);
            this.buttonSerchMovieName.Name = "buttonSerchMovieName";
            this.buttonSerchMovieName.Size = new System.Drawing.Size(75, 23);
            this.buttonSerchMovieName.TabIndex = 18;
            this.buttonSerchMovieName.Text = "Търси";
            this.buttonSerchMovieName.UseVisualStyleBackColor = true;
            this.buttonSerchMovieName.Click += new System.EventHandler(this.buttonSerchMovieName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(251, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Търси по име";
            // 
            // groupBoxMovies
            // 
            this.groupBoxMovies.Controls.Add(this.textBoxMovieID);
            this.groupBoxMovies.Controls.Add(this.comboBoxGenre);
            this.groupBoxMovies.Controls.Add(this.label3);
            this.groupBoxMovies.Controls.Add(this.textBoxMovieName);
            this.groupBoxMovies.Controls.Add(this.labelMovieName);
            this.groupBoxMovies.Controls.Add(this.label4);
            this.groupBoxMovies.Controls.Add(this.label5);
            this.groupBoxMovies.Controls.Add(this.checkBoxAdult);
            this.groupBoxMovies.Controls.Add(this.buttonUpdateMovie);
            this.groupBoxMovies.Controls.Add(this.buttonInsertMovie);
            this.groupBoxMovies.Controls.Add(this.buttonDeleteMovie);
            this.groupBoxMovies.Controls.Add(this.textBoxDirector);
            this.groupBoxMovies.Controls.Add(this.textBoxPrice);
            this.groupBoxMovies.Location = new System.Drawing.Point(25, 100);
            this.groupBoxMovies.Name = "groupBoxMovies";
            this.groupBoxMovies.Size = new System.Drawing.Size(380, 262);
            this.groupBoxMovies.TabIndex = 24;
            this.groupBoxMovies.TabStop = false;
            this.groupBoxMovies.Text = "Филми";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(327, 40);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(39, 20);
            this.textBoxMovieID.TabIndex = 18;
            this.textBoxMovieID.TabStop = false;
            this.textBoxMovieID.Visible = false;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(112, 120);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(208, 21);
            this.comboBoxGenre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Режисьор";
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(112, 40);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(209, 20);
            this.textBoxMovieName.TabIndex = 1;
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(77, 43);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(29, 13);
            this.labelMovieName.TabIndex = 0;
            this.labelMovieName.Text = "Име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Жанр";
            // 
            // checkBoxAdult
            // 
            this.checkBoxAdult.AutoSize = true;
            this.checkBoxAdult.Location = new System.Drawing.Point(224, 164);
            this.checkBoxAdult.Name = "checkBoxAdult";
            this.checkBoxAdult.Size = new System.Drawing.Size(96, 17);
            this.checkBoxAdult.TabIndex = 6;
            this.checkBoxAdult.Text = "За възрастни";
            this.checkBoxAdult.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.Location = new System.Drawing.Point(149, 199);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMovie.TabIndex = 8;
            this.buttonUpdateMovie.Text = "Промени";
            this.buttonUpdateMovie.UseVisualStyleBackColor = true;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonInsertMovie
            // 
            this.buttonInsertMovie.Location = new System.Drawing.Point(34, 199);
            this.buttonInsertMovie.Name = "buttonInsertMovie";
            this.buttonInsertMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertMovie.TabIndex = 7;
            this.buttonInsertMovie.Text = "Въведи";
            this.buttonInsertMovie.UseVisualStyleBackColor = true;
            this.buttonInsertMovie.Click += new System.EventHandler(this.buttonInsertMovie_Click);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(264, 199);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMovie.TabIndex = 10;
            this.buttonDeleteMovie.Text = "Премахни";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(112, 80);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(209, 20);
            this.textBoxDirector.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(112, 161);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(88, 20);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPageCustomer.Controls.Add(this.panel2);
            this.tabPageCustomer.Controls.Add(this.panel1);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(1163, 463);
            this.tabPageCustomer.TabIndex = 1;
            this.tabPageCustomer.Text = "Клиенти";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSerchPerson);
            this.panel2.Controls.Add(this.dataGridViewPerson);
            this.panel2.Location = new System.Drawing.Point(373, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 449);
            this.panel2.TabIndex = 1;
            // 
            // buttonSerchPerson
            // 
            this.buttonSerchPerson.Location = new System.Drawing.Point(356, 423);
            this.buttonSerchPerson.Name = "buttonSerchPerson";
            this.buttonSerchPerson.Size = new System.Drawing.Size(93, 23);
            this.buttonSerchPerson.TabIndex = 17;
            this.buttonSerchPerson.Text = "Търси по име";
            this.buttonSerchPerson.UseVisualStyleBackColor = true;
            this.buttonSerchPerson.Click += new System.EventHandler(this.buttonSerchPerson_Click);
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Location = new System.Drawing.Point(14, 17);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.Size = new System.Drawing.Size(749, 386);
            this.dataGridViewPerson.TabIndex = 0;
            this.dataGridViewPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerson_CellClick);
            this.dataGridViewPerson.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewPerson_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 449);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPersonID);
            this.groupBox1.Controls.Add(this.labelPeopleName);
            this.groupBox1.Controls.Add(this.buttonDeletePerson);
            this.groupBox1.Controls.Add(this.labelPeopleYear);
            this.groupBox1.Controls.Add(this.buttonUpdatePerson);
            this.groupBox1.Controls.Add(this.textBoxPersonName);
            this.groupBox1.Controls.Add(this.buttonInsertPerson);
            this.groupBox1.Controls.Add(this.textBoxPersonYear);
            this.groupBox1.Location = new System.Drawing.Point(13, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 166);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // textBoxPersonID
            // 
            this.textBoxPersonID.Location = new System.Drawing.Point(294, 28);
            this.textBoxPersonID.Name = "textBoxPersonID";
            this.textBoxPersonID.Size = new System.Drawing.Size(14, 20);
            this.textBoxPersonID.TabIndex = 7;
            this.textBoxPersonID.TabStop = false;
            this.textBoxPersonID.Visible = false;
            // 
            // labelPeopleName
            // 
            this.labelPeopleName.AutoSize = true;
            this.labelPeopleName.Location = new System.Drawing.Point(40, 31);
            this.labelPeopleName.Name = "labelPeopleName";
            this.labelPeopleName.Size = new System.Drawing.Size(29, 13);
            this.labelPeopleName.TabIndex = 0;
            this.labelPeopleName.Text = "Име";
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(213, 123);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePerson.TabIndex = 6;
            this.buttonDeletePerson.Text = "Delete";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // labelPeopleYear
            // 
            this.labelPeopleYear.AutoSize = true;
            this.labelPeopleYear.Location = new System.Drawing.Point(26, 78);
            this.labelPeopleYear.Name = "labelPeopleYear";
            this.labelPeopleYear.Size = new System.Drawing.Size(43, 13);
            this.labelPeopleYear.TabIndex = 2;
            this.labelPeopleYear.Text = "Година";
            // 
            // buttonUpdatePerson
            // 
            this.buttonUpdatePerson.Location = new System.Drawing.Point(121, 123);
            this.buttonUpdatePerson.Name = "buttonUpdatePerson";
            this.buttonUpdatePerson.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdatePerson.TabIndex = 5;
            this.buttonUpdatePerson.Text = "Update";
            this.buttonUpdatePerson.UseVisualStyleBackColor = true;
            this.buttonUpdatePerson.Click += new System.EventHandler(this.buttonUpdatePerson_Click);
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(79, 28);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(209, 20);
            this.textBoxPersonName.TabIndex = 2;
            // 
            // buttonInsertPerson
            // 
            this.buttonInsertPerson.Location = new System.Drawing.Point(27, 123);
            this.buttonInsertPerson.Name = "buttonInsertPerson";
            this.buttonInsertPerson.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertPerson.TabIndex = 4;
            this.buttonInsertPerson.Text = "Insert";
            this.buttonInsertPerson.UseVisualStyleBackColor = true;
            this.buttonInsertPerson.Click += new System.EventHandler(this.buttonInsertPerson_Click);
            // 
            // textBoxPersonYear
            // 
            this.textBoxPersonYear.Location = new System.Drawing.Point(79, 75);
            this.textBoxPersonYear.Name = "textBoxPersonYear";
            this.textBoxPersonYear.Size = new System.Drawing.Size(209, 20);
            this.textBoxPersonYear.TabIndex = 3;
            this.textBoxPersonYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonYear_KeyPress);
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPageRequest.Controls.Add(this.buttonAllOrders);
            this.tabPageRequest.Controls.Add(this.groupBox4);
            this.tabPageRequest.Controls.Add(this.groupBox3);
            this.tabPageRequest.Controls.Add(this.dataGridViewОverdueOrders);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Size = new System.Drawing.Size(1163, 463);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Заявки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeleteOrder);
            this.groupBox4.Controls.Add(this.textBoxOrderNumber);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(31, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 174);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изтриване на заявка";
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(79, 95);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOrder.TabIndex = 6;
            this.buttonDeleteOrder.Text = "Изтрии";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(79, 57);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(209, 20);
            this.textBoxOrderNumber.TabIndex = 5;
            this.textBoxOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderNumber_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "N# заявка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOderPersonName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonSechOrderByPersonName);
            this.groupBox3.Controls.Add(this.buttonInsertOrder);
            this.groupBox3.Controls.Add(this.textBoxOrderMovieName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(31, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 174);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заемане на филм";
            // 
            // textBoxOderPersonName
            // 
            this.textBoxOderPersonName.Location = new System.Drawing.Point(79, 38);
            this.textBoxOderPersonName.Name = "textBoxOderPersonName";
            this.textBoxOderPersonName.Size = new System.Drawing.Size(209, 20);
            this.textBoxOderPersonName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Клиент";
            // 
            // buttonSechOrderByPersonName
            // 
            this.buttonSechOrderByPersonName.Location = new System.Drawing.Point(181, 114);
            this.buttonSechOrderByPersonName.Name = "buttonSechOrderByPersonName";
            this.buttonSechOrderByPersonName.Size = new System.Drawing.Size(75, 23);
            this.buttonSechOrderByPersonName.TabIndex = 4;
            this.buttonSechOrderByPersonName.Text = "Търси име";
            this.buttonSechOrderByPersonName.UseVisualStyleBackColor = true;
            this.buttonSechOrderByPersonName.Click += new System.EventHandler(this.buttonSechOrderByPersonName_Click);
            // 
            // buttonInsertOrder
            // 
            this.buttonInsertOrder.Location = new System.Drawing.Point(79, 114);
            this.buttonInsertOrder.Name = "buttonInsertOrder";
            this.buttonInsertOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertOrder.TabIndex = 3;
            this.buttonInsertOrder.Text = "Въведи";
            this.buttonInsertOrder.UseVisualStyleBackColor = true;
            this.buttonInsertOrder.Click += new System.EventHandler(this.buttonInsertOrder_Click);
            // 
            // textBoxOrderMovieName
            // 
            this.textBoxOrderMovieName.Location = new System.Drawing.Point(79, 76);
            this.textBoxOrderMovieName.Name = "textBoxOrderMovieName";
            this.textBoxOrderMovieName.Size = new System.Drawing.Size(209, 20);
            this.textBoxOrderMovieName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Филм";
            // 
            // dataGridViewОverdueOrders
            // 
            this.dataGridViewОverdueOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewОverdueOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewОverdueOrders.Location = new System.Drawing.Point(405, 22);
            this.dataGridViewОverdueOrders.Name = "dataGridViewОverdueOrders";
            this.dataGridViewОverdueOrders.Size = new System.Drawing.Size(729, 394);
            this.dataGridViewОverdueOrders.TabIndex = 9;
            this.dataGridViewОverdueOrders.TabStop = false;
            this.dataGridViewОverdueOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewОverdueOrders_CellClick);
            this.dataGridViewОverdueOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewОverdueOrders_DataBindingComplete);
            // 
            // buttonAllOrders
            // 
            this.buttonAllOrders.Location = new System.Drawing.Point(734, 431);
            this.buttonAllOrders.Name = "buttonAllOrders";
            this.buttonAllOrders.Size = new System.Drawing.Size(92, 24);
            this.buttonAllOrders.TabIndex = 20;
            this.buttonAllOrders.Text = "Всички заявки";
            this.buttonAllOrders.UseVisualStyleBackColor = true;
            this.buttonAllOrders.Click += new System.EventHandler(this.buttonAllOrders_Click);
            // 
            // FormVideoClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 489);
            this.Controls.Add(this.tabControlVideoClub);
            this.Name = "FormVideoClub";
            this.Text = "Видео Клуб";
            this.tabControlVideoClub.ResumeLayout(false);
            this.tabPageMovies.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.groupBoxMovies.ResumeLayout(false);
            this.groupBoxMovies.PerformLayout();
            this.tabPageCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageRequest.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОverdueOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVideoClub;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonShowAllMovies;
        private System.Windows.Forms.Button buttonSerchMovieName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.GroupBox groupBoxMovies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxAdult;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonInsertMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSerchPerson;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPeopleName;
        private System.Windows.Forms.Label labelPeopleYear;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.TextBox textBoxPersonYear;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Button buttonUpdatePerson;
        private System.Windows.Forms.Button buttonInsertPerson;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.DataGridView dataGridViewОverdueOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSechOrderByPersonName;
        private System.Windows.Forms.Button buttonInsertOrder;
        private System.Windows.Forms.TextBox textBoxOrderMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOderPersonName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textBoxPersonID;
        private System.Windows.Forms.Button buttonAllOrders;
    }
}

