namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Enter 5 grades seperated by new line:");
            double sum = 0;
            int x = 0;

            while(x < 5)
            {            
                double grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
                x++;
            }
            double Average = sum / 5;
            double roundedAverage = Math.Round(Average, 2);
            Console.WriteLine($"Average is: " + Average + " and round off to " + Math.Round(Average));
        }
    }
}
