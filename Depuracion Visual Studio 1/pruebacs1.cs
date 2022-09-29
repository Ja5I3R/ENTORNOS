//Solicitamos el primer numero
int num1;
Console.Write("Introduce el primer numero: ");
num1 = int.Parse(Console.ReadLine());

//Solicitamos el segundo numero
int num3;
Console.Write("Introduce el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

//Realizamos la comparacion
if (num1 == num3)
{
    Console.WriteLine("Los numeros son iguales");
}
else
{
    int result;
    result = Math.Max(num1, num3);
    Console.WriteLine("El numero mas grande es " + result);
}