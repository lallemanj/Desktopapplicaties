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
    public partial class GemiddeldeMDI : Form
    {

        MDIParent childForm = new MDIParent();
        //bool tekstIngevuld = false;
        //int[] arrayLijst = new int[0];
        //public static int SetValueForText = 0;
        ListBox listBox = new ListBox() { Left = 400 };
        TextBox tbTekst = new TextBox() { Top = 130, Left = 400, ReadOnly = true };

        public GemiddeldeMDI()
        {
            InitializeComponent();
            childForm.MdiParent = this.ParentForm;
        }

        private void GemiddeldeMDI_Load(object sender, EventArgs e)
        {
            listBox.Width = 200;
            Controls.Add(listBox);
            Button btnGemiddelde = new Button() { Top = 250, BackColor = Color.Cyan, Text = "Nieuw Getal", Height = 40, Width = 150, Left = 400 };
            Controls.Add(btnGemiddelde);
            Label lblTekst = new Label() { Top = 100, Text = "Gemiddelde", Left = 400 };
            Controls.Add(lblTekst);
            tbTekst.Width = 200;
            Controls.Add(tbTekst);


            btnGemiddelde.Click += BtnGemiddelde_Click;


            //this.IsMdiContainer = true;

            //childForm.MdiParent = this;
            //childForm.ControlBox = false;

        }

        public void berekenGemiddelde()
        {
            double total = 0;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                total += double.Parse(listBox.Items[i].ToString());
            }
            total = total / listBox.Items.Count;
            tbTekst.Text = total.ToString();
        }

        public void toevoegenLijst(int getal)
        {
            listBox.Items.Add(getal.ToString());
        }

        private void BtnGemiddelde_Click(object sender, EventArgs e)
        {
            //childForm.Visible = !childForm.Visible;
            //string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Your Message ", "Title", "Default Response");

            MDIParent test = new MDIParent();
            

                MDIParent gemiddelde = new MDIParent();
                gemiddelde.ShowDialog();
            if (gemiddelde.DialogResult == DialogResult.OK)
            {
                toevoegenLijst(gemiddelde.Getal);
                berekenGemiddelde();

                gemiddelde.Dispose();

            }
            }
    }
}
