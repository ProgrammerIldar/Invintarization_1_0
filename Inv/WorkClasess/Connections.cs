using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv.WorkClasess
{
   public class Connections
    {
        public static string connection = System.Configuration.ConfigurationManager.ConnectionStrings["InvModel"].ConnectionString;
        


    }
}
