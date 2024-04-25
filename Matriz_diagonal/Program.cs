using System.Diagnostics.CodeAnalysis;

int qtd_linhas = 0, qtd_colunas = 0, count = 0, opcao = 0;
float resultado = 0;


int determinar_colunas()
{
    Console.Clear();
    int qt_colunas;
    do
    {
        Console.Write("Digite a quantidade de colunas das matrizes: ");
        qt_colunas = int.Parse(Console.ReadLine());

    } while ( qt_colunas < 1);

    return qt_colunas;
}
int determinar_linhas(){
    int qt_linhas;
    do
    {
        Console.Write("\nDigite a quantidade de linhas das matrizes: ");
        qt_linhas = int.Parse(Console.ReadLine());

    } while (qt_linhas < 1);

    return qt_linhas;
}
void encerrar()
{
    Console.WriteLine("Encerrando!");
    Console.ReadLine();
}

int menu()
{
    int escolha = 0;
    do
    {
        Console.WriteLine("Escolha qual operação deseja realizar");
        Console.WriteLine("1 - Soma da linha");
        Console.WriteLine("2 - Soma da coluna");
        Console.WriteLine("3 - soma das diagonais");
        Console.WriteLine("0 - para encerrar");
        escolha = int.Parse(Console.ReadLine());
    } while (escolha < 0 || escolha > 3);
    return escolha;
}
void imprimir_matriz(float[,] matriz, string titulo)
{
    Console.WriteLine($"\n {titulo}");
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        Console.WriteLine();
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            Console.Write(matriz[linhas, colunas] + " ");
        }
    }
    Console.WriteLine();
    Console.ReadLine();
}
float[,] sortear_matriz(int linhas, int colunas)
{
    float[,] matriz = new float[linhas, colunas];

    for (int linha = 0; linha < linhas; linha++)
    {
        for (int coluna = 0; coluna < colunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(0, 101);
        }
    }
    return matriz;
}

void somar_coluna(float[,] matriz)
{
    for (int colunas = 0; colunas < qtd_colunas; colunas++)
    {
        Console.WriteLine();
        resultado = 0;
        for (int linhas = 0; linhas < qtd_linhas; linhas++)
        {
            resultado = resultado + matriz[linhas, colunas];
        }
        exibir_resultado(colunas, resultado, "coluna");
    }
}

void somar_linha(float[,] matriz)
{
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        Console.WriteLine();
        resultado = 0;
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            resultado = resultado + matriz[linhas, colunas];
        }
        exibir_resultado(linhas,resultado,"linha" );
    }
}
void exibir_resultado(int numero, float resultado, string texto)
{
    Console.WriteLine($"Soma da {texto} {numero} é: {resultado}");
    Console.ReadKey();  
}

void somar_diagonais(float[,] matriz)
{
    if (qtd_colunas == qtd_linhas)
    {
        resultado = 0;
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            int linhas = colunas;
            resultado = resultado + matriz[linhas, colunas];
            if ((colunas + 1 == qtd_colunas))
                Console.WriteLine($"A soma da primeira diagonal é: {resultado}");
        }
        resultado = 0;
        for (int colunas = qtd_colunas - 1; colunas >= 0; colunas--)
        {
            for (int linhas = 0; linhas < qtd_linhas; linhas++)
            {
                if ((linhas + colunas) == (qtd_colunas - 1))
                {
                    resultado += matriz[linhas, colunas];
                }
            }
            if ((colunas - 1) < 0)
                Console.WriteLine($"A soma da segunda diagonal é: {resultado}");
        }
    }
    else
    {
        Console.WriteLine("Soma das diagonais impossivel por não ser matriz quadrada, quantidade de colunas devem ser iguais quantidade de linhas");
    }
    Console.ReadKey();
}
do
{
    qtd_colunas = determinar_colunas();
    qtd_linhas = determinar_linhas();
    float[,] matriz1 = new float[qtd_linhas, qtd_colunas];
    matriz1 = sortear_matriz(qtd_linhas,qtd_colunas);
    imprimir_matriz(matriz1, "Matriz Sorteada");
    opcao = menu();
    switch (opcao)
    {
        case 1:
            somar_linha(matriz1);
        break;
        case 2:
            somar_coluna(matriz1);
        break;
        case 3:
            somar_diagonais(matriz1);
        break;
        default:
            encerrar();
        break;

    }
} while (opcao > 0 && opcao < 4);