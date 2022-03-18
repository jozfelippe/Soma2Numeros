int n1, n2, Resultado;

Console.WriteLine("Cálculo da soma entre dois números.\n"); 

Console.Write("Digite o primeiro número:"); 
n1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Digite o segundo número:"); 
n2 = Convert.ToInt32(Console.ReadLine()!);

Resultado = n1 + n2; 
Console.WriteLine($"soma: {Resultado}");


