string fraseDigitada, fraseComDislalia;
            
Console.Write("Digite uma frase cebolinha: ");
fraseDigitada = Console.ReadLine()!;
fraseComDislalia = fraseDigitada!
 .Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(fraseComDislalia);