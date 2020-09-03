namespace _000kursach
{
    partial class DBForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.namebox = new System.Windows.Forms.ComboBox();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.yearBoxEnter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resLebel = new System.Windows.Forms.Label();
            this.topButton = new System.Windows.Forms.Button();
            this.topList = new System.Windows.Forms.ListBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.circularlabel1 = new _000kursach.circularlabel();
            this.ticketbox = new System.Windows.Forms.TextBox();
            this.yearbox = new System.Windows.Forms.TextBox();
            this.nobox = new System.Windows.Forms.TextBox();
            this.ticketGrid = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.freeButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.free1button = new System.Windows.Forms.Button();
            this.filter1button = new System.Windows.Forms.Button();
            this.search1box = new System.Windows.Forms.TextBox();
            this.search1button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.delete1button = new System.Windows.Forms.Button();
            this.edit1button = new System.Windows.Forms.Button();
            this.insert1button = new System.Windows.Forms.Button();
            this.price1Box = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.name1Box = new System.Windows.Forms.TextBox();
            this.transportGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BackPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 41);
            this.panel1.TabIndex = 3;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Honeydew;
            this.BackPanel.Controls.Add(this.BackButton);
            this.BackPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPanel.Location = new System.Drawing.Point(821, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(38, 37);
            this.BackPanel.TabIndex = 13;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 31);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "←\r\n";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Управление базами данных";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.MistyRose;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(859, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(38, 37);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.namebox);
            this.panel2.Controls.Add(this.domainUpDown2);
            this.panel2.Controls.Add(this.yearBoxEnter);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.resultBox);
            this.panel2.Controls.Add(this.resLebel);
            this.panel2.Controls.Add(this.topButton);
            this.panel2.Controls.Add(this.topList);
            this.panel2.Controls.Add(this.priceButton);
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.insertButton);
            this.panel2.Controls.Add(this.pricebox);
            this.panel2.Controls.Add(this.circularlabel1);
            this.panel2.Controls.Add(this.ticketbox);
            this.panel2.Controls.Add(this.yearbox);
            this.panel2.Controls.Add(this.nobox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 511);
            this.panel2.TabIndex = 4;
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.namebox.FormattingEnabled = true;
            this.namebox.Location = new System.Drawing.Point(5, 149);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(139, 33);
            this.namebox.TabIndex = 24;
            this.namebox.SelectedIndexChanged += new System.EventHandler(this.namebox_SelectedIndexChanged);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown2.Location = new System.Drawing.Point(5, 115);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(140, 30);
            this.domainUpDown2.TabIndex = 23;
            this.domainUpDown2.Text = "Выбор месяца";
            // 
            // yearBoxEnter
            // 
            this.yearBoxEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.yearBoxEnter.Location = new System.Drawing.Point(317, 43);
            this.yearBoxEnter.Name = "yearBoxEnter";
            this.yearBoxEnter.Size = new System.Drawing.Size(70, 30);
            this.yearBoxEnter.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(345, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "BYN";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.OldLace;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(248, 133);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(101, 19);
            this.resultBox.TabIndex = 20;
            // 
            // resLebel
            // 
            this.resLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLebel.Location = new System.Drawing.Point(156, 133);
            this.resLebel.Name = "resLebel";
            this.resLebel.Size = new System.Drawing.Size(98, 36);
            this.resLebel.TabIndex = 19;
            this.resLebel.Text = "Результат:";
            // 
            // topButton
            // 
            this.topButton.BackColor = System.Drawing.Color.Wheat;
            this.topButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topButton.Location = new System.Drawing.Point(160, 422);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(140, 40);
            this.topButton.TabIndex = 18;
            this.topButton.Text = "Самый востребованный транспорт в месяце";
            this.topButton.UseVisualStyleBackColor = false;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // topList
            // 
            this.topList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topList.FormattingEnabled = true;
            this.topList.ItemHeight = 18;
            this.topList.Location = new System.Drawing.Point(160, 172);
            this.topList.Name = "topList";
            this.topList.Size = new System.Drawing.Size(227, 238);
            this.topList.TabIndex = 17;
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.Color.Wheat;
            this.priceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceButton.Location = new System.Drawing.Point(160, 79);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(140, 40);
            this.priceButton.TabIndex = 16;
            this.priceButton.Text = "Рассчитать общий доход за месяц";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown1.Location = new System.Drawing.Point(160, 43);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(151, 30);
            this.domainUpDown1.TabIndex = 15;
            this.domainUpDown1.Text = "Выбор месяца";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Wheat;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.refreshButton.Location = new System.Drawing.Point(5, 422);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(140, 40);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Wheat;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.Location = new System.Drawing.Point(5, 376);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Wheat;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editButton.Location = new System.Drawing.Point(5, 284);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(140, 40);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Редактировать";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Wheat;
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.insertButton.Location = new System.Drawing.Point(5, 330);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(140, 40);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Добавить";
            this.insertButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pricebox.Location = new System.Drawing.Point(5, 223);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(140, 30);
            this.pricebox.TabIndex = 5;
            this.pricebox.MouseEnter += new System.EventHandler(this.pricebox_MouseEnter);
            // 
            // circularlabel1
            // 
            this.circularlabel1.BackColor = System.Drawing.Color.Wheat;
            this.circularlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularlabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.circularlabel1.Location = new System.Drawing.Point(119, 256);
            this.circularlabel1.Name = "circularlabel1";
            this.circularlabel1.Size = new System.Drawing.Size(25, 25);
            this.circularlabel1.TabIndex = 4;
            this.circularlabel1.Text = "?";
            this.circularlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.circularlabel1.Click += new System.EventHandler(this.circularlabel1_Click);
            // 
            // ticketbox
            // 
            this.ticketbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ticketbox.Location = new System.Drawing.Point(5, 187);
            this.ticketbox.Name = "ticketbox";
            this.ticketbox.Size = new System.Drawing.Size(140, 30);
            this.ticketbox.TabIndex = 3;
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.yearbox.Location = new System.Drawing.Point(5, 79);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(140, 30);
            this.yearbox.TabIndex = 1;
            // 
            // nobox
            // 
            this.nobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nobox.Location = new System.Drawing.Point(5, 43);
            this.nobox.Name = "nobox";
            this.nobox.Size = new System.Drawing.Size(140, 30);
            this.nobox.TabIndex = 0;
            // 
            // ticketGrid
            // 
            this.ticketGrid.AllowUserToAddRows = false;
            this.ticketGrid.AllowUserToDeleteRows = false;
            this.ticketGrid.BackgroundColor = System.Drawing.Color.OldLace;
            this.ticketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.year,
            this.month,
            this.name,
            this.amount,
            this.price});
            this.ticketGrid.Location = new System.Drawing.Point(407, 7);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.ReadOnly = true;
            this.ticketGrid.Size = new System.Drawing.Size(476, 429);
            this.ticketGrid.TabIndex = 5;
            this.ticketGrid.SelectionChanged += new System.EventHandler(this.ticketGrid_SelectionChanged);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No.HeaderText = "Номер";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 66;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.year.Width = 50;
            // 
            // month
            // 
            this.month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.month.HeaderText = "Месяц";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.month.Width = 65;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 82;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "Количество билетов";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.Width = 123;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "Цена за билет";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.freeButton);
            this.panel3.Controls.Add(this.filterButton);
            this.panel3.Controls.Add(this.searchBox);
            this.panel3.Controls.Add(this.searchButton);
            this.panel3.Location = new System.Drawing.Point(407, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 76);
            this.panel3.TabIndex = 6;
            // 
            // freeButton
            // 
            this.freeButton.BackColor = System.Drawing.Color.Wheat;
            this.freeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.freeButton.Location = new System.Drawing.Point(340, 39);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(112, 26);
            this.freeButton.TabIndex = 18;
            this.freeButton.Text = "Сбросить фильтр";
            this.freeButton.UseVisualStyleBackColor = false;
            this.freeButton.Click += new System.EventHandler(this.freeButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Wheat;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Location = new System.Drawing.Point(340, 12);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(112, 27);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Фильтр по слову";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(23, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 35);
            this.searchBox.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Wheat;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(222, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 36);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = " Поиск строки";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 548);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.ticketGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общее";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.idLabel);
            this.tabPage2.Controls.Add(this.delete1button);
            this.tabPage2.Controls.Add(this.edit1button);
            this.tabPage2.Controls.Add(this.insert1button);
            this.tabPage2.Controls.Add(this.price1Box);
            this.tabPage2.Controls.Add(this.idBox);
            this.tabPage2.Controls.Add(this.name1Box);
            this.tabPage2.Controls.Add(this.transportGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Транспорт";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OldLace;
            this.panel4.Controls.Add(this.free1button);
            this.panel4.Controls.Add(this.filter1button);
            this.panel4.Controls.Add(this.search1box);
            this.panel4.Controls.Add(this.search1button);
            this.panel4.Location = new System.Drawing.Point(410, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 76);
            this.panel4.TabIndex = 15;
            // 
            // free1button
            // 
            this.free1button.BackColor = System.Drawing.Color.Wheat;
            this.free1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.free1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.free1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.free1button.Location = new System.Drawing.Point(340, 39);
            this.free1button.Name = "free1button";
            this.free1button.Size = new System.Drawing.Size(112, 26);
            this.free1button.TabIndex = 18;
            this.free1button.Text = "Сбросить фильтр";
            this.free1button.UseVisualStyleBackColor = false;
            this.free1button.Click += new System.EventHandler(this.free1button_Click);
            // 
            // filter1button
            // 
            this.filter1button.BackColor = System.Drawing.Color.Wheat;
            this.filter1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter1button.Location = new System.Drawing.Point(340, 12);
            this.filter1button.Name = "filter1button";
            this.filter1button.Size = new System.Drawing.Size(112, 27);
            this.filter1button.TabIndex = 17;
            this.filter1button.Text = "Фильтр по слову";
            this.filter1button.UseVisualStyleBackColor = false;
            this.filter1button.Click += new System.EventHandler(this.filter1button_Click);
            // 
            // search1box
            // 
            this.search1box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search1box.Location = new System.Drawing.Point(23, 20);
            this.search1box.Name = "search1box";
            this.search1box.Size = new System.Drawing.Size(193, 35);
            this.search1box.TabIndex = 15;
            // 
            // search1button
            // 
            this.search1button.BackColor = System.Drawing.Color.Wheat;
            this.search1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search1button.Location = new System.Drawing.Point(222, 20);
            this.search1button.Name = "search1button";
            this.search1button.Size = new System.Drawing.Size(112, 36);
            this.search1button.TabIndex = 16;
            this.search1button.Text = " Поиск строки";
            this.search1button.UseVisualStyleBackColor = false;
            this.search1button.Click += new System.EventHandler(this.search1button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(119, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Цена за билет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название транспорта";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.OldLace;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(121, 6);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 29);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "ID";
            // 
            // delete1button
            // 
            this.delete1button.BackColor = System.Drawing.Color.Wheat;
            this.delete1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete1button.Location = new System.Drawing.Point(124, 320);
            this.delete1button.Name = "delete1button";
            this.delete1button.Size = new System.Drawing.Size(259, 40);
            this.delete1button.TabIndex = 11;
            this.delete1button.Text = "Удалить";
            this.delete1button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete1button.UseVisualStyleBackColor = false;
            this.delete1button.Click += new System.EventHandler(this.delete1button_Click);
            // 
            // edit1button
            // 
            this.edit1button.BackColor = System.Drawing.Color.Wheat;
            this.edit1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edit1button.Location = new System.Drawing.Point(126, 228);
            this.edit1button.Name = "edit1button";
            this.edit1button.Size = new System.Drawing.Size(259, 40);
            this.edit1button.TabIndex = 10;
            this.edit1button.Text = "Редактировать";
            this.edit1button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edit1button.UseVisualStyleBackColor = false;
            this.edit1button.Click += new System.EventHandler(this.edit1button_Click);
            // 
            // insert1button
            // 
            this.insert1button.BackColor = System.Drawing.Color.Wheat;
            this.insert1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.insert1button.Location = new System.Drawing.Point(126, 274);
            this.insert1button.Name = "insert1button";
            this.insert1button.Size = new System.Drawing.Size(259, 40);
            this.insert1button.TabIndex = 9;
            this.insert1button.Text = "Добавить";
            this.insert1button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert1button.UseVisualStyleBackColor = false;
            this.insert1button.Click += new System.EventHandler(this.insert1button_Click);
            // 
            // price1Box
            // 
            this.price1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.price1Box.Location = new System.Drawing.Point(126, 184);
            this.price1Box.Name = "price1Box";
            this.price1Box.Size = new System.Drawing.Size(259, 38);
            this.price1Box.TabIndex = 4;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.idBox.Location = new System.Drawing.Point(126, 38);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(261, 38);
            this.idBox.TabIndex = 3;
            // 
            // name1Box
            // 
            this.name1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.name1Box.Location = new System.Drawing.Point(124, 111);
            this.name1Box.Name = "name1Box";
            this.name1Box.Size = new System.Drawing.Size(261, 38);
            this.name1Box.TabIndex = 2;
            // 
            // transportGrid
            // 
            this.transportGrid.AllowUserToAddRows = false;
            this.transportGrid.AllowUserToDeleteRows = false;
            this.transportGrid.BackgroundColor = System.Drawing.Color.OldLace;
            this.transportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name1,
            this.price1});
            this.transportGrid.Location = new System.Drawing.Point(468, 6);
            this.transportGrid.Name = "transportGrid";
            this.transportGrid.ReadOnly = true;
            this.transportGrid.Size = new System.Drawing.Size(344, 428);
            this.transportGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name1
            // 
            this.name1.Frozen = true;
            this.name1.HeaderText = "Название";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // price1
            // 
            this.price1.Frozen = true;
            this.price1.HeaderText = "цена за билет";
            this.price1.Name = "price1";
            this.price1.ReadOnly = true;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ticketGrid;
        private System.Windows.Forms.TextBox ticketbox;
        private System.Windows.Forms.TextBox yearbox;
        private System.Windows.Forms.TextBox nobox;
        private circularlabel circularlabel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label resLebel;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.ListBox topList;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button freeButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox yearBoxEnter;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.ComboBox namebox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete1button;
        private System.Windows.Forms.Button edit1button;
        private System.Windows.Forms.Button insert1button;
        private System.Windows.Forms.TextBox price1Box;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox name1Box;
        private System.Windows.Forms.DataGridView transportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button free1button;
        private System.Windows.Forms.Button filter1button;
        private System.Windows.Forms.TextBox search1box;
        private System.Windows.Forms.Button search1button;
    }
}