try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    Console.Write("Введите l:");
    int l = int.Parse(Console.ReadLine());
    bool x = (n + m > k) && (!(n > k) || (m < l));
    if (x)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}