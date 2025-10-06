using dio_dotnet_desafio_poo.Models;

Nokia n95 = new Nokia("11988887777", "Nokia N95", "M95F129845G9843H4F", 32);
n95.Ligar();
n95.InstalarAplicativo("Telegram");

Iphone i17 = new Iphone("21999998888", "Iphone 17 Pro Max", "I17G48325F87235H8F", 512);
i17.ReceberLigacao();
i17.InstalarAplicativo("WhatsApp");