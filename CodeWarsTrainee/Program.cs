using System.Drawing;

class CodeWars
{


    static void Main(string[] args)
    {
        //bool response;
        //int[] array = { 1, 2, 3, 2, 10, 6 };
        //response = ArrayAscendent(array);
        NarcisistNumber(154);
    }
    public static bool NarcisistNumber(int value)
    {
        int[] ints = NumbersOfNumber(value);
        double sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            int size = NumberOfString(value);
            sum += Math.Pow(ints[i], size);
        }
        if (sum == value)
            return true;
        else
            return false;
    }

    public static int[] NumbersOfNumber(int value)
    {
        int size = NumberOfString(value);
        int[] array = new int[size];

        while (value > 0)
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = value % 10;
                value /= 10;
            }
        }
        return array;
    }

    public static int NumberOfString(int value)
    {
        string stringNumbers = value.ToString();
        int numbersLenght = stringNumbers.Length;
        return numbersLenght;

    }
    public static bool ArrayAscendent(int[] array)
    {
        int[] newArray = array.OrderBy(i => i).ToArray();
        if (newArray.SequenceEqual(array))
            return true;
        else
            return false;
    }
}