using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone | DONE

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+55 (81) 99999-8888", modelo: "Nokia G60 5G", imei: "11111111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "+55 (81) 97777-4444", modelo: "iPhone 14", imei: "222222222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");