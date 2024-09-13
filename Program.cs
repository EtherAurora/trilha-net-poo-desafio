using DesafioPOO.Models;

Nokia n1 = new Nokia("+55 00 1234-5678", "Tijolo", 8947382, 64);
Iphone i1 = new Iphone("+55 00 9876-5432", "X", 32084798, 256);

n1.MostrarInformaçao();
Console.WriteLine("");

n1.Ligar();
n1.InstalarAplicativo("Google Docs");
n1.ReceberLigacao();

Console.WriteLine("");

i1.MostrarInformaçao();
Console.WriteLine("");

i1.Ligar();
i1.InstalarAplicativo("Whatsapp");
i1.ReceberLigacao();

Console.ReadLine();
Console.Clear();
// TODO: Realizar os testes com as classes Nokia e Iphone