namespace ejercicio5Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fecha;
            Console.WriteLine("Introduzca una fecha en formato dd/mm/yyyy hh:mm:ss");
            fecha = Console.ReadLine();
            DateTime fecha1 = Convert.ToDateTime(fecha);

            Console.WriteLine("Introduzca otra fecha en formato dd/mm/yyyy");
            fecha = Console.ReadLine();
            DateTime fecha2 = Convert.ToDateTime(fecha);

            TimeSpan difFechas = fecha2 - fecha1;

            int dias = difFechas.Days;
            int horas = (int)difFechas.TotalHours;
            int minutos= (int)difFechas.TotalMinutes;
            int segundos= (int)difFechas.TotalSeconds;

            Console.WriteLine("La diferencia es de " + dias + "dias, " +  horas + " horas, " + minutos + "minutos y" + segundos + " segundos.");  
        }
    }
}