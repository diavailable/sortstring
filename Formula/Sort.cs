using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortstring.Formula
{
    public static class Sort
    {
        public static string BubbleSort(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = 0; j < chars.Length - i - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        char temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }
            return new string(chars);
        }

        public static string QuickSort(string input)
        {
            char[] chars = input.ToCharArray();
            QuickSort(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private static void QuickSort(char[] chars, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(chars, low, high);
                QuickSort(chars, low, pi - 1);
                QuickSort(chars, pi + 1, high);
            }
        }

        private static int Partition(char[] chars, int low, int high)
        {
            char pivot = chars[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (chars[j] < pivot)
                {
                    i++;
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                }
            }
            char temp1 = chars[i + 1];
            chars[i + 1] = chars[high];
            chars[high] = temp1;
            return i + 1;
        }
        /*
        public static string MergeSort(string input)
        {
            char[] chars = input.ToCharArray();
            MergeSort(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private static void MergeSort(char[] chars, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(chars, left, middle);
                MergeSort(chars, middle + 1, right);
                Merge(chars, left, middle, right);
            }
        }

        private static void Merge(char[] chars, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            char[] L = new char[n1];
            char[] R = new char[n2];
            Array.Copy(chars, left, L, 0, n1);
            Array.Copy(chars, middle + 1, R, 0, n2);
            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    chars[k++] = L[i++];
                }
                else
                {
                    chars[k++] = R[j++];
                }
            }
            while (i < n1)
            {
                chars[k++] = L[i++];
            }
            while (j < n2)
            {
                chars[k++] = R[j++];
            }
        }
        */
    }
}