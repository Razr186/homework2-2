//Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
internal class Program
{
    private static void Main(string[] args)
    {
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    homework2(number);

    void homework2(string number)
    {
    if (number.Length < 3)
    Console.WriteLine("нет третьей цифры");
    else
    Console.WriteLine($"{number[2]} третья цифра числа {number}");
   
    }
            
        
    }
}