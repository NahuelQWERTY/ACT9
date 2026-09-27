/*
1. Leer nombre y apellido por separado e imprimir juntos.
2. Leer una oracion y contar cuantas letras tiene (sin espacios).
3. Convertir texto a mayusculas y luego a minusculas.
4. Verificar si una palabra ingresada contiene la letra 'a'.
5. Reemplazar todos los espacios de una frase por guiones.
6. Separar una frase en palabras con Split e imprimir cada una.
7. Verificar si dos strings son iguales ignorando mayusculas.
8. Leer un numero como string y convertirlo a int con int.Parse.
9. Crear un 'formulario' que pida nombre, edad y ciudad.
10. Verificar si un string es palindromo (igual al reves).
*/
using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {

//1. Leer nombre y apellido por separado e imprimir juntos.
Console.WriteLine("Consigna 1");
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine()!;
Console.WriteLine("Ingresa tu apellido: ");
string apellido = Console.ReadLine()!;
Console.WriteLine($"{nombre} {apellido}");
//2. Leer una oracion y contar cuantas letras tiene (sin espacios).
Console.WriteLine("Consigna 2");
string oracion= "hansel y gretel";
oracion=oracion.Replace(" ", "");
Console.WriteLine($"La oracion tiene {oracion.Length} letras");
//3. Convertir texto a mayusculas y luego a minusculas.
Console.WriteLine("Consigna 3");
string texto = "Profe aprobame porfavor el tp integrador es muy dificil";
string mayuscula= texto.ToUpper();
string minuscula= texto.ToLower();
Console.WriteLine(texto);
Console.WriteLine(mayuscula);
Console.WriteLine(minuscula);
//4. Verificar si una palabra ingresada contiene la letra 'a'.
Console.WriteLine("Consigna 4");
Console.WriteLine("Escribe una palabra: ");
string palabra = Console.ReadLine()!;
if (palabra.Contains("a")==true){
    Console.WriteLine("La palabra contiene la letra a");
}
else{
    Console.WriteLine("La palabra no contiene la letra a");
}
//5. Reemplazar todos los espacios de una frase por guiones.
Console.WriteLine("Consigna 5");
string frase = "Aprobando POO antes de GTA VI?";
string frase1 = frase.Replace(" ", "-");
Console.WriteLine("Original: " + frase);
Console.WriteLine("Remplazado: " + frase1);
//6. Separar una frase en palabras con Split e imprimir cada una.
Console.WriteLine("Consigna 6");
string frases="el eterno resplandor de una mente sin recuerdos";
string[] palabras = frases.Split(' ');
Console.WriteLine("Frase original: " + frases);
for(int i=0; i<palabras.Length; i++){
    Console.WriteLine(palabras[i]);
}
//7. Verificar si dos strings son iguales ignorando mayusculas.
Console.WriteLine("Consigna 7");
string primero ="mOrdecAI" ;
string segundo ="MorDecai" ;
if(primero.ToLower()==segundo.ToLower()){
    Console.WriteLine("Los dos strings son iguales si se ignoran las mayusculas");
}
else {
    Console.WriteLine("Los dos strings no son iguales");
}
//8. Leer un numero como string y convertirlo a int con int.Parse.
Console.WriteLine("Consigna 8");
Console.WriteLine("Ingresar un numero: ");
string numero = Console.ReadLine()!;
int numeroint = int.Parse(numero);
Console.WriteLine("Si el numero ingresado fuera un int los numero deberian de sumarse pero como uno es un string y otro un entero se concatenan: ");
Console.WriteLine(numero + numeroint);
//9. Crear un 'formulario' que pida nombre, edad y ciudad.
Console.WriteLine("Consigna 9");
Console.WriteLine("Ingresa tu nombre pibe: ");
string nombre1 = Console.ReadLine()!;
Console.WriteLine("Ingresa tu edad: ");
string edad = Console.ReadLine()!;
Console.WriteLine("Ingresa tu ciudad: ");
string ciudad  = Console.ReadLine()!;
Console.WriteLine($"Te llamas {nombre1}");
Console.WriteLine($"Tenes {edad} años");
Console.WriteLine($"y sos de {ciudad}");
//10. Verificar si un string es palindromo (igual al reves)
Console.WriteLine("Consigna 10");
/* palindromos para test
Somos o no somos.
Amo la pacifica paloma.
Isaac no ronca asi.
Yo hago yoga hoy.
Alli ves a Sevilla.
No subas abuson.
Ojo rojo.
*/
    string palindromo= "Anita lava la tina";
    string limpio1 = palindromo.ToLower().Replace(" ","");
    string limpio2="";
        for(int e=limpio1.Length-1; e>=0;e--){
            limpio2 = limpio2 + limpio1[e];
            }
            Console.WriteLine(limpio2);
     if(limpio2==limpio1){
                Console.WriteLine("La frase o palabra es un palindromo");   
            
        }
        else{
            Console.WriteLine("No es un palindromo");
        }
    }
}