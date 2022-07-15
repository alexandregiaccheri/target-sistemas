Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

bool VerificaFibonacci(int num)
{
    if (num >= 0 && num <= 3) return true;
    else
    {
        int fibonacciA = 5, fibonacciB = 8, fibonacciAux;
        do
        {
            if (num == fibonacciA || num == fibonacciB) return true;
            else
            {
                fibonacciAux = fibonacciB;
                fibonacciB = fibonacciA + fibonacciB;
                fibonacciA = fibonacciAux;
            }
        } while(num > fibonacciA);
        return false;
    }
}

Console.WriteLine(VerificaFibonacci(numero) ? 
    "Este número pertence a sequência de fibonacci" 
    : "Este número não pertence a sequência de fibonacci");
