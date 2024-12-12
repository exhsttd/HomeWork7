// Упражнение 8.2
namespace TumakovLab.Classes
{
    public class String
    {
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray(); 
            Array.Reverse(charArray); 
            return new string(charArray); 
        }
    }
}
