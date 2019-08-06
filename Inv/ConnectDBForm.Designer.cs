namespace Inv
{
    partial class ConnectDBForm
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
            this.passWordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroConectbtn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.ServerCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.panelConect = new System.Windows.Forms.Panel();
            this.ConectInfo = new System.Windows.Forms.Label();
            this.InitialCatalogTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passWordTB
            // 
            this.passWordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passWordTB.Location = new System.Drawing.Point(196, 245);
            this.passWordTB.Name = "passWordTB";
            this.passWordTB.PasswordChar = '*';
            this.passWordTB.Size = new System.Drawing.Size(453, 31);
            this.passWordTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // metroConectbtn
            // 
            this.metroConectbtn.Location = new System.Drawing.Point(349, 294);
            this.metroConectbtn.Name = "metroConectbtn";
            this.metroConectbtn.Size = new System.Drawing.Size(147, 42);
            this.metroConectbtn.TabIndex = 4;
            this.metroConectbtn.Text = "Подключиться";
            this.metroConectbtn.UseSelectable = true;
            this.metroConectbtn.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(502, 294);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(147, 42);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Отмена";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(196, 294);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(147, 42);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Проверить соединение";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // ServerCB
            // 
            this.ServerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerCB.FormattingEnabled = true;
            this.ServerCB.Location = new System.Drawing.Point(199, 97);
            this.ServerCB.Name = "ServerCB";
            this.ServerCB.Size = new System.Drawing.Size(453, 32);
            this.ServerCB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя сервера:";
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(196, 195);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(453, 31);
            this.LoginTB.TabIndex = 0;
            // 
            // panelConect
            // 
            this.panelConect.Location = new System.Drawing.Point(166, 309);
            this.panelConect.Name = "panelConect";
            this.panelConect.Size = new System.Drawing.Size(14, 14);
            this.panelConect.TabIndex = 11;
            // 
            // ConectInfo
            // 
            this.ConectInfo.AutoSize = true;
            this.ConectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConectInfo.Location = new System.Drawing.Point(199, 392);
            this.ConectInfo.Name = "ConectInfo";
            this.ConectInfo.Size = new System.Drawing.Size(0, 25);
            this.ConectInfo.TabIndex = 12;
            // 
            // InitialCatalogTB
            // 
            this.InitialCatalogTB.Location = new System.Drawing.Point(196, 152);
            this.InitialCatalogTB.Name = "InitialCatalogTB";
            this.InitialCatalogTB.Size = new System.Drawing.Size(453, 19);
            this.InitialCatalogTB.TabIndex = 13;
            // 
            // ConnectDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.InitialCatalogTB);
            this.Controls.Add(this.ConectInfo);
            this.Controls.Add(this.panelConect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerCB);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroConectbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passWordTB);
            this.Controls.Add(this.LoginTB);
            this.Font = new System.Drawing.Font("Archangelsk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ConnectDBForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.Text = "Соединение с базой данных";
            this.Load += new System.EventHandler(this.LogOnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passWordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroConectbtn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ComboBox ServerCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Panel panelConect;
        private System.Windows.Forms.Label ConectInfo;
        private System.Windows.Forms.TextBox InitialCatalogTB;
    }
}