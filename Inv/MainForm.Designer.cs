namespace Inv
{
    partial class MainForm
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
            this.invintarizationDataSet1 = new Inv.InvintarizationDataSet();
            this.RoleLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // invintarizationDataSet1
            // 
            this.invintarizationDataSet1.DataSetName = "InvintarizationDataSet";
            this.invintarizationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RoleLab
            // 
            this.RoleLab.AutoSize = true;
            this.RoleLab.Location = new System.Drawing.Point(32, 69);
            this.RoleLab.Name = "RoleLab";
            this.RoleLab.Size = new System.Drawing.Size(35, 13);
            this.RoleLab.TabIndex = 0;
            this.RoleLab.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 542);
            this.Controls.Add(this.RoleLab);
            this.Name = "MainForm";
            this.Text = "Инвинтаризация";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvintarizationDataSet invintarizationDataSet1;
        private System.Windows.Forms.Label RoleLab;
    }
}