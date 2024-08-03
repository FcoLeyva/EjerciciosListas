namespace EjerciciosListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> diasSemana = new List<string>();
            diasSemana.Add("1.-Lunes");
            diasSemana.Add("Martes");
            diasSemana.Add("MIercoles");
            diasSemana.Add("Jueves");
            diasSemana.Add("Viernes");
            diasSemana.Add("Sabado");
            diasSemana.Add("Domingo");
            foreach (string dia in diasSemana)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine("Dame el numero de dia");
            string diaUsuario = Console.ReadLine();
            Console.WriteLine(diasSemana[int.Parse(diaUsuario) - 1]);
            Console.WriteLine(((int)DateTime.Now.DayOfWeek));
            Console.WriteLine(diasSemana[((int)DateTime.Now.DayOfWeek)]);

        }
    }
}
