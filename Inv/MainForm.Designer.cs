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
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // invintarizationDataSet1
            // 
            this.invintarizationDataSet1.DataSetName = "InvintarizationDataSet";
            this.invintarizationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 542);
            this.Name = "MainForm";
            this.Text = "Инвинтаризация";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InvintarizationDataSet invintarizationDataSet1;
    }
}