namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public int IMEI { get; set; }
        public int Memoria { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (DONE)
        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
            // TODO: Passar os parâmetros do construtor para as propriedades (DONE)
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void MostrarInformaçao(){
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Armazenamento: {Memoria}GB");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}