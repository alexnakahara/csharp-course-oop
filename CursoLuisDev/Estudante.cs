using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLuisDev
{
    internal class Estudante : Pessoa
    {
        public string Turma { get; set; }
        public List<int> Notas { get; private set; }

        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }

        public override void SeApresentar()
        {
            base.SeApresentar();
            var media = Notas.Average();
            Console.WriteLine($"Sou estudante da turma {Turma}, Media de Notas: {media}");
        }

    }
}
