using System;


public class Libro
{

    public string Title { get; }
    public string Author { get; }
    public string Code { get; }

    public Libro(string title, string author, string code)
    {
        this.Title = title;
        this.Author = author;
        this.Code = code;
    }
}

