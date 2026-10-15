

// interpolación básica 
string nombre = "Julio";
string apellido = "Jaramillo";
int edad = 67;
string programa = "Canto";

Console.WriteLine(" Identificacion de canto");
Console.WriteLine($"Nombre  : {nombre} {apellido}");
Console.WriteLine($"Edad    : {edad} años");
Console.WriteLine($"Programa: {programa}");
Console.WriteLine();

// esxpresiones en llaves
int numero1 = 12;
int numero2 = 8;

Console.WriteLine("Operaciones dentro de la interpolación");
Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
Console.WriteLine($"{numero1} / {numero2} = {(double)numero1 / numero2}");
Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");
Console.WriteLine();


// logica de la interpolacion
double notaFinal = 3.7;
Console.WriteLine("--- Condicional dentro de la interpolación ---");
Console.WriteLine($"Nota final: {notaFinal:F1} -> {(notaFinal >= 3.0 ? "Aprobado" : "Reprobado")}");