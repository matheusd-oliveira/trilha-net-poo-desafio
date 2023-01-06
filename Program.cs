using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1111-2222", modelo: "Tijolão", imei: "111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "2222-4444", modelo: "Bateria de Porcelana", imei: "222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
