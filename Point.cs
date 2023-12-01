using System.Globalization;
namespace Intermediate
{
   

    class Point
    {
        public int x;
        public int y;

        public Point(int x , int y)
        {
            this.x= x;
            this.y = y;
        }
        // public int Add(int[] numbers)
        // {   
        //     int sum = 0;
        //     foreach (var number in numbers)
        //     {
        //         sum += number;
        //     }
        //     return sum;
        // }

        public void Move(Point point)
        {
            try
            {
               Move(point.x,point.y);
                
            }
            catch (System.Exception)
            {
                 
                 System.Console.WriteLine("the value point  is null ");
            }
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Add(params int[] numbers)
        {   
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;

        }
        public void AddToTheNumber(ref int number)
        {
            number +=x;
            System.Console.WriteLine(number);
        }
        public bool TryGetX(out int number, out int y)
        {
            number = x ;
            y = this.y;

            if(x > 1)
            {

                return true;
            }
            return false;
        }


    }
}