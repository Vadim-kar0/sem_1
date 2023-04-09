Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int negativeNumber = number * -1;
while (negativeNumber <= number)
{
    Сonsole.Write(negativeNumber);
    Сonsole.Write(" ");
    negativeNumber++;
}