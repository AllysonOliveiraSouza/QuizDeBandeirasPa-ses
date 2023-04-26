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
    public partial class F_P3 : Form
    {
        int acertos = 0;
        public F_P3(int acertos)
        {
            InitializeComponent();
            this.acertos = acertos;
        }

        private void btn_responder_Click(object sender, EventArgs e)
        {
            if ((rad_angola.Checked) || (rad_china.Checked) || (rad_jamaica.Checked) || (rad_marrocos.Checked))
            {
                if (rad_china.Checked)
                {
                    acertos++;
                    MessageBox.Show("Parabéns, você acertou!!! \n Acertos : "+acertos);

                }
                else
                {
                    MessageBox.Show("Errrrrrou!!!!  \n Acertos : "+acertos);
                }

            }

            switch (acertos){
                case 0:
                    MessageBox.Show("Infelizmente você não acertou nenhum, precisa estudar mais! \nAcertos : "+acertos);
                    break;
                case 1:
                    MessageBox.Show("Você acertou uma, tem muito a melhorar ainda! :D \nAcertos : "+acertos);
                    break;
                case 2:
                    MessageBox.Show("Você acertou duas, tá bom, mas pode melhorar! \nAcertos : "+acertos);
                    break;
                case 3:
                    MessageBox.Show("Meus parabéns, acertou tudo!!! :D \nAcertos : "+acertos);
                    break;
            }

            Application.Exit();
       
            

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
