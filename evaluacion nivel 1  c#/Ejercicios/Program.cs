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



//Ejercico 4

 Console.WriteLine("Por favor, introduce tu fecha de nacimiento.");

Console.Write("Día (1-31): ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Mes (1-12): ");
int mes = int.Parse(Console.ReadLine());

string signo= "";

if((mes == 12 && dia >=22) || (mes == 1 && dia <=19)) {
    signo="Capricornio";
}
else if((mes == 1 && dia >=20) || (mes == 2 && dia <=18)) {
    signo="Acuario";
}
if((mes == 2 && dia >=19) || (mes == 3 && dia <=20)) {
    signo="Picis";
}
if((mes == 3 && dia >=21) || (mes == 4 && dia <=19)) {
    signo="Aries";
}
if((mes == 4 && dia >=20) || (mes == 5 && dia <=20)) {
    signo="Tauro";
}
if((mes == 5 && dia >=21) || (mes == 6 && dia <=20)) {
    signo="Geminis";
}
if((mes == 6 && dia >=21) || (mes == 7 && dia <=22)) {
    signo="Cancer";
}
if((mes == 7 && dia >=23) || (mes == 8 && dia <=22)) {
    signo="Leo";
}
if((mes == 8 && dia >=23) || (mes == 9 && dia <=22)) {
    signo="Virgo";
}
if((mes == 9 && dia >=23) || (mes == 10 && dia <=22)) {
    signo="Libra";
}
if((mes == 10 && dia >=23) || (mes == 11 && dia <=21)) {
    signo="Escorpio";
}
if((mes == 11 && dia >=22) || (mes == 12 && dia <=21)) {
    signo="Sagitario";
}

Console.WriteLine("tu signo sodiacal es:" + signo);