using System;
class desafio02
{
    static void Main()
    {
    while (true)
        { int opcao;

            do {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nSelecione a opção desejada:");
                Console.ResetColor();
                Console.WriteLine("1 = Perfil do personagem");
                Console.WriteLine("2 = Perfil da entidade filantrópica");
                Console.WriteLine("3 = Relação do personagem com a entidade");
                Console.WriteLine("Qualquer outro número inteiro = pular esse tópico");
                   opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nNome: Gaara \nIdade:16 \nOfício:Kazekage da Vila da Areia ");
                        break;

                    case 2:
                        Console.WriteLine("\nNome: Orfanato Kibō (esperança em japonês) \nObjetivo: oferecer apoio à crianças orfãs vítimas da guerra ninja");
                        break;

                    case 3:
                        Console.WriteLine("\nGaara é um voluntário que trabalha como um mentor (ele aprendeu o 'Jutsu do Discurso' com o Naruto afinal :D )");
                        break;

                    default:
                        Console.WriteLine("\nPulando tópico...");
                        break;
                } } while (opcao >= 1 && opcao < 4);

            Console.WriteLine("\nUma criança está perdida, você pode ajudar a encontrá-la? Ela pode estar em até 8 regiões de Sunagakure, insira um número de 1 a 8");
            int busca;
            do {
                busca = int.Parse(Console.ReadLine());

                if (busca < 3) {
                    Console.WriteLine($"{busca}? Acho que ela está bem perto, talvez um número maior?");
                        }
                else if (busca > 3)
                {
                    Console.WriteLine($"{busca}? A viagem deve ter sido cansativa, talvez um número menor?");
                }
                else
                {
                    Console.BackgroundColor= ConsoleColor.Green;
                    Console.ForegroundColor= ConsoleColor.Black;
                    Console.WriteLine("VOCÊ A ENCONTROU, ela está na 'Região 3', mas conhecida como LESTE da vila (você percebeu que são 8 pontos cardeais? :D )");
                    Console.ResetColor();
                }
            } while (busca != 3);

            Console.WriteLine("\nAo longo da semana, você visitou o orfanato todos os 7 dias! Pode me passar o relatório?");

            for (int i = 0; i < 7; i++) {
                Console.WriteLine($"\nDia: {i + 1}...O que você fez hoje?");
                string cotidiano = Console.ReadLine();
            }
            Console.WriteLine("\nTenho certeza que as crianças gostaram! É muito gratificante ter alguém tão importante se voluntariando para ajudar o próximo, obrigada e até mais!  ");
            
        }
    }
}
