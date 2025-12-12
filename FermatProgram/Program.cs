using static System.Console;

namespace FermatProgram
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 4, c = 5, n = 3;
            WriteLine($"Проверяет теорему Ферма для a={a}, b={b}, c={c}, n={n}");
            
            if (IsFermatSatisfied(a, b, c, n))
            {
                //Если a^n + b^n = c^n, то теорема нарушена (только для n > 2)
                WriteLine("Теорема НАРУШЕНА!")
            }
            else
            {
                //Если a^n + b^n != c^n, то теорема не нарушена
                WriteLine("Теорема НЕ НАРУШЕНА!")
            }
        }
        
        //Возвращает true, если a^n + b^n = c^n
        public static bool IsFermatSatisfied(int a, int b, int c, int n) => Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
    }
}