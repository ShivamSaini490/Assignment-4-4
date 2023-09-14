using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Temperature
{
    private double celsius;
    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }
    public double Fahrenheit
    {
        get { return (celsius * 9 / 5) + 32; }
    }

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }
}
class Program
{
    static void Main()
    {
        Temperature temp = new Temperature(25.0);

        Console.WriteLine($"Temperature in Celsius: {temp.Celsius}°C");
        Console.WriteLine($"Temperature in Fahrenheit: {temp.Fahrenheit}°F");

        Console.ReadLine();
    }
}
