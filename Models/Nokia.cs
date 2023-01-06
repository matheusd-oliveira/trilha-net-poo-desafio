namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia!");
            Console.WriteLine($"Modelo {Modelo} tem a bateria de 72h. Use com moderação...");
        }
    }
}