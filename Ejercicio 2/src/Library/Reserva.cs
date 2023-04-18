using System;
using System.Text;

class Reserva
{
    public DateTime fecha { get; }
    public string lugar { get; }

    public Boolean isValid { get; } = true;

    public StringBuilder errorString { get; } = new StringBuilder("");


    public Reserva(DateTime fecha, string lugar)
    {
        if (string.IsNullOrEmpty(lugar))
        {
            errorString.Append("Unable to schedule appointment, 'appoinment place' is required\n");
            isValid = false;
        }

        this.fecha = fecha;
        this.lugar = lugar;
    }


}