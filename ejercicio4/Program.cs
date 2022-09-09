namespace ejercicio4
{
    public class program
    {
        public static void Maind()
        {
            int contador;
            int  sumatoria;
            int limite;

            sumatoria = 0;
            contador = 1;
            limite = 10;
            for (contador = 1; contador <= limite; contador++)
            {
                sumatoria = sumatoria + contador;
                Console.WriteLine($"el resultado de los numeros es:{sumatoria}");
            }





        }
    }

}
