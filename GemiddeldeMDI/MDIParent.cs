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
    public partial class MDIParent : Form
    {

        //bool tekstIngevuld = false;
        //public static int SetValueForText = 0;



        //GemiddeldeMDI gemiddeldeMDI = new GemiddeldeMDI();
            TextBox tbTekst = new TextBox() { Top = 80, Left = 50 };

        public MDIParent()
        {
            InitializeComponent();
        }
        public int Getal {  get; private set; }


        private void MDIParent_Load(object sender, EventArgs e)
        {
            Label lblTekst = new Label() { Top = 50, Text = "Waarde", Left = 50 };
            Controls.Add(lblTekst);
            Controls.Add(tbTekst);
            //Button btnParent = new Button() { Text = "OK", Top = 110, Left = 50 };
            //btnParent.DialogResult.OK;
            //Controls.Add(btnParent);

            //btnParent.Click += BtnParent_Click;

            //tbTekst test = "";



        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Getal = int.Parse(tbTekst.Text);

        }
    }
}
