// See https://aka.ms/new-console-template for more information
/*
Exercício 3
Escreva um programa que faça a leitura de uma frase, que pode ser uma citação, um ditado
ou um excerto de um texto. Ao final, escreva a frase digitada e, em uma nova linha, o número
de caracteres desta frase.
 */
string frase;

Console.WriteLine("Digite sua frase abaixo:");
frase = Console.ReadLine();

Console.WriteLine("O usuário digitou: " + frase);
Console.WriteLine("A frase digitada possui: " + frase.Length + " caracteres");