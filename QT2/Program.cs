/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
• Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma
batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos
derrotados, a duração da batalha e se o jogador sofreu danos crítico.
• Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve
receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador
sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma:
• 10 pontos para cada inimigo derrotado;
• Subtraia 10 pontos se a batalha durar mais de 5 minutos;
• Subtraia 10 pontos se o jogador sofreu dano crítico;


@Lista: 02 - Condicionais
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int inimigos, tempoBatalha, pontos = 0, escolha;
        const int limite = 100;
        bool tomouCrit = false;

        Console.Write("Digite quantos inimigos foram derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos);

        Console.Write("Digite quantos minutos a batalha durou: ");
        int.TryParse(Console.ReadLine(), out tempoBatalha);

        if (tempoBatalha > 5) {
            pontos -= 10;
        }

        Console.Write("O jogador tomou dano crítico?\n1-Sim   2-Não ");
        int.TryParse(Console.ReadLine(), out escolha);

        switch (escolha) {
            case 1:
                tomouCrit = true;
            break;

            case 2:
                tomouCrit = false;
            break;
        }

        if (tomouCrit == true) {
            pontos =- 10;
        }

        pontos = inimigos * 10 + pontos;

        if (pontos > limite) {
            pontos = limite;
        }

        Console.Clear();
        Console.WriteLine($"A quantidade de pontos é de: {pontos}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}