//2. (Vetores Vogais e Consoantes) Faça um vetor de caracteres de 10 posições e imprima os seguintes itens:
//a) somente as vogais;
//b) somente as consoantes;

char[] vogais = new char[10];
char[] consoantes = new char[10];
char[] letras = new char[10];
char letra;
int contador = 1;

for (int i = 0; i < 10; i++)
{
    Console.Write($"{contador}º letra: ");
    letra = char.Parse(Console.ReadLine());
    letras[i] = letra;
    contador++;
}

for (int x = 0; x < 10; x++)
{
    switch (letras[x])
    {
        case 'a':
            vogais[x] = letras[x];
            break;
        case 'A':
            vogais[x] = letras[x];
            break;
        case 'e':
            vogais[x] = letras[x];
            break;
        case 'E':
            vogais[x] = letras[x];
            break;
        case 'i':
            vogais[x] = letras[x];
            break;
        case 'I':
            vogais[x] = letras[x];
            break;
        case 'o':
            vogais[x] = letras[x];
            break;
        case 'O':
            vogais[x] = letras[x];
            break;
        case 'u':
            vogais[x] = letras[x];
            break;
        case 'U':
            vogais[x] = letras[x];
            break;
        default:
            consoantes[x] = letras[x];
            break;
    }
}

Console.WriteLine("\nVogais: ");
for (int y = 0; y <= 10; y++)
{
    Console.WriteLine(vogais[y]);
}

Console.WriteLine("\nConsoantes: ");
for (int z = 0; z <= 10; z++)
{
    Console.WriteLine(vogais[z]);
}