// See https://aka.ms/new-console-template for more information
/*Exercício 2
Escreva um programa que faça a leitura do nome, da idade, da altura e e do peso do usuário.
Após isso, escreva cada uma das informações em uma linha no console.*/

using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

//NOME
Console.WriteLine("Digine seu nome");
string nome;
nome = Console.ReadLine();

//IDADE
Console.WriteLine("Digine sua idade");
int n;
var idade = Console.ReadLine();
bool eNumeroIdade = int.TryParse(idade, out n);
while (eNumeroIdade == false)
{
    Console.WriteLine("Digine sua idade novamente, somente números");
    idade = Console.ReadLine();
    eNumeroIdade = int.TryParse(idade, out n);
}

//ALTURA
Console.WriteLine("Digine sua altura");
double nro;
var altura = Console.ReadLine(); ;
bool eNumeroAltura = double.TryParse(altura, out nro);
while (eNumeroAltura == false)
{
    Console.WriteLine("Digine sua altura novamente, somente números");
    altura = Console.ReadLine();
    eNumeroAltura = double.TryParse(altura, out nro);
}

//PESO
Console.WriteLine("Digine seu peso");
var peso = Console.ReadLine();
bool eNumeroPeso = double.TryParse(peso, out nro);
while(eNumeroPeso == false)
{
    Console.WriteLine("Digite seu peso novamente, somente números");
    peso = Console.ReadLine();
    eNumeroPeso = double.TryParse(peso, out nro);
}

Console.WriteLine("\nDados digitados:");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade} anos");
Console.WriteLine($"Altura: {altura}");
Console.WriteLine($"Peso: {peso}Kg");