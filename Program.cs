
Console.Write("Введите числа через запятую без пробелов ");
string inputStr = Console.ReadLine();
string[] text = inputStr.Split(",");
string compareText = "";

foreach (string item in text)
{
    Console.Write(item);
}

for (int i = text.Length - 1; i >= 0; i--)
{
    compareText += text[i];
}
 Console.WriteLine(" " + compareText);

string arrayToStr = "";

for (int j =  0; j < text.Length; j++)
{
    arrayToStr += text[j];
}



if (compareText == arrayToStr)
{
    Console.WriteLine("True");
}
else 
{
    Console.WriteLine("False");
}

