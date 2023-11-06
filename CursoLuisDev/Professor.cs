namespace CursoLuisDev
{
    internal class Professor : Pessoa
    {
        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }

        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento)
            :base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B"};

        }

        public override void SeApresentar()
        {
            base.SeApresentar();
            var turmas = string.Join(',', Turmas);
            Console.WriteLine($"Meu salário é {Salario}, e ensino para as turmas: {turmas}");
        }
    }
}
