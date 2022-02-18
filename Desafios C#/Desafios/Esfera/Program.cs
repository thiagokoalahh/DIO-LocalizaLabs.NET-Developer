using System;

class DIO
{
    static void Main(string[] args)
    {

        double pi, raio, volume;
        pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        volume = (4.0 / 3) * pi * raio * raio * raio;
        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}