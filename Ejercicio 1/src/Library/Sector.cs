using System;
using System.Collections.Generic;


public class Sector
{
    public Dictionary<string, Estante> Estantes = new Dictionary<string, Estante>();

    public void AgregarEstante(string LugarDeEstante, Estante estanteAAgregar)
    {
        this.Estantes.Add(LugarDeEstante, estanteAAgregar);
    }

    public void QuitarEstante(string LugarDeEstante)
    {
        this.Estantes.Remove(LugarDeEstante);
    }

}

