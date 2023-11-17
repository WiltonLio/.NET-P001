// 2.Tipos de Dados:
// Problema: Quais são os tipos de dados numéricos inteiros disponíveis no .NET? Dê exemplos de uso para cada um deles
// através de exemplos.

#region Tipos de Dados

int TipoInt = 42;
Console.WriteLine($"Tipo int: {TipoInt}");
long TipoLong = 1234567890123456;
Console.WriteLine($"Tipo long: {TipoLong}");
short TipoShort = 32767;
Console.WriteLine($"Tipo short: {TipoShort}");
byte TipoByte = 255;
Console.WriteLine($"Tipo byte: {TipoByte}");
sbyte TipoSByte = -128;
Console.WriteLine($"Tipo sbyte: {TipoSByte}");
ushort TipoUShort = 65535;
Console.WriteLine($"Tipo ushort: {TipoUShort}");
uint TipoUInt = 4294967295;
Console.WriteLine($"Tipo uint: {TipoUInt}");
ulong TipoULong = 18446744073709551615;
Console.WriteLine($"Tipo ulong: {TipoULong}");

#endregion

// 3.Conversão de Tipos de Dados:
// Problema: Suponha que você tenha uma variável do tipo double e deseja convertê-la em um tipo int. Como você faria essa
// conversão e o que aconteceria se a parte fracionária da variável double não pudesse ser convertida em um int? Resolva o 
// problema através de um exemplo em C#.

#region Conversão de Tipos de Dados
double numeroDouble = 9.37;
int numeroInteiro;

numeroInteiro = (int)numeroDouble;
Console.WriteLine("Número double: " + numeroDouble);
Console.WriteLine("Número inteiro depois da conversão: " + numeroInteiro);

#endregion

// 4.Operadores Aritméticos:
// Problema: Dada a variável int x = 10 e a variável int y = 3, escreva código para calcular e exibir o resultado da adição,
// subtração, multiplicação e divisão de x por y.

#region Operadores Aritiméticos

int x = 10;
int y = 3;
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
Console.WriteLine($"Adição: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");

#endregion

// 5.Operadores de Comparação:
// Problema: Considere as variáveis int a = 5 e int b = 8. Escreva código para determinar se a é maior que b e exiba o resultado.

#region Operadores de Comparação

int a = 5;
int b = 8;
string comparacao = a > b ? "Valor de A é maior que B" : "Valor de B é maior que A";

Console.WriteLine(comparacao);

#endregion

// 6.Operadores de Igualdade:
// Problema: Você tem duas strings, string str1 = "Hello" e string str2 = "World". Escreva código para verificar se as duas
// strings são iguais e exibir o resultado.

#region Operadores de Igualdade

string str1 = "Hello";
string str2 = "World";
string compare;
compare = str1 == str2 ? "São iguais" : "Não são iguais";
Console.WriteLine(compare);

#endregion

// 7.Operadores Lógicos:
// Problema: Suponha que você tenha duas variáveis booleanas, bool condicao1 = true e bool condicao2 = false. Escreva código
// para verificar se ambas as condições são verdadeiras e exiba o resultado.

// 8.Desafio de Mistura de Operadores:
// Problema: Dadas as variáveis int num1 = 7, int num2 = 3, e int num3 = 10, escreva código para verificar se num1 é maior do
// que num2 e se num3 é igual a num1 + num2.