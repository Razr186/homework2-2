
//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
internal class NewBaseType
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ведите число дня недели для проверки выходнной это или нет");
        int DayOfWeek = Convert.ToInt32(Console.ReadLine());

        if (DayOfWeek == 1) Console.WriteLine("нет");
        else if (DayOfWeek == 2) Console.WriteLine("нет");
        else if (DayOfWeek == 3) Console.WriteLine("нет");
        else if (DayOfWeek == 4) Console.WriteLine("нет");
        else if (DayOfWeek == 5) Console.WriteLine("нет");
        else if (DayOfWeek == 6) Console.WriteLine("да");
        else if (DayOfWeek == 7) Console.WriteLine("да");
        else Console.WriteLine("нет такого дня недели");        
    }
}
