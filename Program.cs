using System;
using ListaBISuperCompacta.BibliotecaListaBI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBISuperCompacta
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBI = new ListaBI();
            Console.WriteLine("digite o nome que deseja pesquisar");

            listaBI.PesquisaLista(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
