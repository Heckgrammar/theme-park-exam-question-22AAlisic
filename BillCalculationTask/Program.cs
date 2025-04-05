namespace ThemeParkCalculationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people in the group:");
            int NumPeople = Convert.ToInt32(Console.ReadLine());
            int ticketPrice;
            if (NumPeople < 6)
            {
                ticketPrice = NumPeople*15;
            }
            else
            {
                ticketPrice = (NumPeople*15)-5;
            }
            Console.WriteLine("The total charge for the group is: £" + ticketPrice);
        }
    }
}
