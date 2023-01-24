using SISU_Sistema.View.Aluno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISU_Sistema
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("gota serena");
            Alunoindex alunoExibir =  new Alunoindex();
            alunoExibir.Show();


        }
    }
}
