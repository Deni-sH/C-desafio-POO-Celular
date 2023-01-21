namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(modelo, numero, imei, memoria)
    {  
    }

    public override void InstalarAplicativo(string nomeApp);
        {
           Console.WriteLine($"instalando {nomeApp}");
        }
    }
        // TODO: Sobrescrever o método "InstalarAplicativo"
}
