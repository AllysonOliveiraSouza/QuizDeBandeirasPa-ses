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
    public partial class F_P1 : Form
    {
        int acertos = 0;    

        public F_P1()
        {
            InitializeComponent();
        }

        private void btn_responder_Click(object sender, EventArgs e)
        {


            if ((rad_chile.Checked) || (rad_colombia.Checked) || (rad_equador.Checked) || (rad_russia.Checked))
            {
                if (rad_equador.Checked)
                {
                    acertos++;
                    MessageBox.Show("Parabéns, você acertou!!! \n Acertos : "+acertos);
                    

                }
                else
                {
                    MessageBox.Show("Errrrrrou!!!!  \n Acertos : "+acertos);
                }

            }            
            F_P2 fp2 = new F_P2(acertos);
            this.Hide();
            fp2.ShowDialog();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
