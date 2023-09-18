using System;


namespace exemploHeranca_1.classes
{
    internal class Aluno:Pessoa //"Aluno é filho de pessoa"
    {
        public string Responsavel { get; set; }
        public string Turma { get; set; }
        public string Matricula { get; set; }
    }
}
