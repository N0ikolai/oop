public abstract class Building
{
    private static int lastBuildingNum = 0;

    private int buildingNumber;

    protected double height;

    protected int floors;

    protected int apartments;

    protected int entrances;

    public Building(double height, int floors, int apartments, int entrances)
    {
        this.buildingNumber = ++lastBuildingNum;
        this.height = height;
        this.floors = floors;
        this.apartments = apartments;
        this.entrances = entrances;
    }

    public double CulcFloorHeight()
    {
        return height / floors;
    }

    public int CulcAparmentsPerEntrance()
    {
        return apartments / entrances;
    }

    public int CalcApartmentsPerFloor()
    {
        return apartments / floors;
    }

    public virtual void PrintBuildingInfo()
    {
        Console.WriteLine($"Building Number: {buildingNumber}");
        Console.WriteLine($"Height: {height} meters");
        Console.WriteLine($"Floors: {floors}");
        Console.WriteLine($"Apartments: {apartments}");
        Console.WriteLine($"Entrances: {entrances}");
        Console.WriteLine($"Height per floor: {CulcFloorHeight()} meters");
        Console.WriteLine($"Apartments per entrance: {CulcAparmentsPerEntrance()}");
        Console.WriteLine($"Apartments per floor: {CalcApartmentsPerFloor()}");
    }

    public abstract void PrintSpecificInfo();
}
