using DesafioPOO.Models;


   // Criando instâncias dos smartphones
    Smartphone nokia = new Nokia ("1111-2222", "Nokia 3310","22222",  62);
    Smartphone iphone = new Iphone (numero:"3333-4444", modelo: "iPhone 13",imei: "363636",  memoria: 128 );
 
    // Testando funcionalidades
    Console.WriteLine($"Testando Nokia: {nokia.Numero}");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine($"\nTestando iPhone: {iphone.Numero}");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");

    Console.WriteLine("\nTeste concluído!");

