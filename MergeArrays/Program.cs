namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        string[] names1 = {"andy", "bart", "zack"};
        string[] names2 = {"ben", "wisdom", "xavier"};

        var sortedNames = MergeSortedArrays<string>(names1, names2);

        System.Console.WriteLine(sortedNames[0]);
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];
        int index1=0;
        int index2=0;
        int indexResult=0;

        //loop
        while (index1 < array1.Length && index2 < array2.Length)
        {
            if(array1[index1].CompareTo(array2[index2]) <= 0)
            {
                result[indexResult] = array1[index1];
                index1++;
            }
            else
            {
                result[indexResult] = array2[index2];
                index2++;
            }
            indexResult++;
        }

        //end loop

        while (index1 < array1.Length)
        {
            result[indexResult] = array1[index1];
            index1++;
            indexResult++;
        }

        while (index2 < array2.Length)
        {
            result[indexResult] = array2[index2];
            index2++;
            indexResult++;
        }

        return result;     
    }


    // TODO 
    private static bool IsSorted(int[] array)
    {
        return true;
    }

    // TODO
    public static T[] MergeSortedArrays<T>(T[] array1, T[] array2) where T:IComparable<T>
    {
        T[] result = new T[array1.Length + array2.Length];

        int index1=0;
        int index2=0;
        int indexResult=0;

        //loop
        while (index1 < array1.Length && index2 < array2.Length)
        {
            if(array1[index1].CompareTo(array2[index2]) <= 0)
            {
                result[indexResult] = array1[index1];
                index1++;
            }
            else
            {
                result[indexResult] = array2[index2];
                index2++;
            }
            indexResult++;
        }

        //end loop

        while (index1 < array1.Length)
        {
            result[indexResult] = array1[index1];
            index1++;
            indexResult++;
        }

        while (index2 < array2.Length)
        {
            result[indexResult] = array2[index2];
            index2++;
            indexResult++;
        }

        return result;     
    }

}
