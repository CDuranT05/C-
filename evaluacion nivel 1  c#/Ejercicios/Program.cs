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
 













