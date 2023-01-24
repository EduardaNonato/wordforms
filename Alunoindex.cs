using SISU_Sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISU_Sistema.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public partial class Alunoindex : Form
        {
            private object txtnome;
            private object listaAlunos;
            private Stream enderecoArquivo;

            public object MassageBox { get; private set; }
            public object Mensagebox { get; private set; }

            public Alunoindex()
            {
                InitializeComponent();
            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                listaAlunos.Items.Add(txtnome.Text);
            }

            private void button1_Click_2(object sender, EventArgs e)
            {
                StreamWriter sw = new StreamWriter("Alunos.txt");
                foreach (var item in listaAlunos.Items)
                {
                    sw.WriteLine(item.Text);
                }
                sw.Flush();
                sw.Close();

            }
            private void button1_Click(object sender, EventArgs e)
            {
                // Sistem.IO.FiliNotFoundException
                StreamWriter sw = new StreamWriter("Alunoss.txt");
                sw.Flush();
                sw.Close();
                listaAlunos.clear();
            }
            private void AlunoIndex_Loud(object sender, EventArgs e)
            {
                try
                {
                    AlunoDAO DADOS new AlunoDAO();
                    List<model.Aluno> alunos = DADOS.getTodosAlunos();
                    foreach (var item in alunos()
                    {
                        listaAlunos.Items.Add(item.Nome + " ! " + item.Idade);
                    }

                    
                }
                catch (System.IO.FiliNotFoundException ex)
                {

                    MassageBox.show("Error de leitura de arquivo, arquivo não existe, ou endereço inválido");
                }

                private void btnAdicionar_click(object sender, EventArgs e)
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Nome é obrigatório.");
                        txtNome.BackColor = Color.Red;
                    }
                    if (txtIdade.Text == "")
                    {
                        MessageBox.Show("Idade é obrigatório.");
                        txtIdade.BackColor = Color.Red;
                    }
                    if ((txtNome.Text != "") & (txtIdade.Text != ""))
                    {
                        listaAlunos.Items.Add(txtNome.Text + " | " + txtIdade.Text);
                        txtNome.BackColor = Color.White;
                        txtIdade.BackColor = Color.White;
                    }
                    public List<Aluno> getTodosAlumos()
                    {
                        List<Aluno> getTodosAlunos()
                        {
                            List<Aluno> novaLista = new();
                            StreamReader sr = new StreamReader(enderecoArquivo);
                            string linha = sr.ReadLine();
                            while (linha != null)
                            {
                                Aluno novoAluno = new Aluno();
                                string[] dados = linha.Split("|");
                                novoAluno.Nome = dados[0];
                                novoAluno.Idade = Convert.ToInt32(dados[1]);

                                novaLista.Add(novoAluno);
                                linha = sr.ReadLine();
                            }
                            sr.Close();
                            return novaLista;

                        }


                    }

















                }
        }
    }