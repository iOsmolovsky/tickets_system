namespace _000kursach
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resLebel = new System.Windows.Forms.Label();
            this.topButton = new System.Windows.Forms.Button();
            this.topList = new System.Windows.Forms.ListBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.ticketGrid = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mounth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.freeButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.BackPanel.Click += new System.EventHandler(this.BackPanel_Click);
            this.BackPanel.MouseEnter += new System.EventHandler(this.BackPanel_MouseEnter);
            this.BackPanel.MouseLeave += new System.EventHandler(this.BackPanel_MouseLeave);
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
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Меню";
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
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.yearBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.resultBox);
            this.panel2.Controls.Add(this.resLebel);
            this.panel2.Controls.Add(this.topButton);
            this.panel2.Controls.Add(this.topList);
            this.panel2.Controls.Add(this.priceButton);
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Location = new System.Drawing.Point(10, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 511);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "BYN";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.OldLace;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(117, 175);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(101, 19);
            this.resultBox.TabIndex = 6;
            // 
            // resLebel
            // 
            this.resLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLebel.Location = new System.Drawing.Point(25, 174);
            this.resLebel.Name = "resLebel";
            this.resLebel.Size = new System.Drawing.Size(127, 36);
            this.resLebel.TabIndex = 5;
            this.resLebel.Text = "Результат:";
            // 
            // topButton
            // 
            this.topButton.BackColor = System.Drawing.Color.Wheat;
            this.topButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topButton.Location = new System.Drawing.Point(31, 431);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(227, 63);
            this.topButton.TabIndex = 4;
            this.topButton.Text = "Самый востребованный транспорт в месяце";
            this.topButton.UseVisualStyleBackColor = false;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // topList
            // 
            this.topList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topList.FormattingEnabled = true;
            this.topList.ItemHeight = 18;
            this.topList.Location = new System.Drawing.Point(31, 223);
            this.topList.Name = "topList";
            this.topList.Size = new System.Drawing.Size(227, 202);
            this.topList.TabIndex = 2;
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.Color.Wheat;
            this.priceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceButton.Location = new System.Drawing.Point(31, 106);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(227, 63);
            this.priceButton.TabIndex = 1;
            this.priceButton.Text = "Рассчитать общий доход за месяц";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown1.Location = new System.Drawing.Point(31, 7);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(227, 40);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "Выбор месяца";
            // 
            // ticketGrid
            // 
            this.ticketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.year,
            this.Mounth,
            this.name,
            this.amount,
            this.price});
            this.ticketGrid.Location = new System.Drawing.Point(321, 47);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.Size = new System.Drawing.Size(567, 403);
            this.ticketGrid.TabIndex = 6;
            // 
            // no
            // 
            this.no.Frozen = true;
            this.no.HeaderText = "Номер";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // year
            // 
            this.year.Frozen = true;
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // Mounth
            // 
            this.Mounth.Frozen = true;
            this.Mounth.HeaderText = "Месяц";
            this.Mounth.Name = "Mounth";
            this.Mounth.ReadOnly = true;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.Frozen = true;
            this.amount.HeaderText = "Количество билетов";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "цена за билет";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.freeButton);
            this.panel3.Controls.Add(this.filterButton);
            this.panel3.Controls.Add(this.searchBox);
            this.panel3.Controls.Add(this.searchButton);
            this.panel3.Location = new System.Drawing.Point(321, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 100);
            this.panel3.TabIndex = 7;
            // 
            // freeButton
            // 
            this.freeButton.BackColor = System.Drawing.Color.Wheat;
            this.freeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.freeButton.Location = new System.Drawing.Point(386, 51);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(112, 26);
            this.freeButton.TabIndex = 22;
            this.freeButton.Text = "Сбросить фильтр";
            this.freeButton.UseVisualStyleBackColor = false;
            this.freeButton.Click += new System.EventHandler(this.freeButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Wheat;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Location = new System.Drawing.Point(386, 24);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(112, 27);
            this.filterButton.TabIndex = 21;
            this.filterButton.Text = "Фильтр по слову";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(69, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 35);
            this.searchBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Wheat;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(268, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 36);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = " Поиск строки";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBox.Location = new System.Drawing.Point(31, 54);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(227, 40);
            this.yearBox.TabIndex = 8;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ticketGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ticketGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mounth;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.ListBox topList;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Label resLebel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button freeButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox yearBox;
    }
}