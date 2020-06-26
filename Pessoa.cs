

namespace ConsoleEx1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

       
        public override string ToString()
        {
            return Nome + " " + Idade;
        }
    }
}
