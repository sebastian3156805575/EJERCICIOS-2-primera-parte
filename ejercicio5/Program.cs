namespace ejercicio5
{
    public class program
    {
        public static void main()
        {
            double numero = 1, numero2 = 0;
            for (int c = 0; c < 10; c++)
            {
                numero2 = Math.Pow(numero, 2);
                numero++;
                Console.WriteLine(numero2);
            }

        }
    }
}