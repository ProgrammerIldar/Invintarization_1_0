namespace Inv
{
    partial class CatrigesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusCatrigeCB = new System.Windows.Forms.GroupBox();
            this.CatrigeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusEditCB = new System.Windows.Forms.ComboBox();
            this.catrigeStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invintarizationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invintarizationDataSet = new Inv.InvintarizationDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialNumberCatrigeSearchTB = new System.Windows.Forms.TextBox();
            this.ColorCB = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CatrigeStatusCBSearch = new System.Windows.Forms.ComboBox();
            this.catrigeStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCatrige = new System.Windows.Forms.DataGridView();
            this.SerialNumberCatrigeTB = new System.Windows.Forms.TextBox();
            this.catrigeStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catrigeStatusTableAdapter = new Inv.InvintarizationDataSetTableAdapters.CatrigeStatusTableAdapter();
            this.colorTableAdapter = new Inv.InvintarizationDataSetTableAdapters.ColorTableAdapter();
            this.catrigesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catrigesTableAdapter = new Inv.InvintarizationDataSetTableAdapters.CatrigesTableAdapter();
            this.modelPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelPrinterTableAdapter = new Inv.InvintarizationDataSetTableAdapters.ModelPrinterTableAdapter();
            this.catrigesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catrigesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modelColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelColorsTableAdapter = new Inv.InvintarizationDataSetTableAdapters.ModelColorsTableAdapter();
            this.modelPrinterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firmPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmPrinterTableAdapter = new Inv.InvintarizationDataSetTableAdapters.FirmPrinterTableAdapter();
            this.firmPrinterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catrigesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.PanelColor = new System.Windows.Forms.Panel();
            this.panelColorInfo = new System.Windows.Forms.Panel();
            this.ColorLab = new System.Windows.Forms.Label();
            this.StatusCatrigeCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatrige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelColorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPrinterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmPrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmPrinterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusCatrigeCB
            // 
            this.StatusCatrigeCB.Controls.Add(this.ColorLab);
            this.StatusCatrigeCB.Controls.Add(this.panelColorInfo);
            this.StatusCatrigeCB.Controls.Add(this.CatrigeID);
            this.StatusCatrigeCB.Controls.Add(this.label7);
            this.StatusCatrigeCB.Controls.Add(this.StatusEditCB);
            this.StatusCatrigeCB.Controls.Add(this.label4);
            this.StatusCatrigeCB.Controls.Add(this.button2);
            this.StatusCatrigeCB.Controls.Add(this.saveBtn);
            this.StatusCatrigeCB.Controls.Add(this.groupBox1);
            this.StatusCatrigeCB.Controls.Add(this.SerialNumberCatrigeTB);
            this.StatusCatrigeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusCatrigeCB.Location = new System.Drawing.Point(45, 23);
            this.StatusCatrigeCB.Name = "StatusCatrigeCB";
            this.StatusCatrigeCB.Size = new System.Drawing.Size(986, 1012);
            this.StatusCatrigeCB.TabIndex = 0;
            this.StatusCatrigeCB.TabStop = false;
            this.StatusCatrigeCB.Text = "Редактировать";
            this.StatusCatrigeCB.Enter += new System.EventHandler(this.StatusCatrigeCB_Enter);
            // 
            // CatrigeID
            // 
            this.CatrigeID.AutoSize = true;
            this.CatrigeID.Location = new System.Drawing.Point(215, 25);
            this.CatrigeID.Name = "CatrigeID";
            this.CatrigeID.Size = new System.Drawing.Size(26, 20);
            this.CatrigeID.TabIndex = 21;
            this.CatrigeID.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Статус:";
            // 
            // StatusEditCB
            // 
            this.StatusEditCB.DataSource = this.catrigeStatusBindingSource2;
            this.StatusEditCB.DisplayMember = "StatusName";
            this.StatusEditCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusEditCB.FormattingEnabled = true;
            this.StatusEditCB.Location = new System.Drawing.Point(215, 118);
            this.StatusEditCB.Name = "StatusEditCB";
            this.StatusEditCB.Size = new System.Drawing.Size(497, 32);
            this.StatusEditCB.TabIndex = 19;
            this.StatusEditCB.ValueMember = "CatrigeStatusID";
            this.StatusEditCB.SelectedIndexChanged += new System.EventHandler(this.StatusEditCB_SelectedIndexChanged);
            // 
            // catrigeStatusBindingSource2
            // 
            this.catrigeStatusBindingSource2.DataMember = "CatrigeStatus";
            this.catrigeStatusBindingSource2.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // invintarizationDataSetBindingSource
            // 
            this.invintarizationDataSetBindingSource.DataSource = this.invintarizationDataSet;
            this.invintarizationDataSetBindingSource.Position = 0;
            // 
            // invintarizationDataSet
            // 
            this.invintarizationDataSet.DataSetName = "InvintarizationDataSet";
            this.invintarizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Серийный номер:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(215, 200);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(201, 52);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelColor);
            this.groupBox1.Controls.Add(this.SerialNumberCatrigeSearchTB);
            this.groupBox1.Controls.Add(this.ColorCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.CatrigeStatusCBSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvCatrige);
            this.groupBox1.Location = new System.Drawing.Point(48, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 724);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // SerialNumberCatrigeSearchTB
            // 
            this.SerialNumberCatrigeSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialNumberCatrigeSearchTB.Location = new System.Drawing.Point(220, 28);
            this.SerialNumberCatrigeSearchTB.Name = "SerialNumberCatrigeSearchTB";
            this.SerialNumberCatrigeSearchTB.Size = new System.Drawing.Size(356, 31);
            this.SerialNumberCatrigeSearchTB.TabIndex = 11;
            this.SerialNumberCatrigeSearchTB.TextChanged += new System.EventHandler(this.SerialNumberCatrigeSearchTB_TextChanged);
            // 
            // ColorCB
            // 
            this.ColorCB.DataSource = this.colorBindingSource;
            this.ColorCB.DisplayMember = "ColorName";
            this.ColorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCB.FormattingEnabled = true;
            this.ColorCB.Location = new System.Drawing.Point(220, 128);
            this.ColorCB.Name = "ColorCB";
            this.ColorCB.Size = new System.Drawing.Size(353, 32);
            this.ColorCB.TabIndex = 8;
            this.ColorCB.ValueMember = "ColorID";
            this.ColorCB.SelectedIndexChanged += new System.EventHandler(this.ColorCB_SelectedIndexChanged);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цвет:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(375, 204);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(201, 52);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CatrigeStatusCBSearch
            // 
            this.CatrigeStatusCBSearch.DataSource = this.catrigeStatusBindingSource;
            this.CatrigeStatusCBSearch.DisplayMember = "StatusName";
            this.CatrigeStatusCBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatrigeStatusCBSearch.FormattingEnabled = true;
            this.CatrigeStatusCBSearch.Location = new System.Drawing.Point(220, 77);
            this.CatrigeStatusCBSearch.Name = "CatrigeStatusCBSearch";
            this.CatrigeStatusCBSearch.Size = new System.Drawing.Size(356, 32);
            this.CatrigeStatusCBSearch.TabIndex = 6;
            this.CatrigeStatusCBSearch.ValueMember = "CatrigeStatusID";
            this.CatrigeStatusCBSearch.SelectedIndexChanged += new System.EventHandler(this.CatrigeStatusCBSearch_SelectedIndexChanged);
            // 
            // catrigeStatusBindingSource
            // 
            this.catrigeStatusBindingSource.DataMember = "CatrigeStatus";
            this.catrigeStatusBindingSource.DataSource = this.invintarizationDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Статус:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Серийный номер:";
            // 
            // dgvCatrige
            // 
            this.dgvCatrige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatrige.Location = new System.Drawing.Point(53, 282);
            this.dgvCatrige.Name = "dgvCatrige";
            this.dgvCatrige.Size = new System.Drawing.Size(722, 401);
            this.dgvCatrige.TabIndex = 0;
            this.dgvCatrige.DockChanged += new System.EventHandler(this.DgvCatrige_DockChanged);
            this.dgvCatrige.DoubleClick += new System.EventHandler(this.DgvCatrige_DoubleClick);
            // 
            // SerialNumberCatrigeTB
            // 
            this.SerialNumberCatrigeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialNumberCatrigeTB.Location = new System.Drawing.Point(215, 65);
            this.SerialNumberCatrigeTB.Name = "SerialNumberCatrigeTB";
            this.SerialNumberCatrigeTB.Size = new System.Drawing.Size(497, 29);
            this.SerialNumberCatrigeTB.TabIndex = 3;
            this.SerialNumberCatrigeTB.TextChanged += new System.EventHandler(this.SerialNumberCatrigeTB_TextChanged_1);
            // 
            // catrigeStatusBindingSource1
            // 
            this.catrigeStatusBindingSource1.DataMember = "CatrigeStatus";
            this.catrigeStatusBindingSource1.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // catrigeStatusTableAdapter
            // 
            this.catrigeStatusTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // catrigesBindingSource
            // 
            this.catrigesBindingSource.DataMember = "Catriges";
            this.catrigesBindingSource.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // catrigesTableAdapter
            // 
            this.catrigesTableAdapter.ClearBeforeFill = true;
            // 
            // modelPrinterBindingSource
            // 
            this.modelPrinterBindingSource.DataMember = "ModelPrinter";
            this.modelPrinterBindingSource.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // modelPrinterTableAdapter
            // 
            this.modelPrinterTableAdapter.ClearBeforeFill = true;
            // 
            // catrigesBindingSource1
            // 
            this.catrigesBindingSource1.DataMember = "Catriges";
            this.catrigesBindingSource1.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // catrigesBindingSource2
            // 
            this.catrigesBindingSource2.DataMember = "Catriges";
            this.catrigesBindingSource2.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // modelColorsBindingSource
            // 
            this.modelColorsBindingSource.DataMember = "ModelColors";
            this.modelColorsBindingSource.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // modelColorsTableAdapter
            // 
            this.modelColorsTableAdapter.ClearBeforeFill = true;
            // 
            // modelPrinterBindingSource1
            // 
            this.modelPrinterBindingSource1.DataMember = "ModelPrinter";
            this.modelPrinterBindingSource1.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // firmPrinterBindingSource
            // 
            this.firmPrinterBindingSource.DataMember = "FirmPrinter";
            this.firmPrinterBindingSource.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // firmPrinterTableAdapter
            // 
            this.firmPrinterTableAdapter.ClearBeforeFill = true;
            // 
            // firmPrinterBindingSource1
            // 
            this.firmPrinterBindingSource1.DataMember = "FirmPrinter";
            this.firmPrinterBindingSource1.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // catrigesBindingSource3
            // 
            this.catrigesBindingSource3.DataMember = "Catriges";
            this.catrigesBindingSource3.DataSource = this.invintarizationDataSetBindingSource;
            // 
            // PanelColor
            // 
            this.PanelColor.BackColor = System.Drawing.SystemColors.Control;
            this.PanelColor.Location = new System.Drawing.Point(220, 175);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(356, 12);
            this.PanelColor.TabIndex = 22;
            // 
            // panelColorInfo
            // 
            this.panelColorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelColorInfo.Location = new System.Drawing.Point(215, 166);
            this.panelColorInfo.Name = "panelColorInfo";
            this.panelColorInfo.Size = new System.Drawing.Size(493, 11);
            this.panelColorInfo.TabIndex = 23;
            // 
            // ColorLab
            // 
            this.ColorLab.AutoSize = true;
            this.ColorLab.Location = new System.Drawing.Point(44, 166);
            this.ColorLab.Name = "ColorLab";
            this.ColorLab.Size = new System.Drawing.Size(48, 20);
            this.ColorLab.TabIndex = 24;
            this.ColorLab.Text = "Цвет";
            // 
            // CatrigesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 1062);
            this.Controls.Add(this.StatusCatrigeCB);
            this.Name = "CatrigesForm";
            this.Text = "Картиджи";
            this.Load += new System.EventHandler(this.CatrigesForm_Load);
            this.StatusCatrigeCB.ResumeLayout(false);
            this.StatusCatrigeCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invintarizationDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatrige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigeStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelColorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPrinterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmPrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmPrinterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catrigesBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StatusCatrigeCB;
        private System.Windows.Forms.DataGridView dgvCatrige;
        private InvintarizationDataSet invintarizationDataSet;
        private System.Windows.Forms.BindingSource catrigeStatusBindingSource;
        private InvintarizationDataSetTableAdapters.CatrigeStatusTableAdapter catrigeStatusTableAdapter;
        private System.Windows.Forms.BindingSource invintarizationDataSetBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private InvintarizationDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerialNumberCatrigeTB;
        private System.Windows.Forms.ComboBox ColorCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CatrigeStatusCBSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox SerialNumberCatrigeSearchTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StatusEditCB;
        private System.Windows.Forms.BindingSource catrigesBindingSource;
        private InvintarizationDataSetTableAdapters.CatrigesTableAdapter catrigesTableAdapter;
        private System.Windows.Forms.BindingSource modelPrinterBindingSource;
        private InvintarizationDataSetTableAdapters.ModelPrinterTableAdapter modelPrinterTableAdapter;
        private System.Windows.Forms.BindingSource catrigesBindingSource1;
        private System.Windows.Forms.BindingSource catrigesBindingSource2;
        private System.Windows.Forms.BindingSource catrigeStatusBindingSource1;
        private System.Windows.Forms.BindingSource modelColorsBindingSource;
        private InvintarizationDataSetTableAdapters.ModelColorsTableAdapter modelColorsTableAdapter;
        private System.Windows.Forms.BindingSource modelPrinterBindingSource1;
        private System.Windows.Forms.BindingSource firmPrinterBindingSource;
        private InvintarizationDataSetTableAdapters.FirmPrinterTableAdapter firmPrinterTableAdapter;
        private System.Windows.Forms.BindingSource firmPrinterBindingSource1;
        private System.Windows.Forms.BindingSource catrigesBindingSource3;
        private System.Windows.Forms.BindingSource catrigeStatusBindingSource2;
        private System.Windows.Forms.Label CatrigeID;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Panel panelColorInfo;
        private System.Windows.Forms.Label ColorLab;
    }
}

