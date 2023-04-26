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
    public partial class F_bemVindo : Form
    {
        string nome = "";
        public F_bemVindo(string nome)
        {
            this.nome = nome;
            InitializeComponent();
        }

        private void F_bemVindo_Load(object sender, EventArgs e)
        {
            label1.Text=nome+", "+label1.Text; 
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            F_P1 fp1 = new F_P1();
            this.Hide();
            fp1.ShowDialog();
        }
    }
}
