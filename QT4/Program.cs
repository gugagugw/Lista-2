/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
• Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
• Mana maior que 30.
• Vida do inimigo menor que 50%.
• Nível do jogador maior que 5.


@Lista: 02 - Condicionais
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int mana, nivel, atkFalha = 0, atkEspecial = 0;
        double vidaInimigo;

        Console.Write("Digite a quantidade de mana que você tem atualmente: ");
        int.TryParse(Console.ReadLine(), out mana);

        if (mana < 30) {
            atkFalha = 1;
        }
        else {
            atkEspecial++;
        }

        Console.Write("Digite a vida do inimigo em porcentagem (ex: 0,15): ");
        double.TryParse(Console.ReadLine(), out vidaInimigo);

        if (vidaInimigo > 0.5) {
            atkFalha = 2;
        }
        else {
            atkEspecial++;
        }

        Console.Write("Digite o seu nível atual: ");
        int.TryParse(Console.ReadLine(), out nivel);

        if (nivel < 5) {
            atkFalha = 3;
        }
        else {
            atkEspecial++;
        }

        Console.Clear();

        if (atkEspecial == 3) {
            Console.WriteLine("Ataque Especial Realizado");
        }
        else if (atkFalha == 1) {
            Console.WriteLine("Mana Insuficiente");
        }
        else if (atkFalha == 2) {
            Console.WriteLine("Vida do inimigo muito alta");
        }
        else {
            Console.WriteLine("Nível Insuficiente");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}