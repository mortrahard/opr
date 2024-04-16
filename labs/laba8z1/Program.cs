public abstract class Koord
{
    public int Degrees { get; set; }
    public float Minutes { get; set; }
    public char Hemisphere { get; set; }

    public Koord(int degrees, float minutes, char hemisphere)
    {
        Degrees = degrees;
        Minutes = minutes;
        Hemisphere = hemisphere;
    }

    public static Koord ReadCoordinates(string coordinateType)
    {
        Console.Write($"Введите градусы {coordinateType}: ");
        int degrees;
        while (!int.TryParse(Console.ReadLine(), out degrees) || degrees < 0 || degrees > (coordinateType == "широты" ? 90 : 180))
        {
            Console.WriteLine($"Некорректное значение градусов {coordinateType}. Введите целое число от 0 до {(coordinateType == "широты" ? "90" : "180")}");
            Console.Write($"Введите градусы {coordinateType}: ");
        }
        Console.Write($"Введите минуты {coordinateType}: ");
        float minutes;
        while (!float.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes >= 60)
        {
            Console.WriteLine($"Некорректное значение минут {coordinateType}. Введите число от 0 до 59.9.");
            Console.Write($"Введите минуты {coordinateType}: ");
        }
        Console.Write($"Введите направление (N/S/E/W): ");
        char hemisphere;
        while (!char.TryParse(Console.ReadLine(), out hemisphere) || (hemisphere != 'N' && hemisphere != 'S' && hemisphere != 'W' && hemisphere != 'E'))
        {
            Console.WriteLine("Введите N, S, E или W.");
            Console.Write("Введите направление (N/S/E/W): ");
        }
        return new ConcreteKoord(degrees, minutes, hemisphere);
    }

    public abstract float CalculateDistance(Koord point2);
}

public class ConcreteKoord : Koord
{
    public ConcreteKoord(int degrees, float minutes, char hemisphere) : base(degrees, minutes, hemisphere)
    {
    }

    public override float CalculateDistance(Koord point2)
    {
        float distanceLatitude = Math.Abs(Degrees - point2.Degrees) * 111.0f;
        float distanceLongitude = Math.Abs(Minutes - point2.Minutes) * 111.0f * (float)Math.Cos((Degrees + point2.Degrees) / 2);

        return (float)Math.Sqrt(distanceLatitude * distanceLatitude + distanceLongitude * distanceLongitude);
    }
}

class Program
{
    static void Main()
    {
        Koord point1 = ConcreteKoord.ReadCoordinates("широты");
        Console.WriteLine($"Координаты первой точки: {point1.Degrees}°{point1.Minutes} {point1.Hemisphere}");

        Koord point2 = ConcreteKoord.ReadCoordinates("широты");
        Console.WriteLine($"Координаты второй точки: {point2.Degrees}°{point2.Minutes} {point2.Hemisphere}");

        float distance = point1.CalculateDistance(point2);
        Console.WriteLine($"Расстояние между точками: {distance} км");
    }
}