using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorovinskikhSV.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    result += item;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
