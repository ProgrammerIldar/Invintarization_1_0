using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv.WorkClasess
{
    public class ControlPenalColor
    {
        private int SelectdIndex { get; set; }
        public string SectedItem { get; set; }
        private Panel PanelColor { get; set; }


        public ControlPenalColor(int selectdIndex, Panel panelColor)
        {
            SelectdIndex = selectdIndex;
            PanelColor = panelColor;
        
        }


        public void ClearPanel()
        {
            PanelColor.BackColor = Color.Empty;
        }


        public void selectedColorInfo(string selecteditem)
        {
            switch (selecteditem)
            {
                case "Черный":
                    PanelColor.BackColor = Color.Black;
                    break;

                case "Голубой":
                    PanelColor.BackColor = Color.Cyan;
                    break;
                case "Желтый":
                    PanelColor.BackColor = Color.Yellow;
                    break;
                case "Пурпурный":
                    PanelColor.BackColor = Color.Magenta;
                    break;

                default:
                    PanelColor.BackColor = Color.Empty;
                    break;

            }

        }


        public void selectColor()
        {

            switch (SelectdIndex)
            {
                case 0:
                    PanelColor.BackColor = Color.Black;
                    break;

                case 1:
                    PanelColor.BackColor = Color.Cyan;
                    break;
                case 2:
                    PanelColor.BackColor = Color.Yellow;
                    break;
                case 3:
                    PanelColor.BackColor = Color.Magenta;
                    break;

                default:
                    PanelColor.BackColor = Color.Empty;
                    break;

            }
        }


    }
}
