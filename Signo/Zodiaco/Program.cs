//Ejercico 4

 Console.WriteLine("Por favor, introduce tu fecha de nacimiento.");

Console.Write("Día (1-31): ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Mes (1-12): ");
int mes = int.Parse(Console.ReadLine());

string signo= "";

if((mes == 12 && dia >=22)) {
    signo="Capricornio";
}
else if((mes == 1 && dia <=19)){
    signo="Capricornio";
}

else if((mes == 1 && dia >=20)) {
    signo="Acuario";
}
else if((mes == 2 && dia <=18)){
    signo="Acuario";
}
else if((mes == 2 && dia >=19)) {
    signo="Picis";
}
else if((mes == 3 && dia <=20)){
    signo="Picis";
}
else if((mes == 3 && dia >=21)) {
    signo="Aries";
}
else if((mes == 4 && dia <=19)){
    signo="Aries";
}
else if((mes == 4 && dia >=20)) {
    signo="Tauro";
}
else if((mes == 5 && dia <=20)){
    signo="Tauro";
}
else if((mes == 5 && dia >=21)) {
    signo="Geminis";
}
else if((mes == 6 && dia <=20)){
    signo="Geminis";
}
else if((mes == 6 && dia >=21)) {
    signo="Cancer";
}
else if((mes == 7 && dia <=22)){
    signo="Cancer";
}
else if((mes == 7 && dia >=23)) {
    signo="Leo";
}
else if((mes == 8 && dia <=22)){
    signo="Leo";
}
else if((mes == 8 && dia >=23)) {
    signo="Virgo";
}
else if((mes == 9 && dia <=22)){
    signo="Virgo";
}
else if((mes == 9 && dia >=23)) {
    signo="Libra";
}
else if((mes == 10 && dia <=22)){
    signo="Libra";
}
else if((mes == 10 && dia >=23)) {
    signo="Escorpio";
}
else if((mes == 11 && dia <=21)){
    signo="Escorpio";
}
else if((mes == 11 && dia >=22)) {
    signo="Sagitario";
}
else if((mes == 12 && dia <=21)){
    signo="Sagitario";
}

Console.WriteLine("tu signo sodiacal es:" + signo);