/*-------------------------------------------------------------------
Questão 5: Resgate no Labirinto
• Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua
em frente para resgatar um aliado ou recua, considerando a vida restante, o número de
armadilhas conhecidas no caminho e a distância do aliado.
• Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de
armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir
se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes
condições:
• Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente.
• Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for
menor que 10m, tentar resgate rápido.
• Caso contrário, recuar.


@Lista: 02 - Condicionais
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        double vida;
        int numeroArmadilhas, distanciaAliado;

        Console.Write("Digite a vida atual do personagem, em porcentagem (ex: 0,15): ");
        double.TryParse(Console.ReadLine(), out vida);

        Console.Write("Digite a quantidade de armadilhas conhecidas: ");
        int.TryParse(Console.ReadLine(), out numeroArmadilhas);

        Console.Write("Digite a distância do aliado, em metros: ");
        int.TryParse(Console.ReadLine(), out distanciaAliado);

        Console.Clear();

        if (vida > 0.5 && numeroArmadilhas < 3) {
            Console.WriteLine("Seguir em frente");
        }
        else if (vida < 0.5 && numeroArmadilhas < 2 && distanciaAliado < 10) {
            Console.WriteLine("Tentar resgate rápido");
        }
        else {
            Console.WriteLine("Recuar");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}