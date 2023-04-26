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
    public partial class F_P2 : Form
    {
        int acertos = 0;


        public F_P2(int acertos)
        {
            this.acertos = acertos;
            InitializeComponent();

        }

        private void btn_responder_Click(object sender, EventArgs e)
        {
           

            if ((rad_canada.Checked) || (rad_coreia.Checked) || (rad_japao.Checked) || (rad_paraguai.Checked))
            {
                if (rad_coreia.Checked)
                {
                    acertos++;
                    MessageBox.Show("Parabéns, você acertou!!! \n Acertos : "+acertos);
                   

                }
                else
                {
                    MessageBox.Show("Errrrrrou!!!!  \n Acertos : "+acertos);
                }        
                
            }
            F_P3 fp3 = new F_P3(acertos);
            this.Hide();
            fp3.ShowDialog();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}