using System;
using System.Threading.Channels;

namespace SpotFry
{
    class Musicas
    {
        public string nomeDaMusica = "";
        public string artista = "";
        public string generoDaMusica = "";

        public Musicas(string nomeDaMusica, string artista, string generoDaMusica) 
        {
            this.nomeDaMusica = nomeDaMusica;
            this.artista = artista;
            this.generoDaMusica = generoDaMusica;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int decicao;

            Console.WriteLine("escolha o que quer fazer");
            Console.WriteLine("1 - guardar musicas");
            Console.WriteLine("2 - escolher musica");
            Console.WriteLine("3 - sair");
            decicao = Convert.ToInt32(Console.ReadLine());

            if (decicao == 1)
                GuardarMusicas();
            if (decicao == 2)
                EscolherMusicas();
            if (decicao == 3)
                Sair();

            void GuardarMusicas()
            {
                Console.WriteLine("guardando musicas");
            }

            void EscolherMusicas()
            {
                Console.WriteLine("escolher musicas para ver detalhes dela");
            }

            void Sair()
            {
                Console.WriteLine("Muito obrigado pela participação, até mais");
            }
        }
    }
}