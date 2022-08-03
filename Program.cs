// See https://aka.ms/new-console-template for more information

Console.Clear();

// Soma();
// Subtracao();
// Divisao();
Multiplicacao();

static void Soma (float FirstArg, float SecondArg){
    Console.Clear();

    Console.WriteLine("Primeiro Valor");
    float valor1 =  float.Parse(Console.ReadLine()) + FirstArg;
    Console.WriteLine("Segundo Valor");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    Console.WriteLine($"O resultado da soma é {resultado} " );
}

static void Subtracao(){
    Console.Clear();

    Console.WriteLine("Primeiro Valor");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor");
    float valor2 = float.Parse(Console.ReadLine());
    float resultado =  valor1 - valor2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
}

static void Divisao (){
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    float valor1 = float.Parse( Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float resultado =  valor1 / valor2;
    Console.WriteLine($"O resultado da divisão é {resultado}");

}

static void Multiplicacao (){
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    float valor1 = float.Parse( Console.ReadLine());
    Console.WriteLine("Segundo Valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float resultado =  valor1 * valor2;
    Console.WriteLine($"O resultado da multipicacao é {resultado}");

}