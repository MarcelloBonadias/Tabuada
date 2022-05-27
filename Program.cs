double numero, produto, contador;

Console.Clear();
Console.WriteLine("----- Tabuada -----\n");

Console.Write("Insira o número: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero <= 0)
{
    // Mensagem de erro em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nNúmero inválido.");
    Console.ResetColor();
}
else
{
    // Realiza a tabuada
    Console.Clear();
    
    Console.WriteLine($"- Tabuada do número {numero} -");

    contador = 0;
    while (contador <= 10)
    {
    produto = numero * contador;
        Console.WriteLine($"{numero} x {contador} = {produto}");
        
        // Aumenta o contador por 1
    contador++;
    }
}

// Pausa para o usuário ver o resultado
Console.Write("\nPressione uma tecla para finalizar... ");
Console.ReadKey();

// Só acontece após o usuario pressionar uma tecla
Console.Clear();
