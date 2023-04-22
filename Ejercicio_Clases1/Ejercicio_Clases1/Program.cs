// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t-- Ejericio 1 --");
double radio;
Console.WriteLine("Ingrese el radio del circulo");
radio = double.Parse(Console.ReadLine());
double areaCirculo = Math.PI * radio * radio;
Console.WriteLine("El área del circulo es: " + areaCirculo + "\n");

Console.WriteLine("\t-- Ejericio 2 --");
//Area de un cuadrado
double lad1, lad2;
Console.WriteLine("Ingrese el lado 1");
lad1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el lado 2");
lad2 = double.Parse(Console.ReadLine());
double areaCuadrado = lad1 * lad2;
Console.WriteLine("El área del cuadrado es: " + areaCuadrado + "\n");

Console.WriteLine("\t-- Ejericio 3 y 4-- ");
Console.WriteLine("-- Se determinará cuál es el numero mayor y menor de los numeros ingresados--\n ");
IngresaNumeros();

void IngresaNumeros()
{
    double N1, N2, N3;
    Console.WriteLine("Ingrese el primer numero");
    N1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    N2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tercer numero");
    N3 = double.Parse(Console.ReadLine());

    if ((N1 > N2) && (N1 > N3))
    {

        Console.WriteLine("El numero mayor es: " + N1);

    }
    else if ((N2 > N1) && (N2 > N3))
    {

        Console.WriteLine("El numero mayor es: " + N2);
    }
    else
    {
        Console.WriteLine("El numero mayor es: " + N3);

    }

    if ((N1 < N2) && (N1 < N3))
    {

        Console.WriteLine("El numero menor es: " + N1);

    }
    else if ((N2 < N1) && (N2 < N3))
    {

        Console.WriteLine("El numero menor es: " + N2);
    }
    else
    {
        Console.WriteLine("El numero menor es: " + N3);
    }
}

Console.WriteLine("\t-- Ejercicio 5 --");

double metros, km, cm;

Console.WriteLine("Ingrese una cantidad en metros");
metros = double.Parse(Console.ReadLine());

km = metros * 0.001;
cm = metros * 100;

Console.WriteLine(metros + " metros es equivalente a " + km + " kilometros");
Console.WriteLine(metros + " metros es equivalente a " + cm + " centimetros");

