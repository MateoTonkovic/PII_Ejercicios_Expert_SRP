using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "12321", "5555-555-555", DateTime.Now, "Wall ", "");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "091091091", "5555-555-555", DateTime.Now, "Queen Street", "asdsada");
            Console.WriteLine(appointmentResult2);
        }
    }
}
