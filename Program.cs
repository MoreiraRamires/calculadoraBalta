// See https://aka.ms/new-console-template for more information

Console.Clear();
Soma(5,10);

static void Soma (float valor1 , float valor2){
    Console.WriteLine("Primeiro Valor");
    // float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor");
    // float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    Console.WriteLine($"O resultado é {resultado} " );
}
