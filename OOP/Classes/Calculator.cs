namespace OOP.Classes
{
    class Calculator
    {
        public static double Pi = 3.14;

        public static double Circuference(double raio)
        {
            return 2.0 * Pi * raio;   
        }
        
        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);   
        }

        public static void TripleRef(ref int num)
        {
            num *= 3; 
        }

        public static void TripleOut(int num, out int result)
        {
          result = num * 3;
        }


    }
}
