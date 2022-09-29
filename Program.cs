

int Main()
{
    string key = "0";
    string foo = "1";
    int x = 0, y = 0;
    while(true)
    {
        Console.WriteLine("Enter 1 to find a power of x in y.\n" +
        "Enter 2 to find a sum of digits in a number.\n" +
        "Enter 3 to make an array of 8 elements.\n" +
        "Enter 0 to terminate the program."
        );
        
        key = Console.ReadLine();

        switch(key)
        {
            case "1":
                Console.WriteLine("Enter two numbers x and y.");
                foo = Console.ReadLine();
                x = System.Int32.Parse(foo);
                foo = Console.ReadLine();
                y = System.Int32.Parse(foo);
                Console.WriteLine($" |{Homework.Pow(x,y)}| ");
                break;
            case "2":
                Console.WriteLine("Enter the nubmer to find a sum of its digits.");
                foo = Console.ReadLine();
                Console.WriteLine($" ~{Homework.Sum(foo)}~ ");
                break;
            case "3":
                Matrix m = new Matrix();
                m.FillArray();
                m.ShowArray();
                break;
            case "0":
                return 0;
            default:
                break;
        }
    }
    Main();
}

Main();

class Homework
{
    static public float Pow(float x = 2f, float y = 2f, char verbose = 'v')
    {
        float num = 1f;
        for(int i = 0; i < y; i++)
        {
 /*           if(verbose == 'v')
                Console.Write($" |{num}| ");
            if(verbose == 'v' && i == 5)
                Console.WriteLine();
*/          num *= x;

        }
        return num;
    }

    static public int Sum(string foo = "111")
    {
        int bar = 0;
        for(int i = 0; i < foo.Length; i++)
            bar += foo[i] - '0';

        return bar;
    }
}

class Matrix
{
    public int[] array = new int[8] {0,0,0,0,0,0,0,0};

    public void FillArray()
    {
        Console.WriteLine("Enter eight numbers for an array.");
        string foo = "NULL";
        for(int i = 0; i < array.Length; i++)
        {
            foo = Console.ReadLine();
            array[i] = System.Int32.Parse(foo);
        }
    }

    public void ShowArray()
    {
        for(int i = 0; i < array.Length; i++)
            {   if(i == 0)
                    Console.Write("[");
                Console.Write($"{array[i]}, ");
                if(i == array.Length - 1)
                    Console.WriteLine("]");
            }
    }

}