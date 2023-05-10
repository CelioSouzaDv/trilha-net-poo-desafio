using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12998958745", modelo: "Tijolao", imei: "2589-7364", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("###########################################");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "12987254613", modelo: "Iphone 15x pro Max", imei: "2580-7913", memoria: 256);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Clash of Clans");