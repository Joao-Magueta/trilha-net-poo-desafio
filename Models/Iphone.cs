using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone // Herda da classe Smartphone
    {
        // Construtor para a classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Sobrescreve o método abstrato InstalarAplicativo da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
            
        }
    }
}
