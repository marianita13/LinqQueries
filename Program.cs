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
        //IMPRIMIR TODA EL DICCIONARIO
        // ImprimirValores(queries.Allcolection());

        //IMPRIMIR TODOS LOS LIBROS DESPUES DEL 2000
        // ImprimirValores(queries.LibrosDespues2000());

        //LIBROS DE ANDROID
        // ImprimirValores(queries.LibrosAndroid());

        //LIBROS DE ANDROID Y DE MAS DE 250 PAGINAS
        // ImprimirValores(queries.LibrosAndroidY250Pag());

        //VALIDAR QUE TODOS TIENEN STATUS
        // bool valor = queries.ValidadStatus();
        // if (valor==true) Console.WriteLine("Todos los valores tienen Status");
        // else{ Console.WriteLine("Al menos un valor no tiene status");}

        //IMPRIMIR LOS LIBROS PUBLICADOS LUEGO DEL 2005
        // bool año2005 = queries.Año2005();
        // if (año2005==true) ImprimirValores(queries.Libros2005());
        // else{ Console.WriteLine("Ningun libro fue publicado en 2005");}

        //TODOS LOS LIBROS CON LA CATEGORIA DE PYTHON
        // ImprimirValores(queries.PythonBooks());

        //TODOS LOS LIBROS CON CATEGORIA JAVA ORDENADOS POR NOMBRE
        // ImprimirValores(queries.JavaOrder());

        //RETORNA LOS LIBROS CON MAS DE 450 PAGINAS ORDENADOS DE FORMA DESCENDENTE
        //ImprimirValores(queries.JavaOrderDesc());

        //RETORNA 
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