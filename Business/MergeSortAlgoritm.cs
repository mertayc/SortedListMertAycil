namespace SortedListMertAycil.Business
{
    public class MergeSortAlgoritm
    {
        /// <summary>
        /// Verilen listeyi Merge Sort algoritması ile sıralar.
        /// Listeyi kendisini tekrar tekrar çağırarak (kendi içinde bölerek) ikiye ayırır,
        /// daha küçük listeleri sıralar ve sonra birleştirir.
        /// </summary>
        /// <param name="list">Sıralanacak tamsayı listesi.</param>
        /// <returns>Sıralanmış yeni liste.</returns>
        public static List<int> MergeSort(List<int> list)
        {

            // Liste boş veya tek elemanlı ise zaten sıralıdır..
            if (list is null || list.Count <= 1)
                return list;

            // Listeyi ikiye bölmek için ortanca indeksi buluyorum.
            int middle = list.Count / 2;

            // Soldaki ve sağdaki parçaları tutmak için iki boş liste oluşturdum.
            List<int> left = new();
            List<int> right = new();

            // Orta noktaya kadar olan elemanlar 'left' listesine ekledim.  
            for (int i = 0; i < middle; i++)
                left.Add(list[i]);

            // Orta noktadan itibaren olan elemanlar 'right' listesine ekledim.
            for (int i = middle; i < list.Count; i++)
                right.Add(list[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        // <summary>
        /// İki sıralı listeyi alır ve bunları sıralı tek bir liste olarak birleştirir.
        /// Küçük elemanlar baştan alınarak yeni birleştirilmiş liste oluşturulur.
        /// </summary>
        /// <param name="left">Sıralanmış sol liste.</param>
        /// <param name="right">Sıralanmış sağ liste.</param>
        /// <returns>Birleştirilmiş ve sıralanmış liste.</returns>
        private static List<int> Merge(List<int> left, List<int> right)
        {
            // Sonuç olarak birleşmiş, sıralı listeyi tutmak için boş liste oluşturdum.
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                // İki liste de boş değilse, ilk elemanları karşılaştırıp küçük olanı sonuç listesine ekliyorum.
                if (left.Count > 0 && right.Count > 0)
                {
                    //
                    if (left.First() <= right.First())
                    {
                        // eğer sol liste ilk elemanı sağ liste ilk elemanından küçük veya eşitse,
                        // sol liste ilk elemanı sonuç listesine eklerim ve sol listeden bu elemanı kaldırırım 
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        // eğer sağ liste ilk elemanı sol liste ilk elemanından küçükse,
                        // sağ liste ilk elemanı sonuç listesine eklerim ve sağ listeden bu elemanı kaldırırım
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }

                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }

                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }





}

