namespace ejercicio2
{
    public class program
    {
        public static void Main()
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            int sum;
            double media;
            int produc;

            Console.WriteLine("ingrese el primer nuero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer nuero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer nuero");
            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer nuero");
            numero4 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el primer nuero");
            numero1 = int.Parse(Console.ReadLine());

            produc = numero1 * numero2 * numero3 * numero4;
            sum = numero1 + numero2 + numero3 + numero4;
            media = sum / 4;

            Console.WriteLine($"el resultado de la suma es {sum},el de la media es {media}, y el rodducto {produc}"); 

        }
    }
}
