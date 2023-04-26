using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Txt_Nome.Focus();
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_bemVindo bv = new F_bemVindo(Txt_Nome.Text);

            if (Txt_Nome.Text!="")
            {
                this.Hide();
                bv.ShowDialog();              


            }
            else
            {
                MessageBox.Show("Não deixar o campo em branco !!\n Preencha seu nome..");
            }
        }


    }
}
