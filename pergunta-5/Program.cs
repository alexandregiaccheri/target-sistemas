Console.Write("Digite a string para ser invertida: ");
string entrada = Console.ReadLine();

string InverterString(string entrada)
{
    string saida = "";
    
    // Como uma string é um array de caracteres,
    // podemos acessar cada letra por seu índice

    for (int i = entrada.Length - 1; i >= 0; i--)
    {
        saida += entrada[i];
    }
    return saida;
}

Console.Write("String invertida: ");
Console.WriteLine(InverterString(entrada));