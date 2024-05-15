//Ejercicio 3:
Console.WriteLine("para calcular el rectangulo, ingresa la base y la altura");

Console.WriteLine("ingresa la base:");
int Base = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa la altura");
int Altura = int.Parse(Console.ReadLine());

int perimetro = (Base * 2) + (Altura * 2);
Console.WriteLine("el perimetro es:" + perimetro);

int area = Base * Altura;
Console.WriteLine("el area es:" + area);
