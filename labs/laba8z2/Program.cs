using System;

class Hexadec
{
    private string wholePart;
    private string fractionalPart;

    public Hexadec(string wholePart, string fractionalPart)
    {
        this.wholePart = wholePart;
        this.fractionalPart = fractionalPart;
    }

    public static Hexadec ReadHexadecimal()
    {
        Console.Write("Введите целую часть 16-ричного числа: ");
        string wholePart = Console.ReadLine();
        while (!IsValidHexadecimal(wholePart))
        {
            Console.WriteLine("Некорректное значение целой части. Пожалуйста, введите 16-ричное число.");
            Console.Write("Введите целую часть 16-ричного числа: ");
            wholePart = Console.ReadLine();
        }

        Console.Write("Введите дробную часть 16-ричного числа: ");
        string fractionalPart = Console.ReadLine();
        while (!IsValidHexadecimal(fractionalPart))
        {
            Console.WriteLine("Некорректное значение дробной части. Пожалуйста, введите 16-ричное число.");
            Console.Write("Введите дробную часть 16-ричного числа: ");
            fractionalPart = Console.ReadLine();
        }

        return new Hexadec(wholePart, fractionalPart);
    }

    public static bool IsValidHexadecimal(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c) && (c < 'A' || c > 'F'))
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayHexadecimal()
    {
        Console.WriteLine($"16-ричное число: {wholePart}.{fractionalPart}");
    }

    public static Hexadec Add(Hexadec hex1, Hexadec hex2)
    {
        int wholeSum = Convert.ToInt32(hex1.wholePart, 16) + Convert.ToInt32(hex2.wholePart, 16);
        int fractionSum = Convert.ToInt32(hex1.fractionalPart, 16) + Convert.ToInt32(hex2.fractionalPart, 16);

        return new Hexadec(wholeSum.ToString("X"), fractionSum.ToString("X"));
    }

    public static Hexadec Multiply(Hexadec hex1, Hexadec hex2)
    {
        long wholeProduct = Convert.ToInt64(hex1.wholePart, 16) * Convert.ToInt64(hex2.wholePart, 16);
        long fractionProduct = Convert.ToInt64(hex1.fractionalPart, 16) * Convert.ToInt64(hex2.fractionalPart, 16);

        return new Hexadec(wholeProduct.ToString("X"), fractionProduct.ToString("X"));
    }

    static void Main()
    {
        Hexadec hex1 = Hexadec.ReadHexadecimal();
        hex1.DisplayHexadecimal();

        Hexadec hex2 = Hexadec.ReadHexadecimal();
        hex2.DisplayHexadecimal();

        Hexadec sum = Hexadec.Add(hex1, hex2);
        Console.Write("Сумма: ");
        sum.DisplayHexadecimal();

        Hexadec product = Hexadec.Multiply(hex1, hex2);
        Console.Write("Произведение: ");
        product.DisplayHexadecimal();
    }
}
