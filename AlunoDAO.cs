using SISU_Sistema.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISU_Sistema.DAL
{
    public class AlunoDAO
    {

        string enderecoArquivo;

        public AlunoDAO()
        {
            enderecoArquivo = "Aluno.tct";
        }

        public void inserir(Aluno aluno) {
        }

        public List<Aluno> getTodosAlunos()
        {
            List<Aluno> getTodosAlunos()
            {
                List<Aluno> novaLista = new List<Aluno>();
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
