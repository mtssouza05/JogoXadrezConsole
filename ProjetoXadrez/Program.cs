using ProjetoXadrez;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


Sistema sis = new Sistema();
List<Jogador> jogadores = new List<Jogador>();




for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Primeiro cadastre os jogadores: ");
    Jogador jogador = new Jogador();
    Console.WriteLine($"Jogador {i + 1} {jogador.Nome} cadastrado com sucesso !\n");
    jogadores.Add( jogador );
}

sis.ShowRegras();
Console.WriteLine();

int cont = 0;

while (true)
{
    Console.ReadLine();
    Console.Clear();
    if (cont <= 2)
    {
        cont += 1;
        if (cont == 1)
        {
            sis.ShowTabuleiro();
            Console.WriteLine($"Jogador {cont}");

            Console.WriteLine("Linha inicial da peça a ser mexida: ");
            int linhaI = int.Parse(Console.ReadLine());

            Console.WriteLine("Coluna inicial da peça a ser mexida: ");
            int colunaI = int.Parse(Console.ReadLine());

            Console.WriteLine("Linha destino da peça a ser mexida: ");
            int linhaF = int.Parse(Console.ReadLine());

            Console.WriteLine("Coluna destino da peça a ser mexida: ");
            int colunaF = int.Parse(Console.ReadLine());

            int op = sis.MoverPecaBranca(linhaI, colunaI, linhaF, colunaF);


            if (op == 1)
            {
                Console.WriteLine("Peça movida com sucesso");
            }
            else if (op == 2)
            {
                Console.WriteLine("Movimento impossível");

            }
            else if (op == -1)
            {
                Console.WriteLine("Check - Mate ! Rei Morto !");
                Console.WriteLine("Jogador 1 ganhou !!");
                sis.Save(jogadores[0].Nome, 1);

               
                break;
            }
           
        



        else if (op == -2)
        {
            Console.WriteLine("Todas as peças foram capturadas ! Fim de Jogo! ");
            Console.WriteLine("Jogador 1 ganhou !!");
            sis.Save(jogadores[0].Nome, 1);

            break;
        }
        else if (op == 0)
        {
            Console.WriteLine("Número de linhas ou colunas inválidos !");
        }
        }
        else if(cont == 2)
        {
            sis.ShowTabuleiro();
            Console.WriteLine($"Jogador {cont}");

            Console.WriteLine("Linha inicial da peça a ser mexida: ");
            int linhaI = int.Parse(Console.ReadLine());

            Console.WriteLine("Coluna inicial da peça a ser mexida: ");
            int colunaI = int.Parse(Console.ReadLine());

            Console.WriteLine("Linha destino da peça a ser mexida: ");
            int linhaF = int.Parse(Console.ReadLine());

            Console.WriteLine("Coluna destino da peça a ser mexida: ");
            int colunaF = int.Parse(Console.ReadLine());

            int op = sis.MoverPecaPreta(linhaI, colunaI, linhaF, colunaF);


            if (op == 1)
            {
                Console.WriteLine("Peça movida com sucesso");
            }
            else if (op == 2)
            {
                Console.WriteLine("Movimento impossível");

            }
            else if (op == -1)
            {
                Console.WriteLine("Check - Mate ! Rei Morto !");
                Console.WriteLine("Jogador 2 ganhou !!");
                sis.Save(jogadores[1].Nome, 1);

                break;
            }
            else if (op == -2)
            {
                Console.WriteLine("Todas as peças foram capturadas ! Fim de Jogo! ");
                Console.WriteLine("Jogador 2 ganhou !!");
                sis.Save(jogadores[1].Nome, 1);


                break;
            }
            else if (op == 0)
            {
                Console.WriteLine("Número de linhas ou colunas inválidos !");
            }



            cont = 0;
        }






    }

}

Console.WriteLine("Histórico");
sis.ShowJson();

    












