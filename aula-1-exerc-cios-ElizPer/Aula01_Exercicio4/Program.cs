// See https://aka.ms/new-console-template for more information
/*
Exercício 4
Escreva um programa para calcular a área de um círculo. A área de um círculo é dada pela
seguinte fórmula:
                                    𝐴 = 𝜋𝑟2
O valor do raio r será digitado pelo usuário (assumir que serão digitados apenas valores
positivos).
 */

Console.WriteLine("Digite o valor do raio (r) do circulo: ");
double raio;
raio = double.Parse(Console.ReadLine());

double area;
double pi = Math.PI;
area = pi * Math.Pow(raio,2);
Console.WriteLine("A area do circulo é: " + area.ToString(".0000"));