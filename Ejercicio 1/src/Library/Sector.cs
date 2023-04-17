using System;
using System.Collections.Generic;


public class Sector
{
    public List<Estante> Estantes { get; set; }


    public Sector(List<Estante> estantes)
    {
        this.Estantes = estantes;
    }

    public void AgregarEstante(Estante estanteAAgregar)
    {
        this.Estantes.Add(estanteAAgregar);
    }

    public void QuitarEstante(Estante estanteAQuitar)
    {
        this.Estantes.Remove(estanteAQuitar);
    }

}

