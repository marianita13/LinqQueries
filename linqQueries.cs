using NuevoProyecto;

public class linqQueries
{
    List<Book> listaBooks = new();

    public linqQueries(){
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.listaBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true}) ?? new List<Book>();
        }
    } 

    public IEnumerable<Book> Allcolection(){
        return listaBooks;
    }

    public IEnumerable<Book> LibrosDespues2000(){
        return from book in listaBooks where book.PublishedDate.Year >2000 select book;
    }

    public IEnumerable<Book> LibrosAndroid(){
        return from book in listaBooks where (book.Title.Contains("Android")) select book;
    }

    public IEnumerable<Book> LibrosAndroidY250Pag(){
        return from book in listaBooks where book.Title.Contains("Android") & book.PageCount>250 select book;
    }

    public bool ValidadStatus(){
        return listaBooks.All(book => book.Status != string.Empty);
    }

    public bool Año2005(){
        return listaBooks.Any(book => book.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> Libros2005(){
        return from book in listaBooks where book.PublishedDate.Year == 2005 select book;
    }

    public IEnumerable<Book> PythonBooks(){
        return from book in listaBooks where book.Categories.Contains("Python") select book;
    }

    public IEnumerable<Book> JavaOrder(){
        return from book in listaBooks where book.Categories.Contains("Java") orderby book.Title select book;
    }

    public IEnumerable<Book> JavaOrderDesc(){
        return from book in listaBooks where book.PageCount>=450 orderby book.PageCount descending select book;
    }

    public IEnumerable<Book> LibrosRecientes(){
        return from book in listaBooks.Take[3]
    }
}
