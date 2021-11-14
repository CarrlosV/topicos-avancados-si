namespace GameTOP
{
    public class Jogador1
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        public string corre()
        {
            return $"{_Nome} está Correndo \n";
        }

        public string passe()
        {
            return $"{_Nome} está passando \n";
        }
    }

}