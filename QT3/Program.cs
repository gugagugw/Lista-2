/*-------------------------------------------------------------------
Questão 3: Loja de Poções
• Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
• Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
• Guerreiro recebe 10% de desconto na compra de poções de Vida.
• Mago recebe 15% de desconto na compra de poções de Mana.
• Paladino recebe 20% de desconto na compra de poções de Resistência.
• Exiba o preço total com e sem desconto.


@Lista: 02 - Condicionais
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
using System.Runtime.CompilerServices;
class Program {
    static void Main(string[] args) {
        int classe, quantidade, pocao;
        double desconto = 0, precoDescontado, preco;

        Console.WriteLine("Classe:\n1-Guerreiro  2-Mago   3-Paladino\nEscolha: ");
        int.TryParse(Console.ReadLine(), out classe);

        switch (classe) {
            case 1:
                desconto = 0.9;
            break;

            case 2:
                desconto = 0.85;
            break;

            case 3:
                desconto = 0.8;
            break;
        }

        Console.Write("Qual poção deseja comprar?\n1-Vida  2-Mana  3-Resistência\nEscolha: ");
        int.TryParse(Console.ReadLine(), out pocao);

        switch (pocao) {
            case 1:
                pocao = 10;
            break;

            case 2:
                pocao = 15;
            break;

            case 3:
                pocao = 20;
            break;
        }

        Console.Write("Digite quantas poções quer comprar: ");
        int.TryParse(Console.ReadLine(), out quantidade);

        preco = pocao * quantidade;
        precoDescontado = preco * desconto;

        Console.Clear();

        if (classe == 1 && pocao == 10 || classe == 2 && pocao == 15 || classe == 3 && pocao == 20) {
            Console.WriteLine($"O preço das poções é de: {preco} e o preço com o desconto de classe é de: {precoDescontado}");
        }
        else {
            Console.WriteLine($"O preço das poções é de: {preco} e não tem nenhum desconto aplicável");
        }


        

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}