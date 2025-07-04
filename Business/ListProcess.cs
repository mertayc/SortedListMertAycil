using SortedListMertAycil.Business.BusinessRules;

namespace SortedListMertAycil.Business
{
    public class ListProcess
    {
        /// <summary>
        /// Listeyi kullanıcıdan alınan parametrelere göre oluşturur.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>

        public static List<int> GenerateRandomList(int size = 10, int minValue = 0, int maxValue = 100)
        {
            if (!ListGeneratorBusinessRule.IsValidListParameters(size, minValue, maxValue, out string invalidMessage))
                throw new ArgumentException(invalidMessage);

            Random random = new Random();
            List<int> randomList = new();

            for (int i = 0; i < size; i++)
                randomList.Add(random.Next(minValue, maxValue));

            return randomList;
        }

        public static string CheckNumberInList(string? number, List<int> list)
        {
            if(!int.TryParse(number,out int numberParsed))
            return $"{number} is not a valid number.";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == numberParsed)
                    return $"{numberParsed} is exist and order is {i + 1} ";
            }

            return $"{numberParsed} is not exist. ";

        }
    }
}
