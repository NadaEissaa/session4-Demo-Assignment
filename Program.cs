namespace session4
{
    internal class Program
    {

        #region Function
        //static void printShape(int count , string pattern = "")
        //{
        //    for(int i = 0; i <=count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}
        //printShape(5, "_*");


        //static int SumNumers(int X, int Y)
        //{
        //    return X + Y;


        //}
        #endregion

        static void SWAP(int X, int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;


        }

        

        static void Main(string[] args)
        {

            #region 1D array
            //1D Array
            int[] Numbers;
            //Declare for reference (pointer) from the type of 'int'
            //Numbers:can refer to object from 'array of ints'
            //Numbers refer to Null

            //8 Bytes will be allocated at stach for the reference'Numbers'
            //8 Bytes will be allocated at heap

            //Numbers = new int [size]
            Numbers = new int[5];
            //allocate the number of required bytes for the object at heap
            //initialized the allocated bytes with the default value of the data type
            //call user_defined constructor if exists
            //assign the object to the reference ' Numbers'

            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[4]=90;

            //Console.WriteLine(Numbers[0]);

            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Console.Write($"Enter Number[{i}]");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Console.Write($"{Numbers[i]} ");
            //}

            //Array fixed size

            //int[] Numbers01 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] Numbers02= new int[] { 1, 2, 3, 4, 5 };
            //int[] Numbers03= new int[] { 1, 2, 3, 4, 5 };

            #endregion


            #region 2D Array
            //the 2D array

            //int[,] Marks = new int[3, 4];
            //Marks[0, 0] = 99;
            //Marks[0, 1] = 98;
            //Marks[0, 2] = 97;

            //Console.WriteLine(Marks[0, 0]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{Marks[i, j]}");
            //    }


            //  }
            #endregion

            #region 2D Array
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[3];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; i++)
            //    {
            //        Console.Write($"enter Marks[{i}][{i}]");
            //        Marks[i][i] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; i++)
            //    {
            //        Console.Write($"{Marks[i][j]}");

            //    }
            //    Console.WriteLine(Marks[i][j]);
            //}

            #endregion


            #region function prototype
            //function:method
            //1.class member method : (static method)
            //2.object member method : (non static method)

            //static void printShape(int count , string pattern = "")
            //{
            //    for(int i = 0; i <=count; i++)
            //    {
            //        Console.WriteLine(pattern);
            //    }
            //}
            //printShape(5, "_*");


            //Console.WriteLine(SumNumers(3, 8));
            #endregion


            //passing by value
            //passing by reference

            int A = 9, B = 4;
            Console.WriteLine($"{A}");
            Console.WriteLine($"{B}");

            SWAP(A,  B); 

            Console.WriteLine($"{A}");
            Console.WriteLine($"{B}");



        }

    }
}
