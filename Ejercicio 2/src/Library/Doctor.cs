using System;
using System.Text;

class Doctor
{
    public string nombre { get; }

    public Boolean isValid { get; } = true;

    public StringBuilder errorString { get; } = new StringBuilder("");

    public Doctor(string nombre)
    {


        if (string.IsNullOrEmpty(nombre))
        {
            errorString.Append("Unable to schedule appointment, 'doctor name' is required\n");
            isValid = false;
        }

        this.nombre = nombre;
    }
}