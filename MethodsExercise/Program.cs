namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* //exercise 1
             Console.WriteLine("enter an adjective");
             string adjective1 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective2 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective3 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective4 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective5 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective6 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective7 = Console.ReadLine();
             Console.WriteLine("enter an adjective");
             string adjective8 = Console.ReadLine();
             Console.WriteLine("enter a noun");
             string noun1 = Console.ReadLine();
             Console.WriteLine("enter a noun");
             string noun2 = Console.ReadLine();
             Console.WriteLine("enter a noun");
             string noun3 = Console.ReadLine();
             Console.WriteLine("enter a verb");
             string verb1 = Console.ReadLine();
             Console.WriteLine($"Once upon a {adjective1} time, in a {adjective2} land far, far away, a {noun1} went on a wild adventure. They found a magical {adjective3} {noun2} and suddenly ended up in a {adjective4} world filled with {noun3}.\r\n\r\nAs they {verb1} through the {adjective5} landscape, they encountered {adjective6} creatures and a {adjective7} danger. Will they make it back home safely? Who knows, but it's sure to be a {adjective8} time!");
             */
            
             //exercise 2
             var intArray = new int[] { 2, 3, 4 };
             var x = MathMethods.Sum(intArray);
             Console.WriteLine(x);
             var intArray2 = new int[] { 3, 51, 15 };
             x = MathMethods.Subtract(intArray2);
             Console.WriteLine(x);
             var intArray3 = new int[] {2,2,2,2};
             x = MathMethods.Multiply(intArray3);
             Console.WriteLine(x);

            

        
        
        }
    }
}
