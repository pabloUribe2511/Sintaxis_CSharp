
//enteros
byte edadMascota = 3;                 
short anioNacimiento = 2001;         
int numeroDeEstudiantes = 25;         
long poblacionMundial = 7900000000L;  

// decimales
float estatura = 1.73f;               
double precioProducto = 1500.99;     
decimal saldoBanco = 1500000.50m;    

// string y char
char inicialNombre = 'J';             
string nombreCompleto = "Julio Jaramillo Maestre"; 

// logica
bool esCantante = true;               

// asume el tipo
var ciudad = "Calatraba";              
var temperatura = 22.5;               

// mostrar en consola

Console.WriteLine(" Enteros ");
Console.WriteLine("byte  edadMascota        : " + edadMascota);
Console.WriteLine("short anioNacimiento     : " + anioNacimiento);
Console.WriteLine("int   numeroDeEstudiantes: " + numeroDeEstudiantes);
Console.WriteLine("long  poblacionMundial   : " + poblacionMundial);
Console.WriteLine();

Console.WriteLine(" Decimales ");
Console.WriteLine("float   estatura      : " + estatura);
Console.WriteLine("double  precioProducto: " + precioProducto);
Console.WriteLine("decimal saldoBanco    : " + saldoBanco);
Console.WriteLine();

Console.WriteLine("String y Char");
Console.WriteLine("char   inicialNombre : " + inicialNombre);
Console.WriteLine("string nombreCompleto: " + nombreCompleto);
Console.WriteLine();

Console.WriteLine("Logica");
Console.WriteLine("bool esCantante: " + esCantante);
Console.WriteLine();

Console.WriteLine("uso de var para asumir el tipo");
Console.WriteLine("ciudad      (" + ciudad.GetType().Name + "): " + ciudad);
Console.WriteLine("temperatura (" + temperatura.GetType().Name + "): " + temperatura);
Console.WriteLine();

Console.WriteLine("Limites del tipo");
Console.WriteLine("int.MinValue : " + int.MinValue);
Console.WriteLine("int.MaxValue : " + int.MaxValue);
Console.WriteLine("byte.MaxValue: " + byte.MaxValue);