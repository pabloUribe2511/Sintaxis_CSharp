// operadores aristmeticos
int a = 15;
int b = 5;

Console.WriteLine("Operadores aritméticos a y b (15 y 5) ");
Console.WriteLine("Suma           a + b = " + (a + b));
Console.WriteLine("Resta          a - b = " + (a - b));
Console.WriteLine("Multiplicación a * b = " + (a * b));
Console.WriteLine("División entera a / b = " + (a / b));          
Console.WriteLine("División real   a / b = " + ((double)a / b));  
Console.WriteLine("Módulo (resto)  a % b = " + (a % b));          
Console.WriteLine();

// incrementar y decrementar
int contador = 10;
Console.WriteLine(" Incremento y decremento ");
Console.WriteLine("Valor inicial: " + contador);
contador++;
Console.WriteLine("Después de contador++: " + contador);
contador--;
Console.WriteLine("Después de contador--: " + contador);
Console.WriteLine();

// operadores de asignación
int numero = 100;
Console.WriteLine(" Operadores de asignación ");
Console.WriteLine("numero = " + numero);

numero += 20;   
Console.WriteLine("numero += 20 -> " + numero);

numero -= 30;   
Console.WriteLine("numero -= 30 -> " + numero);

numero *= 2;    
Console.WriteLine("numero *= 2  -> " + numero);

numero /= 4;    
Console.WriteLine("numero /= 4  -> " + numero);

numero %= 7;    
Console.WriteLine("numero %= 7  -> " + numero);
Console.WriteLine();

// calculos 
Console.WriteLine("Calculos basicos");

// Promedio de tres notas
double nota1 = 4.5;
double nota2 = 3.8;
double nota3 = 4.2;
double promedio = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("Promedio de notas       : " + promedio);


// Compra con IVA
const double IVA = 0.19;
double precioBase = 200000;
double valorIva = precioBase * IVA;
double totalAPagar = precioBase + valorIva;
Console.WriteLine("Precio base             : " + precioBase);
Console.WriteLine("IVA (19%)               : " + valorIva);
Console.WriteLine("Total a pagar           : " + totalAPagar);
