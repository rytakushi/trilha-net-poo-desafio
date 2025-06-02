using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
   // Criando instâncias dos smartphones
    Smartphone nokia = new Nokia ("1111-2222");
    Smartphone iphone = new Iphone("3333-4444");

    // Testando funcionalidades
    Console.WriteLine("Testando Nokia:");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine("\nTestando iPhone:");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");

    Console.WriteLine("\nTeste concluído!");

