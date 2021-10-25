using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemiddeldeMDI
{
    public partial class GetalForm : Form
    {
        public GetalForm()
        {
            InitializeComponent();
            GemiddeldeMDI gemiddelde = new GemiddeldeMDI();
            gemiddelde.MdiParent = GetalForm.ActiveForm;
            gemiddelde.Show();
        }
       
    }
}
