//2. (Vetores Vogais e Consoantes) Faça um vetor de caracteres de 10 posições e imprima os seguintes itens:
//a) somente as vogais;
//b) somente as consoantes;

char[] vogais = new char[10];
char[] consoantes = new char[10];
char[] letras = new char[10];
char letra;
int contador_letras = 1, contator_vogais = 0, contador_consoantes = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"{contador_letras}º letra: ");
    letra = char.Parse(Console.ReadLine());
    letras[i] = letra;
    contador_letras++;
}

for (int x = 0; x < 10; x++)
{
    switch (letras[x])
    {
        case 'a':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'A':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'e':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'E':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'i':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'I':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'o':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'O':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'u':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        case 'U':
            vogais[x] = letras[x];
            contator_vogais += 1;
            break;
        default:
            consoantes[x] = letras[x];
            contador_consoantes += 1;
            break;
    }
}

Console.WriteLine("\nVogais: ");
for (int y = contator_vogais; y >= 0; y--)
{
    Console.WriteLine(vogais[y]);
}

Console.WriteLine("\nConsoantes: ");
for (int z = contador_consoantes; z >= 0; z--)
{
    Console.WriteLine(consoantes[z]);
}