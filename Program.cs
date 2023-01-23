using DesafioPOO.Models;
//classe abstrata pode ser invocada acompanhada da classe filha
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "121323", modelo: "A1", imei: "1111",memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sabesp");


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "23424", modelo: "B2", imei: "2222",memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");