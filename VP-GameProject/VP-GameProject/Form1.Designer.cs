namespace VP_GameProject
{
    partial class Form1
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
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_LoggedIn = new System.Windows.Forms.Panel();
            this.btn_addMoney = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel_Games = new System.Windows.Forms.Panel();
            this.btn_game3 = new System.Windows.Forms.Button();
            this.btn_game2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_game1 = new System.Windows.Forms.Button();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            this.panel_LoggedIn.SuspendLayout();
            this.panel_Games.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_NewUser.FlatAppearance.BorderSize = 4;
            this.btn_NewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_NewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewUser.Location = new System.Drawing.Point(407, 171);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(224, 84);
            this.btn_NewUser.TabIndex = 0;
            this.btn_NewUser.Text = "Register";
            this.btn_NewUser.UseVisualStyleBackColor = false;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(564, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to your Future Casino";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Login.FlatAppearance.BorderSize = 4;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(158, 171);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(228, 84);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Controls.Add(this.btn_Login);
            this.panel_Main.Controls.Add(this.btn_NewUser);
            this.panel_Main.Location = new System.Drawing.Point(102, -5);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(800, 270);
            this.panel_Main.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Location = new System.Drawing.Point(436, 719);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(102, 41);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_LoggedIn
            // 
            this.panel_LoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.panel_LoggedIn.Controls.Add(this.btn_addMoney);
            this.panel_LoggedIn.Controls.Add(this.btn_Logout);
            this.panel_LoggedIn.Controls.Add(this.panel_Games);
            this.panel_LoggedIn.Controls.Add(this.lbl_Money);
            this.panel_LoggedIn.Controls.Add(this.lbl_Welcome);
            this.panel_LoggedIn.Location = new System.Drawing.Point(102, 271);
            this.panel_LoggedIn.Name = "panel_LoggedIn";
            this.panel_LoggedIn.Size = new System.Drawing.Size(800, 429);
            this.panel_LoggedIn.TabIndex = 4;
            // 
            // btn_addMoney
            // 
            this.btn_addMoney.BackColor = System.Drawing.Color.Black;
            this.btn_addMoney.FlatAppearance.BorderSize = 0;
            this.btn_addMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addMoney.Location = new System.Drawing.Point(621, 98);
            this.btn_addMoney.Name = "btn_addMoney";
            this.btn_addMoney.Size = new System.Drawing.Size(102, 41);
            this.btn_addMoney.TabIndex = 6;
            this.btn_addMoney.Text = "Add money";
            this.btn_addMoney.UseVisualStyleBackColor = false;
            this.btn_addMoney.Click += new System.EventHandler(this.btn_addMoney_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Black;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Logout.Location = new System.Drawing.Point(518, 146);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(102, 41);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // panel_Games
            // 
            this.panel_Games.Controls.Add(this.btn_game3);
            this.panel_Games.Controls.Add(this.btn_game2);
            this.panel_Games.Controls.Add(this.label2);
            this.panel_Games.Controls.Add(this.btn_game1);
            this.panel_Games.Location = new System.Drawing.Point(30, 193);
            this.panel_Games.Name = "panel_Games";
            this.panel_Games.Size = new System.Drawing.Size(724, 188);
            this.panel_Games.TabIndex = 5;
            // 
            // btn_game3
            // 
            this.btn_game3.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_game3.FlatAppearance.BorderSize = 4;
            this.btn_game3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_game3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_game3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_game3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game3.Location = new System.Drawing.Point(479, 92);
            this.btn_game3.Name = "btn_game3";
            this.btn_game3.Size = new System.Drawing.Size(228, 84);
            this.btn_game3.TabIndex = 8;
            this.btn_game3.Text = "Game 3 Janaki";
            this.btn_game3.UseVisualStyleBackColor = false;
            this.btn_game3.Click += new System.EventHandler(this.btn_game3_Click);
            // 
            // btn_game2
            // 
            this.btn_game2.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_game2.FlatAppearance.BorderSize = 4;
            this.btn_game2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_game2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_game2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_game2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game2.Location = new System.Drawing.Point(234, 92);
            this.btn_game2.Name = "btn_game2";
            this.btn_game2.Size = new System.Drawing.Size(239, 84);
            this.btn_game2.TabIndex = 7;
            this.btn_game2.Text = "Game2 Filip";
            this.btn_game2.UseVisualStyleBackColor = false;
            this.btn_game2.Click += new System.EventHandler(this.btn_game2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(710, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Let\'s make some money. Choose game:";
            // 
            // btn_game1
            // 
            this.btn_game1.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_game1.FlatAppearance.BorderSize = 4;
            this.btn_game1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_game1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_game1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_game1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game1.Location = new System.Drawing.Point(0, 92);
            this.btn_game1.Name = "btn_game1";
            this.btn_game1.Size = new System.Drawing.Size(228, 84);
            this.btn_game1.TabIndex = 3;
            this.btn_game1.Text = "CrazyRoulette";
            this.btn_game1.UseVisualStyleBackColor = false;
            this.btn_game1.Click += new System.EventHandler(this.btn_game1_Click);
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.BackColor = System.Drawing.Color.Black;
            this.lbl_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Money.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Money.Location = new System.Drawing.Point(195, 136);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Money.Size = new System.Drawing.Size(186, 54);
            this.lbl_Money.TabIndex = 4;
            this.lbl_Money.Text = "Money: $";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.Color.Black;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Welcome.Location = new System.Drawing.Point(173, 41);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Welcome.Size = new System.Drawing.Size(411, 54);
            this.lbl_Welcome.TabIndex = 3;
            this.lbl_Welcome.Text = "{User}, Welcome Back";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_GameProject.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 772);
            this.Controls.Add(this.panel_LoggedIn);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Game Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.panel_LoggedIn.ResumeLayout(false);
            this.panel_LoggedIn.PerformLayout();
            this.panel_Games.ResumeLayout(false);
            this.panel_Games.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel_LoggedIn;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Panel panel_Games;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_game1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_game3;
        private System.Windows.Forms.Button btn_game2;
        private System.Windows.Forms.Button btn_addMoney;
    }
}

