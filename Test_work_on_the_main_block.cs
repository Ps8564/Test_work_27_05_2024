using System;
class MyProgNewArray
{
    // Created a function to match
    public static void Creat_New_Array(string[] arr_1, string[] arr_2)
    {
        int count = 0;
        for (int i = 0; i < arr_1.Length; i++)
        {
            if (arr_1[i].Length <= 3)
            {
                arr_2[count++] = arr_1[i];
            }
        }
    }
    // Created a function for printing
    public static void Print_New_Array(string[] new_array)
    {
        for (int i = 0; i < new_array.Length; i++)
        {
            Console.Write($"{new_array[i]} ");
        }
    }
    static void Main()
    {
        // Created my string
        string[] arr_1 = new string[] { "Pavel", "hello", "GB", "27", "05", "24", "LAB", "SHP", "007" };
        // Creating strng for result
        string[] arr_2 = new string[arr_1.Length];

        Creat_New_Array(arr_1, arr_2);
        Print_New_Array(arr_2);
    }
}