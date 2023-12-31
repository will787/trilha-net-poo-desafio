using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia'");
Smartphone nokia = new Nokia("11234566", "TIJOLÂO", "11111111", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("          ");
Console.WriteLine("----------");
Console.WriteLine("          ");
Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("2123232323", "6S PLUS", "22222222", 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Free-Fire");