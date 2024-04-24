int qtd_linhas = 0, qtd_colunas = 0, count = 0, resultado = 0;

do
{
    Console.Write("Digite a quantidade de colunas das matrizes: ");
    qtd_colunas = int.Parse(Console.ReadLine());
    Console.Write("\nDigite a quantidade de linhas das matrizes: ");
    qtd_linhas = int.Parse(Console.ReadLine());
} while (qtd_linhas ,< 1 && qtd_colunas < 1);

int[,] matriz1 = new int[qtd_linhas, qtd_colunas], matriz2 = new int[qtd_linhas, qtd_colunas], matriz_soma = new int[qtd_linhas, qtd_colunas];

Console.WriteLine("Matriz");
for (int linhas = 0; linhas < qtd_linhas; linhas++)
{
    Console.WriteLine();
    for (int colunas = 0; colunas < qtd_colunas; colunas++)
    {
        matriz1[linhas, colunas] = new Random().Next(0, 101);
        Console.Write(matriz1[linhas,colunas] + " ");
    }
}

for (int linhas = 0; linhas < qtd_linhas; linhas++)
{
    Console.WriteLine();
    resultado = 0;
    for (int colunas = 0; colunas < qtd_colunas; colunas++)
    {
        if (linhas <qtd_linhas)
        {
            resultado = resultado + matriz1[linhas,colunas];
            if((qtd_colunas - 1) == colunas)
                Console.WriteLine($"Soma da linha {linhas} é: {resultado}");
        }
    }
}

for (int colunas = 0; colunas < qtd_colunas; colunas++)
{
    Console.WriteLine();
    resultado = 0;
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        if (colunas < qtd_colunas)
        {
            resultado = resultado + matriz1[linhas, colunas];
            if ((qtd_linhas - 1) == linhas)
                Console.WriteLine($"Soma da coluna {colunas } é: {resultado}");
        }
    }
}
if (qtd_colunas == qtd_linhas) 
{
    resultado = 0;
    for (int colunas = 0; colunas < qtd_colunas; colunas++)
    {
        int linhas = colunas;
        resultado = resultado + matriz1[linhas, colunas];
        if ((colunas + 1 == qtd_colunas))
            Console.WriteLine($"A soma da primeira diagonal é: {resultado}");
    }
    resultado = 0;
    for (int colunas = qtd_colunas - 1; colunas >= 0; colunas--)
    {
        for (int linhas = 0; linhas < qtd_linhas; linhas++)
        {
            if ( (linhas + colunas) == (qtd_colunas - 1))
            {
                resultado += matriz1[linhas, colunas];
            }
            if ((linhas + 1 == qtd_linhas))
                Console.WriteLine($"A soma da segunda diagonal é: {resultado}");
        }
    }
}
else
{
    Console.WriteLine("Matriz não quadrada, impossivel soma das diagonais");
}
