using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone // Herda da classe Smartphone
    {
        // Construtor para a classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Sobrescreve o método abstrato InstalarAplicativo da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        
        }
    }
}
