namespace ConsoleApp1MultiCastDemo
{
    internal class Program
    {
        //1 Defining Delegate
        public delegate void RectangleDelegate(double width, double height);
        static void Main(string[] args)
        {
            //2.Initialization
            Program program = new Program();
            RectangleDelegate rectangleDelegate = new RectangleDelegateDelegate(program.GetArea);
            rectangleDelegate.Invoke(5.5, 6.5);

            //Area
            //Multicast
            Console.WriteLine("After multicast");
            rectangleDelegate += program.GetPerimeter;
            rectangleDelegate.Invoke(15.5, 9.5);
        }
        //remove Area
        RectangleDelegate-=Program.
        //Find area and perimeter of rectangle
        //Get Area
        public void GetArea(double width,double height)
        {
            Console.WriteLine("Area:{0}", (width * height));
        }
        //get perimeter---2
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine("Perimetr:{0}",(2*(width+height);
        }
    }
}
