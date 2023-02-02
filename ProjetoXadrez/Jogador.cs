using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez
{
    public class Jogador
    {
        public string Nome { get; set; } = null!;
        public double Pontuacao { get; set; }

        public Jogador()
        {
            Console.Write("Digite o Nome do jogador: ");
            Nome = Console.ReadLine();
            Pontuacao = 0;
                       
        }
        
    }
}
