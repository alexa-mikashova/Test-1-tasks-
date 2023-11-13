namespace Task1_2
{
    public static class IntExtensions
    {
        private static string[] StringNumbers = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        private static string[] stringNumersArray;
        private static string numberString;

        public static string ToString(int number)
        {
            numberString = number.ToString();

            stringNumersArray = new string[numberString.Length];

            for (int i = 0; i < stringNumersArray.Length; i++)
            {
                stringNumersArray[i] = StringNumbers[int.Parse(numberString[i].ToString())];
            }

            return string.Join(" ", stringNumersArray.ToArray());
        }
    }
}