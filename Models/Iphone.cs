namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
    
        public override void InstalarAplicativo(string nomeApp);
        {
           Console.WriteLine("Instalando whatsapp");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}