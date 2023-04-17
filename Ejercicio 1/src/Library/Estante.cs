using System;
using System.Collections.Generic;


public class Estante
{
    public List<Libro> Libros = new List<Libro>();

    public void AgregarLibro(Libro LibroAAgregar)
    {
        this.Libros.Add(LibroAAgregar);
    }

    public void QuitarLibro(Libro LibroAQuitar)
    {
        this.Libros.Remove(LibroAQuitar);
    }

}
