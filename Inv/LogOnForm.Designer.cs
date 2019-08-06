namespace Inv
{
    partial class LogOnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passWordTb = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroCancaleBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Archangelsk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Archangelsk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(222, 116);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(327, 32);
            this.loginTB.TabIndex = 2;
            // 
            // passWordTb
            // 
            this.passWordTb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passWordTb.Location = new System.Drawing.Point(222, 181);
            this.passWordTb.Margin = new System.Windows.Forms.Padding(4);
            this.passWordTb.Name = "passWordTb";
            this.passWordTb.PasswordChar = '*';
            this.passWordTb.Size = new System.Drawing.Size(327, 32);
            this.passWordTb.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(222, 236);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(159, 54);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Войти";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroCancaleBtn
            // 
            this.metroCancaleBtn.Location = new System.Drawing.Point(390, 236);
            this.metroCancaleBtn.Name = "metroCancaleBtn";
            this.metroCancaleBtn.Size = new System.Drawing.Size(159, 54);
            this.metroCancaleBtn.TabIndex = 5;
            this.metroCancaleBtn.Text = "Отмена";
            this.metroCancaleBtn.UseSelectable = true;
            this.metroCancaleBtn.Click += new System.EventHandler(this.MetroCancaleBtn_Click);
            // 
            // LogOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 403);
            this.Controls.Add(this.metroCancaleBtn);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passWordTb);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Archangelsk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogOnForm";
            this.Padding = new System.Windows.Forms.Padding(30, 78, 30, 25);
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LogOn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passWordTb;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroCancaleBtn;
    }
}