//Ejercicio 1

Console.WriteLine("Por favor, ingresa tu peso:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Ahora, ingresa tu altura:");
float altura = float.Parse(Console.ReadLine());

        
float imc = peso / (altura * altura);

string categoria = "";
if (imc < 18.5)
    {
        categoria = "por debajo del peso ideal";
    }
    else if (imc >= 18.5 && imc < 25)
    {
        categoria = "peso ideal";
    }
    else if (imc >= 25 && imc < 30)
    {
        categoria = "sobrepeso";
    }
    else
    {
        categoria = "obeso";
    }

Console.WriteLine("Tu índice de masa corporal (IMC) es:" + imc);
Console.WriteLine("Estás:" + categoria);
 
//Ejercicio 2:

Console.WriteLine("por favor ingresa un numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("por favor ingesa el segundo numero:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los numeros ingesados es:" + (numero1 + numero2));
Console.WriteLine("La resta de los numeros ingesados es:" + (numero1 - numero2));
Console.WriteLine("La multiplicacion de los numeros ingesados es:" + (numero1 * numero2));
Console.WriteLine("La division de los numeros ingesados es:" + (numero1 / numero2));


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

