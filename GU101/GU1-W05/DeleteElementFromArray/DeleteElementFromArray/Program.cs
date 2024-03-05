using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng
            int[] array = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 1};

            // Phần tử cần xoá
            int elementToDelete = 7; 

            // Gọi phương thức để xoá phần tử
            array = DeleteElementFromArray(array, elementToDelete);

            // In ra mảng sau khi xoá phần tử
            Console.WriteLine("Mang sau khi xoa phan tu:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
           
            Console.ReadKey();
        }

        static int[] DeleteElementFromArray(int[] array, int element)
        {
            // Tìm vị trí của phần tử cần xoá trong mảng
            int indexToDelete = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    indexToDelete = i;
                    break;
                }
            }

            // Nếu không tìm thấy phần tử cần xoá, trả về mảng ban đầu
            if (indexToDelete == -1)
            {
                return array;
               
            }

            // Xoá phần tử khỏi mảng bằng cách ghi đè phần tử đằng sau lên phần tử hiện tại
            for (int i = indexToDelete; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = 0;

            return array;
        }
    }
}
