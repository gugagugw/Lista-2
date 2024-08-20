/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
• Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
• Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
• Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
• Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
• Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.

@Lista: 02 - Condicionais
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
using System.Runtime.InteropServices;
class Program {
    static void Main(string[] args) {
        int escolha, defesa, penalidade, defesaIdeal = 0, adequada = 0, penalidadeIdeal = 0;

        Console.Write("Classe:\n1-Guerreiro  2-Arqueiro  3- Mago\nEscolha: ");
        int.TryParse(Console.ReadLine(), out escolha);

        switch (escolha) {
            case 1: 
                defesaIdeal = 50;
                penalidadeIdeal = 20;
            break;
            
            case 2:
                defesaIdeal = 30;
                penalidadeIdeal = 10;
            break;
            
            case 3:
                defesaIdeal = 20;
                penalidadeIdeal = 40;
            break;
        }

        Console.Write("\nDigite a defesa: ");
        int.TryParse(Console.ReadLine(), out defesa);

        if (defesa > defesaIdeal) {
            adequada++;
        }
        
        Console.Write("\nDigite a penalidade: ");
        int.TryParse(Console.ReadLine(), out penalidade);

        if (penalidade < penalidadeIdeal) {
            adequada++;
        }

        if (adequada == 2) {
            Console.Clear();
            Console.WriteLine("Armadura adequada");
        }
        else {
            Console.Clear();
            Console.WriteLine("Armadura não adequada");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}