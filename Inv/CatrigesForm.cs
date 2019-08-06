using System;
using System.Drawing;
using System.Windows.Forms;
using Inv.WorkClasess;
namespace Inv
{
    public partial class CatrigesForm : MetroFramework.Forms.MetroForm
    {
        public CatrigesForm()
        {
            InitializeComponent();

        }

        public void ClearAddCatrige()
        {
            CatrigeID.Text = "";
            metroSerialNumberCatrigeTB.Text = "";
            StatusEditCB.Text = "";


        }

        private void CatrigesForm_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.FirmPrinter". При необходимости она может быть перемещена или удалена.
            this.firmPrinterTableAdapter.Fill(this.invintarizationDataSet.FirmPrinter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.ModelColors". При необходимости она может быть перемещена или удалена.
            this.modelColorsTableAdapter.Fill(this.invintarizationDataSet.ModelColors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.ModelPrinter". При необходимости она может быть перемещена или удалена.
            this.modelPrinterTableAdapter.Fill(this.invintarizationDataSet.ModelPrinter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.Catriges". При необходимости она может быть перемещена или удалена.
            this.catrigesTableAdapter.Fill(this.invintarizationDataSet.Catriges);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter.Fill(this.invintarizationDataSet.Color);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.ModelColors". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "invintarizationDataSet.CatrigeStatus". При необходимости она может быть перемещена или удалена.
            this.catrigeStatusTableAdapter.Fill(this.invintarizationDataSet.CatrigeStatus);
            ColorLab.Visible = false;
            ListCatriges listCatriges = new ListCatriges();          
            listCatriges.ListCatrigesAll(metroDgvCatrige);

          
            metroDgvCatrige.Columns[0].Visible = false;
            CatrigeStatusCBSearch.SelectedIndex = -1;
            ColorCB.SelectedIndex = -1;
            StatusEditCB.SelectedIndex = -1;
            
            OperationOfCatrige operationOfCatrige = new OperationOfCatrige();
            operationOfCatrige.gridView = metroDgvCatrige;
            operationOfCatrige.gridView = metroDgvCatrige;



        }

        private void SerialNumberCatrigeTB_TextChanged(object sender, EventArgs e)
        {
            ListCatriges catriges = new ListCatriges();
            catriges.ListCatrigesAll(metroDgvCatrige);
          
        }

        private void DgvCatrige_DoubleClick(object sender, EventArgs e)
        {
           
            if (metroDgvCatrige.CurrentRow.Index != -1)
            {
                CatrigeID.Text = metroDgvCatrige.CurrentRow.Cells[0].Value.ToString();
                metroSerialNumberCatrigeTB.Text = metroDgvCatrige.CurrentRow.Cells[1].Value.ToString();
                StatusEditCB.Text = metroDgvCatrige.CurrentRow.Cells[6].Value.ToString();
                ColorLab.Text = metroDgvCatrige.CurrentRow.Cells[4].Value.ToString();                
               
            }

            ControlPenalColor controlPenal = new ControlPenalColor(0, panelColorInfo);

            controlPenal.selectedColorInfo(ColorLab.Text);
        }


        private void SerialNumberCatrigeSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchCatriges searchCatriges = new SearchCatriges("CatrigeSearchBySerialNumber","@SerialNumber",SerialNumberCatrigeSearchTB.Text.Trim(), metroDgvCatrige);
  
            searchCatriges.CatrigeSearch();
            
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            ClearAddCatrige();
            ControlPenalColor controlPenal = new ControlPenalColor(0, panelColorInfo);
            controlPenal.ClearPanel();           
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OperationOfCatrige operationOfCatrige = new OperationOfCatrige();
            try
            {
                operationOfCatrige.UppdateByCatrigeStatus(Convert.ToInt32(CatrigeID.Text.Trim()), (int)StatusEditCB.SelectedValue);
                ClearAddCatrige();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            ListCatriges listcatriges = new ListCatriges();
            listcatriges.ListCatrigesAll(metroDgvCatrige);
        }
        
        private void CatrigeStatusCBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SearchCatriges searchCatriges = new SearchCatriges("SearchInStatus", "@Status", CatrigeStatusCBSearch.Text.Trim(), metroDgvCatrige);
            searchCatriges.CatrigeSearch();
            
        }


        void ClearSearchCatrige()
        {
            SerialNumberCatrigeSearchTB.Text = "";
            CatrigeStatusCBSearch.Text = "";
            ColorCB.Text = "";
         
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearSearchCatrige();
            ListCatriges listCatriges = new ListCatriges();
            listCatriges.ListCatrigesAll(metroDgvCatrige);
        
        }

        private void ColorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCatriges searchCatriges = new SearchCatriges("SearchColorCatrige", "@Color", ColorCB.Text.Trim(), metroDgvCatrige);
            searchCatriges.CatrigeSearch();

           

        }

       
        private void Button1_Click_3(object sender, EventArgs e)
        {
            if(ColorCB.SelectedIndex==0)
            {
               

            }

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            OperationOfCatrige operationOfCatrige = new OperationOfCatrige();
            try
            {
                operationOfCatrige.UppdateByCatrigeStatus(Convert.ToInt32(CatrigeID.Text.Trim()), (int)StatusEditCB.SelectedValue);
                ClearAddCatrige();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            ListCatriges listcatriges = new ListCatriges();
            listcatriges.ListCatrigesAll(metroDgvCatrige);
        }

        private void MetroClearEdit_Click(object sender, EventArgs e)
        {
            ClearAddCatrige();
            ControlPenalColor controlPenal = new ControlPenalColor(0, panelColorInfo);
            controlPenal.ClearPanel();
        }

        private void MetroDgvCatrige_DoubleClick(object sender, EventArgs e)
        {
            if (metroDgvCatrige.CurrentRow.Index != -1)
            {
                CatrigeID.Text = metroDgvCatrige.CurrentRow.Cells[0].Value.ToString();
                metroSerialNumberCatrigeTB.Text = metroDgvCatrige.CurrentRow.Cells[1].Value.ToString();
                StatusEditCB.Text = metroDgvCatrige.CurrentRow.Cells[6].Value.ToString();
                ColorLab.Text = metroDgvCatrige.CurrentRow.Cells[4].Value.ToString();

            }

            ControlPenalColor controlPenal = new ControlPenalColor(0, panelColorInfo);

            controlPenal.selectedColorInfo(ColorLab.Text);

        }

        private void MetroSearchCatrigesTB_Click(object sender, EventArgs e)
        {
            SearchCatriges searchCatriges1 = new SearchCatriges("CatrigeSearchBySerialNumber", "@SerialNumber", CatrigeStatusCBSearch.Text.Trim(), metroDgvCatrige);

        }

        private void StatusEditCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            ClearSearchCatrige();
            ListCatriges listCatriges = new ListCatriges();
            listCatriges.ListCatrigesAll(metroDgvCatrige);
           
        }
    }
}
