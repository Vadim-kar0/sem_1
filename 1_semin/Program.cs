Console.Write("Введите - числа");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
string text1 = Console.ReadLine();
int b = Convert.ToInt32(text1);

if(a * a == b)
{
    Console.WriteLine("Число является квадратом");
}
else
{
    Console.Write("число не является квадратом");
}