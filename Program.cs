using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Console.WriteLine("************************");
Smartphone nokia = new Nokia(numero: "(11) 11111-1111", modelo: "Nokia C01 Plus 32GB", imei: "1111111", memoria: "4G");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("\n");

Console.WriteLine("**************-------------***************----------**********");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Console.WriteLine("************************");
Smartphone iphone = new Iphone(numero: "(11) 11111-1111", modelo: "Iphone 14", imei: "1111111", memoria: "4G");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


