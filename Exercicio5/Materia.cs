namespace Exercicio5
{
    public class Materia
    {
        public string Nome { get; set; }
        public float Primeira_nota { get; set; }
        public float Segunda_nota { get; set; }
        public float resultado() 
        {
            var result = (Primeira_nota + Segunda_nota) / 2; 
           return result;
        }
    }
}