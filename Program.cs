
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa la clave");
        string clave;

        do
        {
            clave = Console.ReadLine();

        } while (clave != "667788");

        Console.WriteLine("perfecto");
    }
}
*/

// 2) Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo

/*
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

int num = 0;
while (num <= 0)
{
    Console.Write("Ingrese un número: ");
    string input = Console.ReadLine();
    num = int.Parse(input);
    if (num <= 0)
    {
        Console.WriteLine("El número ingresado debe ser positivo");
    }
}
Console.WriteLine("El número ingresado es positivo: " + num);
{ }
*/

// 3) Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados 
/*
class promedioNegativos
{
    static void Main(string[] args)
    {
        int num;
        int negativos = 0;
        int sumaNegativos = 0;
        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativos++;
                sumaNegativos += num;
            }
        
        } while (num != 0);
        Console.WriteLine("Saliendo del programa...");
        if (negativos > 0)
        {
            double promedioNegativos = (double) sumaNegativos / negativos;
            Console.WriteLine("El promedio de los números negativos ingresados es: " + promedioNegativos);
        } 
    }
}


// 4) Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras
/*
class Numeros
{
    static void Main(string[] args)
    {
        int num;
        do
        {
            Console.Write("Ingrese los números: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1000);
        Console.WriteLine("El número ingresado es mayor a 3 cifras");
    }
}
*/

// 5) Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados. 

class promedioNumeros
{
    static void Main(string[] args)
    {
        int num;
        int suma = 0;
        int contador = 0;
        double promedio;
        do
        {
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            if (num >= -999 && num <= 999)
            {
                contador++;
                suma += num;
            }
        } while (num < 1000 && num > -1000);
        promedio = (double)suma / contador;
        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
    }
}


