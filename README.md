# Job Rotation - Ribeirão Preto

## Pergunta 1

Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?

### RESPOSTA: 91
#### [Algoritmo acima escrito em C#](pergunta-1/Program.cs)

<hr>

## Pergunta 2

Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

### RESPOSTA:
```csharp
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
```
#### [Link para este algoritmo](pergunta-2/Program.cs)

<hr>

## Pergunta 3

Descubra a lógica e complete o próximo elemento:

a) 1, 3, 5, 7, \_\_\_

### RESPOSTA: 9. Sequência de números ímpares.

b) 2, 4, 8, 16, 32, 64, \_\_\_\_

### RESPOSTA: 128. Sequência de 2^ n.

c) 0, 1, 4, 9, 16, 25, 36, \_\_\_\_

### RESPOSTA: 49. Sequência de números onde a diferença entre dois números vizinhos é a sequência de números ímpares.

d) 4, 16, 36, 64, \_\_\_\_

### RESPOSTA: 100. Sequência de números onde a diferença entre dois vizinhos aumenta de 8 em 8, começando por 12 (entre 4 e 16).

e) 1, 1, 2, 3, 5, 8, \_\_\_\_

### RESPOSTA: 13. Sequência de fibonacci.

f) 2, 10, 12, 16, 17, 18, 19, \_\_\_\_

### RESPOSTA: 200. Sequência de números que começam com a letra "D".

<hr>

## Pergunta 4

Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?

IMPORTANTE:

a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.

b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)

c) Explique como chegou no resultado.

### RESPOSTA: Quando eles se cruzarem, estarão no mesmo ponto, porém, podemos considerar as seguintes situações:

### 1) se contarmos do "meio" do carro e do caminhão, tecnicamente o caminhão estaria mais perto, já que é um veículo maior.

### 2) se contarmos da frente do carro e do caminhão (quando a frente de um e de outro atingir o mesmo "ponto"), o carro estará mais perto, pois como partiu de Ribeirão Preto, sua traseira estará mais próxima a cidade.

### 3) agora, se contarmos com a necessidade de um retorno, o caminhão provavelmente estará mais próximo de chegar em Ribeirão Preto, já que o carro deverá passar primeiro pelo retorno.

<hr>

## Pergunta 5

Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;

## RESPOSTA:
```csharp
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
```
#### [Link para este algoritmo](pergunta-5/Program.cs)
