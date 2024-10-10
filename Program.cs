namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResidentialBuilding residentialBuilding = new ResidentialBuilding(60, 20, 100, 4, true);
            residentialBuilding.PrintBuildingInfo();

            Console.WriteLine();

            ResidentialBuilding residentialBuilding2 = new ResidentialBuilding(50, 20, 80, 3, false);
            residentialBuilding2.PrintBuildingInfo();
        }
    }
}
