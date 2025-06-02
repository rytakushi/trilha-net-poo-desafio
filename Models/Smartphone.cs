namespace DesafioPOO.Models
{
        public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Console.WriteLine($"{Numero} está realizando uma ligação.");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            Console.WriteLine($"{Numero} está recebendo uma ligação.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}