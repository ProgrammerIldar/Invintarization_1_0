using System;
using System.Drawing;
using System.Windows.Forms;
using Inv.WorkClasess;
namespace Inv
{
    public partial class CatrigesForm : Form
    {
        public CatrigesForm()
        {
            InitializeComponent();

        }

        public void ClearAddCatrige()
        {
            CatrigeID.Text = "";
            SerialNumberCatrigeTB.Text = "";
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
            listCatriges.ListCatrigesAll(dgvCatrige);
           // SearchCatriges searchCatriges = new SearchCatriges();
            dgvCatrige.Columns[0].Visible = false;
            CatrigeStatusCBSearch.SelectedIndex = -1;
            ColorCB.SelectedIndex = -1;
            StatusEditCB.SelectedIndex = -1;

            OperationOfCatrige operationOfCatrige = new OperationOfCatrige();
            operationOfCatrige.gridView = dgvCatrige;

           


        }

        private void SerialNumberCatrigeTB_TextChanged(object sender, EventArgs e)
        {
            ListCatriges catriges = new ListCatriges();
            catriges.ListCatrigesAll(dgvCatrige);
          
        }

        private void DgvCatrige_DoubleClick(object sender, EventArgs e)
        {
           
            if (dgvCatrige.CurrentRow.Index != -1)
            {
                CatrigeID.Text = dgvCatrige.CurrentRow.Cells[0].Value.ToString();
                SerialNumberCatrigeTB.Text = dgvCatrige.CurrentRow.Cells[1].Value.ToString();
                StatusEditCB.Text = dgvCatrige.CurrentRow.Cells[6].Value.ToString();
                ColorLab.Text = dgvCatrige.CurrentRow.Cells[4].Value.ToString();                
               
            }

            ControlPenalColor controlPenal = new ControlPenalColor(0, panelColorInfo);

            controlPenal.selectedColorInfo(ColorLab.Text);
        }


        private void SearchStatusBtn_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SerialNumberCatrigeTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SerialNumberCatrigeSearchTB_TextChanged(object sender, EventArgs e)
        {
            SearchCatriges searchCatriges = new SearchCatriges("CatrigeSearchBySerialNumber","@SerialNumber",SerialNumberCatrigeSearchTB.Text.Trim(),dgvCatrige);
            searchCatriges.CatrigeSearch();
            
        }



        private void DgvCatrige_DockChanged(object sender, EventArgs e)
        {

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
            listcatriges.ListCatrigesAll(dgvCatrige);
        }
        private void StatusEditCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CatrigeStatusCBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchCatriges searchCatriges = new SearchCatriges("SearchInStatus", "@Status", CatrigeStatusCBSearch.Text.Trim(), dgvCatrige);
            searchCatriges.CatrigeSearch();

        }

        private void StatusCatrigeCB_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
        }


        void ClearSearchCatrige()
        {
            SerialNumberCatrigeSearchTB.Text = "";
            CatrigeStatusCBSearch.Text = "";
            ColorCB.Text = "";
            ControlPenalColor penalColor = new ControlPenalColor(ColorCB.SelectedIndex, PanelColor);
           
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearSearchCatrige();
            ListCatriges listCatriges = new ListCatriges();
            listCatriges.ListCatrigesAll(dgvCatrige);
            ControlPenalColor penalColor = new ControlPenalColor(ColorCB.SelectedIndex, PanelColor);
            penalColor.ClearPanel();
        }

        private void ColorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCatriges searchCatriges = new SearchCatriges("SearchColorCatrige", "@Color", ColorCB.Text.Trim(), dgvCatrige);
            searchCatriges.CatrigeSearch();

            ControlPenalColor penalColor = new ControlPenalColor(ColorCB.SelectedIndex, PanelColor);
            penalColor.selectColor();





        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            if(ColorCB.SelectedIndex==0)
            {
                PanelColor.BackColor = System.Drawing.Color.Black;
            }



        }
    }
}
