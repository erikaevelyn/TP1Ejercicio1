using System;

namespace EJERCICIO_1{

    public class UserInput{
        static void Main(string[] args)
        {
            TextInput numerosEjemplo = new NumericInput();
            numerosEjemplo.Add('1');
            numerosEjemplo.Add('a');
            numerosEjemplo.Add('0');
            Console.WriteLine($"La cadena de numeros formada como ejemplo es: {numerosEjemplo.GetValue()}");

            TextInput numeros = new NumericInput();
            Console.WriteLine("Ingrese un numero: ");
            numeros.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Ingrese un numero: ");
            numeros.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Ingrese un numero: ");
            numeros.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine($"La cadena formada con los numeros ingresados es: {numeros.GetValue()}");

            TextInput texto = new TextInput();
            Console.WriteLine("Ingrese un caracter: ");
            texto.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Ingrese un caracter: ");
            texto.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Ingrese un caracter: ");
            texto.Add(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine($"La cadena formada con los caracteres ingresados es: {texto.GetValue()}");

        }

    }
}