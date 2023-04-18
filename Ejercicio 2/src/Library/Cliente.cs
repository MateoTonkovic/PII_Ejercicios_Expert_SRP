using System;
using System.Text;

class Cliente
{
    public String nombre { get; }
    public String id { get; }
    public String numeroTelefonico { get; }

    public Boolean isValid { get; } = true;

    public StringBuilder errorString { get; } = new StringBuilder("");

    public Cliente(string nombre, string id, string numeroTelefonico)
    {

        if (string.IsNullOrEmpty(nombre))
        {
            this.errorString.Append("Unable to schedule appointment, 'name' is required\n");
            this.isValid = false;
        }

        if (string.IsNullOrEmpty(id))
        {
            errorString.Append("Unable to schedule appointment, 'id' is required\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(numeroTelefonico))
        {
            errorString.Append("Unable to schedule appointment, 'phone number' is required\n");
            isValid = false;
        }


        this.nombre = nombre;
        this.id = id;
        this.numeroTelefonico = numeroTelefonico;
    }
}