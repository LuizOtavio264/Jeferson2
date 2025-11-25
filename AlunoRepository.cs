using System.Collections.Generic;
using System.Linq;

namespace EscolaApp
{
    public class AlunoRepository
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int contadorId = 1;

        public Aluno Criar(Aluno aluno)
        {
            aluno.Id = contadorId++;
            alunos.Add(aluno);
            return aluno;
        }

        public List<Aluno> Listar()
        {
            return alunos;
        }

        public Aluno BuscarPorId(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }

        public bool Atualizar(Aluno alunoAtualizado)
        {
            var aluno = BuscarPorId(alunoAtualizado.Id);
            if (aluno == null)
                return false;
            aluno.Nome = alunoAtualizado.Nome;
            aluno.Idade = alunoAtualizado.Idade;
            return true;
        }

        public bool Deletar(int id)
        {
            var aluno = BuscarPorId(id);
            if (aluno == null)
                return false;
            alunos.Remove(aluno);
            return true;
        }
    }
}
