using System.Xml.Linq;

namespace EsercizoC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome:");
            String rNome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome:");
            String rCognome = Console.ReadLine();
            Console.WriteLine("Inserisci la tua eta' :");
            byte rEta = byte.Parse(Console.ReadLine());
            Persona persona1 = new Persona(rNome, rCognome, rEta);
            //Console.WriteLine(persona1.Nome+ " " +persona1.Cognome + " " +persona1.Eta);
            persona1.GetDettagli();
        }
    }

    class Persona
    {
        private string _nome;
        private string _cognome;
        private byte _eta;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 0)
                {
                    _nome = value.ToUpper();
                }
            }
        }
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if (value.Length > 0)
                {
                    _cognome = value.ToUpper();
                }
            }
        }
        public byte Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                if (value > 0 && value < 130)
                {
                    _eta = value;
                }
            }
        }

        public Persona(string nome, string cognome, byte eta) 
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public void GetDettagli()
        {
            Console.WriteLine("Ti chiami: "+Nome+ " " +Cognome+" e hai: " +Eta+ " anni");
        }
    }
}



