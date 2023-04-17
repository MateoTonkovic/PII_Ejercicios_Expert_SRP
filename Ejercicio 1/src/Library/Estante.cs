using System.Collections.Generic;


public class Estante
{
    public Dictionary<string, Libro> Libros = new Dictionary<string, Libro>();

    public void AgregarLibro(string LugarLibro, Libro LibroAAgregar)
    {
        this.Libros.Add(LugarLibro, LibroAAgregar);
    }

    public void QuitarLibro(string Lugar)
    {
        this.Libros.Remove(Lugar);
    }
}
