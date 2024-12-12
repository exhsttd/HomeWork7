// Упражнение 8.4.
namespace TumakovLab.Classes
{
    public class CheckFormat
    {
        public static bool CheckIfIFormattable(object obj)
        {
            if (obj is System.IFormattable format)
            {
                return true;
            }
            return false;
        }
    }
}
