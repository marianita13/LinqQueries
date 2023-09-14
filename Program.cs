using System.Net.Quic;
using System;
using NuevoProyecto;
internal class Program
{
    private static void Main(string[] args)
    {
        int ? [] args2 = new int?[5];
        Console.WriteLine(args2[0]);
        linqQueries queries = new();
        // ImprimirValores(queries.Allcolection());

        // ImprimirValores(queries.LibrosDespues2000());

        // ImprimirValores(queries.LibrosAndroid());

        // ImprimirValores(queries.LibrosAndroidY250Pag());

        // bool valor = queries.ValidadStatus();
        // if (valor==true) Console.WriteLine("Todos los valores tienen Status");
        // else{ Console.WriteLine("Al menos un valor no tiene status");}

        // bool año2005 = queries.Año2005();
        // if (año2005==true) ImprimirValores(queries.Libros2005());
        // else{ Console.WriteLine("Ningun libro fue publicado en 2005");}

        // ImprimirValores(queries.PythonBooks());

        // ImprimirValores(queries.JavaOrder());
        ImprimirValores(queries.JavaOrderDesc());
    }

    private static void ImprimirValores(IEnumerable<Book> books){
        int registros = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N paginas", "Fecha publicacion");
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.White;
            registros++;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate);
        }
    }
}