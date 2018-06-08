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
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.Location = new System.Drawing.Point(237, 184);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(170, 72);
            this.btn_NewUser.TabIndex = 0;
            this.btn_NewUser.Text = "Нов корисник? ";
            this.btn_NewUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добредојдовте во нашето Казино Тројал";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(428, 184);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(170, 72);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Најава";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Controls.Add(this.btn_Close);
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Controls.Add(this.btn_Login);
            this.panel_Main.Controls.Add(this.btn_NewUser);
            this.panel_Main.Location = new System.Drawing.Point(99, 116);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(800, 400);
            this.panel_Main.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(385, 359);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(102, 41);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Излез";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_GameProject.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 772);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Game Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_Close;
    }
}

