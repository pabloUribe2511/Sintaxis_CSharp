byte width = 7, height = 5;

byte area = (byte)(width * height);

byte perimeter = (byte)(2 * width + 2 * height);

width += 3;

height -= 2;

byte area2 = (byte)(width * height);

byte perimeter2 = (byte)(2 * width + 2 * height);

Console.WriteLine($"el ancho despues de incrementarlo es : {width}");
Console.WriteLine($"la altura despues del decremento es : {height}");
Console.WriteLine($"El área es: {area2}");
Console.WriteLine($"El perímetro es: {perimeter2}");