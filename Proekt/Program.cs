using Proekt;


IPrintable[] arr = {
    new Word("Тестируем"), new Sign(' '),
    new Word("мою"), new Sign(' '),
    new Word("архитектуру"), new Sign('!') 
};


PrinterDelegateDefault printerDelegate = new PrinterDelegateDefault();

PrinterSpecial2 printerSpecial = new PrinterSpecial2();

Text text = new Text(arr);


printerSpecial.print(text);

text.Print(printerSpecial);

Console.WriteLine();

text.Print(new PrinterDefault());

Console.WriteLine();
text.Print(new PrinterSpecial());
