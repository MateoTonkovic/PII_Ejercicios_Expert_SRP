using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;


            Cliente cliente = new Cliente(name, id, phoneNumber);
            Doctor doctor = new Doctor(doctorName);
            Reserva reserva = new Reserva(date, appoinmentPlace);

            if (!cliente.isValid)
            {
                stringBuilder.Append(cliente.errorString);
                isValid = false;
            }
           
            if (!doctor.isValid)
            {
                stringBuilder.Append(doctor.errorString);
                isValid = false;
            }

            if (!reserva.isValid)
            {
                stringBuilder.Append(reserva.errorString);
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
