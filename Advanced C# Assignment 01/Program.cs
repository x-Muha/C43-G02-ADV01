using Advanced_C__Assignment_01.Question01;
using Advanced_C__Assignment_01.Question02;
using Advanced_C__Assignment_01.Question03;
using Advanced_C__Assignment_01.Question04;

namespace Advanced_C__Assignment_01;


internal class Program
{
    static void Main(string[] args)
    {
        #region Question01
        //Range<int> range= new Range<int>(1,4);
        //Console.WriteLine(range.Length());

        //Point2D point1 = new Point2D() { X = 2,Y= 2};
        //Point2D point2 = new Point2D() { X = 7,Y= 8};

        //Range<Point2D> range2 = new Range<Point2D>(point1, point2);
        //Console.WriteLine(range2.Length<Point2D>());
        #endregion

        #region Question02

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        //Helper02.Print(arr);
        //Helper02.Reverse(arr);
        //Helper02.Print(arr);


        //double[] arr = { 1.1, 2.2, 3.3 };
        //Helper02.Reverse(arr);
        //Helper02.Print(arr);

        //Point2D[] arr = { new(1,1), new(2,2), new(3,3) };
        //Helper02.Reverse(arr);
        //Helper02.Print(arr);

        #endregion

        #region Question03

        //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        //Helper02.Print(Arr);
        //int[] EvenArr = Helper03.GetEvenNumbers(Arr);
        //Helper02.Print(EvenArr); 
        #endregion

        #region Question04

        //FixedSizeList<int> X = new FixedSizeList<int>(5);

        //X.Add(1);
        //X.Add(2);
        //X.Add(3);    
        //X.Add(4);
        //X.Add(5);

        //X.Print();
        //Console.WriteLine(X.Get(0));
        //Console.WriteLine(X.Get(3));


        ////X.Get(-1); // throw exception (Invalid Index)
        ////X.Add(6);  // throw exception (List Is Full)


        #endregion

        #region Question05

        //string? str = default;
        //while (str is null)
        //{
        //    Console.Write("Enter a string: ");
        //    str = Console.ReadLine();
        //}

        //char c = default;
        //bool isParsed = false;
        //while (!isParsed) {
        //    Console.Write("Enter a Char: ");
        //    isParsed = char.TryParse(Console.ReadLine(),out c);
        //}

        //bool found = false;
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (str[i] == c)
        //    {
        //        Console.WriteLine($"Character was found at index: {i}");
        //        found = true;
        //        break;
        //    }
        //}
        //if(!found) Console.WriteLine("Not found");

        #endregion
    }
}
