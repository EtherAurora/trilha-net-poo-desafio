namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" (DONE)
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} via sistema de instalação Nokia");
            Console.WriteLine("Por favor aguarde...");
            Console.WriteLine($"{nomeApp} Instalado com Successo");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo" DONE
    }
}