namespace SortedListMertAycil.Business.BusinessRules
{
    public class ListGeneratorBusinessRule
    {


        /// <summary>
        /// Size, minimum ve maksimum değerleri kontrol eder.eçerli ise true, değilse false döner.Eğer değilse, geçersiz mesajı out parametresi olarak döner.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="invalidMessage"></param>
        /// <returns></returns>
        public static bool IsValidListParameters(int size, int minValue, int maxValue, out string invalidMessage)
        {
            invalidMessage = string.Empty;

            if (size <= 0)
            {
                invalidMessage = "Size must be greater than zero.";
                return false;
            }

            if (minValue >= maxValue)
            {
                invalidMessage = "Minimum value must be less than maximum value.";
                return false;
            }
           
            if (maxValue <= minValue)
            {
                invalidMessage = "Maximum value must be greater than minimum value.";
                return false;
            }
              
            return true;
        }



    }
}
