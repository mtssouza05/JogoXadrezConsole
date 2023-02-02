using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez
{
    public class Sistema
    {

        public void ShowRegras()
        {
            Console.WriteLine("O jogador 1 sempre será a peça branca !");
            Console.WriteLine("As peças brancas serão as letras maiusculas");
            Console.WriteLine("A inicial se refere a peça");
        }


        char[,] tabuleiro = { {'T', 'C', 'B', 'Q', 'K', 'B', 'C', 'T' }, 
                              {'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                              {'-', '-', '-', '-', '-', '-', '-', '-' },
                              {'-', '-', '-', '-', '-', '-', '-', '-' },
                              {'-', '-', '-', '-', '-', '-', '-', '-' },
                              {'-', '-', '-', '-', '-', '-', '-', '-' },
                              {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                              {'t', 'c', 'b', 'q', 'k', 'b', 'c', 't' } };

        public void ShowTabuleiro()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($" {tabuleiro[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        public int MoverPecaBranca(int lOrigem, int cOrigem, int lFinal, int cFinal)
        {           
            int deslocV = Math.Abs(lFinal - lOrigem);
            int deslocH = Math.Abs(cFinal - cOrigem) ;
            int mover = 0;

            if (lOrigem >= 0 && lFinal < 8 && cOrigem >= 0 && cFinal < 8)
            {
                char peca = tabuleiro[lOrigem, cOrigem];

                if ((peca == 'T') && (deslocV == 0 || deslocH == 0))
                {
                    mover = 1;
                }

                else if ((peca == 'B') && (deslocV == deslocH))
                {
                    mover = 1;
                }

                else if ((peca == 'C') && (deslocV == 1 && deslocH == 2) || (deslocH == 1 && deslocV == 2))
                {
                    mover = 1;
                }

                else if ((peca == 'Q') && (deslocV == 0 || deslocH == 0) || (deslocV == deslocH))
                {
                    mover = 1;
                }

                else if ((peca == 'K') && (deslocV >= 0 && deslocV <= 1) && (deslocH <= 1 && deslocH == 0))
                {
                    mover = 1;
                }

                else if ((peca == 'P') && (lFinal - lOrigem == 1) && (deslocH == 0))
                {
                    mover = 1;
                }

                if ((peca != 'P') && (tabuleiro[lFinal - 1, cFinal] == '-'))
                {

                    if ((mover == 1 && tabuleiro[lFinal, cFinal] != 'P' && tabuleiro[lFinal, cFinal] != 'C' && tabuleiro[lFinal, cFinal] != 'T' && tabuleiro[lFinal, cFinal] != 'B' && tabuleiro[lFinal, cFinal] != 'Q' && tabuleiro[lFinal, cFinal] != 'K') && (tabuleiro[lFinal, cFinal] != 'P'))
                    {
                        char aux = tabuleiro[lFinal, cFinal];
                        tabuleiro[lFinal, cFinal] = tabuleiro[lOrigem, cOrigem];
                        tabuleiro[lOrigem, cOrigem] = '-';

                        if (aux == 'k')
                        {
                            return -1;
                        }

                        bool existe = false;

                        foreach (var valor in tabuleiro)
                        {
                            if (valor == 't' || valor == 'c' || valor == 'b' || valor == 'p' || valor == 'q' || valor == 'k')
                            {
                                existe = true;
                            }
                        }

                        if (!existe)
                        {
                            return -2;
                        }
                        else
                            return 1;
                    }
                    else
                        return 2;
                }
                else if ((peca == 'P') && (tabuleiro[lFinal + 1, cFinal] == '-'))
                {
                    if (mover == 1 && tabuleiro[lFinal, lFinal] != 'P' && tabuleiro[lFinal, lFinal] != 'C' && tabuleiro[lFinal, lFinal] != 'T' && tabuleiro[lFinal, lFinal] != 'B' && tabuleiro[lFinal, lFinal] != 'Q' && tabuleiro[lFinal, lFinal] != 'K')
                    {
                        char aux = tabuleiro[lFinal, cFinal];
                        tabuleiro[lFinal, cFinal] = tabuleiro[lOrigem, cOrigem];
                        tabuleiro[lOrigem, cOrigem] = '-';

                        if (aux == 'k')
                        {
                            return -1;
                        }

                        bool existe = false;

                        foreach (var valor in tabuleiro)
                        {
                            if (valor == 't' || valor == 'c' || valor == 'b' || valor == 'p' || valor == 'q' || valor == 'k')
                            {
                                existe = true;
                            }
                        }

                        if (!existe)
                        {
                            return -2;
                        }
                        else
                            return 1;
                    }
                    else
                        return 2;
                }
                else return 2;
              
            }
            else
                return 0;


      
        
        
        }




        public int MoverPecaPreta(int lOrigem, int cOrigem, int lFinal, int cFinal)
        {
            int deslocV = Math.Abs(lFinal - lOrigem);
            int deslocH = Math.Abs(cFinal - cOrigem);
            int mover = 0;

            if (lOrigem >= 0 && lFinal < 8 && cOrigem >= 0 && cFinal < 8)
            {
                char peca = tabuleiro[lOrigem, cOrigem];

                if ((peca == 't') && (deslocV == 0 || deslocH == 0))
                {
                    mover = 1;
                }

                else if ((peca == 'b') && (deslocV == deslocH))
                {
                    mover = 1;
                }

                else if ((peca == 'c') && (deslocV == 1 && deslocH == 2) || (deslocH == 1 && deslocV == 2))
                {
                    mover = 1;
                }

                else if ((peca == 'q') && (deslocV == 0 || deslocH == 0) || (deslocV == deslocH))
                {
                    mover = 1;
                }

                else if ((peca == 'k') && (deslocV >= 0 && deslocV <= 1) && (deslocH <= 1 && deslocH == 0))
                {
                    mover = 1;
                }

                else if ((peca == 'p') && (lFinal - lOrigem == -1) && (deslocH == 0))
                {
                    mover = 1;
                }

                if (tabuleiro[lFinal - 1, cFinal] == '-')
                {

                    if ((mover == 1 && tabuleiro[lFinal, cFinal] != 'p' && tabuleiro[lFinal, cFinal] != 'c' && tabuleiro[lFinal, cFinal] != 't' && tabuleiro[lFinal, cFinal] != 'b' && tabuleiro[lFinal, cFinal] != 'q' && tabuleiro[lFinal, cFinal] != 'k') && (tabuleiro[lFinal, cFinal] != 'p'))
                    {
                        char aux = tabuleiro[lFinal, cFinal];
                        tabuleiro[lFinal, cFinal] = tabuleiro[lOrigem, cOrigem];
                        tabuleiro[lOrigem, cOrigem] = '-';

                        if (aux == 'K')
                        {
                            return -1;
                        }

                        bool existe = false;

                        foreach (var valor in tabuleiro)
                        {
                            if (valor == 'T' || valor == 'C' || valor == 'B' || valor == 'P' || valor == 'Q' || valor == 'K')
                            {
                                existe = true;
                            }
                        }

                        if (!existe)
                        {
                            return -2;
                        }
                        else
                            return 1;
                    }
                    else
                        return 2;
                }
                else return 2;

            }
            else
                return 0;





        }


        public void Save(string? name, int point)
        {
            Jogador player = new Jogador { Nome = name, Pontuacao = point };
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "json.txt");
            File.WriteAllText(filePath, JsonConvert.SerializeObject(player));
        }



        public void ShowJson()
        {
            string showjson = File.ReadAllText(@"C:\Users\matth\OneDrive\Documentos\json.txt");
            var playerjson = JsonConvert.DeserializeObject<Jogador>(showjson);
            Console.WriteLine($"Nome: {playerjson.Nome} || Pontuação: {playerjson.Pontuacao}");
        }


    }

      
    
}
