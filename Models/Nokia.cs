namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string modelo) : base(modelo)
        
         public override void InstalarAplicativo(string nomeApp);
         {
            Console.WriteLine("Instalando whatsapp");
         }
         
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }

}