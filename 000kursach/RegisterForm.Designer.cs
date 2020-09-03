namespace _000kursach
{
    partial class RegisterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.redactorButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.regTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.freeButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Управление акаунтами";
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
            // UserGrid
            // 
            this.UserGrid.AllowUserToAddRows = false;
            this.UserGrid.AllowUserToDeleteRows = false;
            this.UserGrid.BackgroundColor = System.Drawing.Color.OldLace;
            this.UserGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_login,
            this.user_password,
            this.role});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserGrid.Location = new System.Drawing.Point(450, 55);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ReadOnly = true;
            this.UserGrid.Size = new System.Drawing.Size(438, 421);
            this.UserGrid.TabIndex = 3;
            this.UserGrid.SelectionChanged += new System.EventHandler(this.UserGrid_SelectionChanged);
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.user_id.HeaderText = "ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_id.Width = 43;
            // 
            // user_login
            // 
            this.user_login.HeaderText = "Login";
            this.user_login.Name = "user_login";
            this.user_login.ReadOnly = true;
            this.user_login.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_login.Width = 146;
            // 
            // user_password
            // 
            this.user_password.HeaderText = "Password";
            this.user_password.Name = "user_password";
            this.user_password.ReadOnly = true;
            this.user_password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_password.Width = 146;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OldLace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.userRadio);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.adminRadio);
            this.panel2.Controls.Add(this.redactorButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.passwordBox);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.loginLabel);
            this.panel2.Controls.Add(this.idBox);
            this.panel2.Controls.Add(this.loginBox);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Location = new System.Drawing.Point(26, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 503);
            this.panel2.TabIndex = 7;
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRadio.Location = new System.Drawing.Point(127, 341);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(75, 29);
            this.userRadio.TabIndex = 14;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "User";
            this.userRadio.UseVisualStyleBackColor = true;
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminRadio.Location = new System.Drawing.Point(18, 341);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(90, 29);
            this.adminRadio.TabIndex = 13;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // redactorButton
            // 
            this.redactorButton.BackColor = System.Drawing.Color.Wheat;
            this.redactorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redactorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redactorButton.Location = new System.Drawing.Point(18, 456);
            this.redactorButton.Name = "redactorButton";
            this.redactorButton.Size = new System.Drawing.Size(213, 34);
            this.redactorButton.TabIndex = 12;
            this.redactorButton.Text = "Редактировать пользователя";
            this.redactorButton.UseVisualStyleBackColor = false;
            this.redactorButton.Click += new System.EventHandler(this.redactorButton_Click);
            this.redactorButton.MouseEnter += new System.EventHandler(this.redactorButton_MouseEnter);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Wheat;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(19, 416);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(213, 34);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить пользователя";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_MouseEnter);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(18, 299);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(212, 37);
            this.passwordBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.OldLace;
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(34, 268);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 29);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Пароль";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Wheat;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.registerButton.Location = new System.Drawing.Point(19, 376);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(213, 34);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Добавить нового пользователя";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.OldLace;
            this.loginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(34, 198);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 29);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Логин";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(19, 159);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(212, 37);
            this.idBox.TabIndex = 3;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(19, 229);
            this.loginBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(212, 37);
            this.loginBox.TabIndex = 4;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.OldLace;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(34, 128);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 29);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "ID";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(3, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 35);
            this.searchBox.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Wheat;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(202, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 36);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = " Поиск строки";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.freeButton);
            this.panel3.Controls.Add(this.filterButton);
            this.panel3.Controls.Add(this.searchBox);
            this.panel3.Controls.Add(this.searchButton);
            this.panel3.Location = new System.Drawing.Point(450, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 76);
            this.panel3.TabIndex = 13;
            // 
            // freeButton
            // 
            this.freeButton.BackColor = System.Drawing.Color.Wheat;
            this.freeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.freeButton.Location = new System.Drawing.Point(320, 33);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(112, 26);
            this.freeButton.TabIndex = 14;
            this.freeButton.Text = "Сбросить фильтр";
            this.freeButton.UseVisualStyleBackColor = false;
            this.freeButton.Click += new System.EventHandler(this.freeButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Wheat;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Location = new System.Drawing.Point(320, 6);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(112, 27);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фильтр по слову";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button redactorButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip regTip;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button freeButton;
    }
}