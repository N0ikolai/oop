using System;

public class ResidentialBuilding : Building
{
    private bool hasYard;

    public ResidentialBuilding(double height, int floors, int apartments, int entrances, bool hasYard)
         : base(height, floors, apartments, entrances)
    {
        this.hasYard = hasYard;
    }

    public override void PrintSpecificInfo()
    {
        Console.WriteLine($"Residential building with yard: {hasYard}");
    }

    public override void PrintBuildingInfo()
    {
        base.PrintBuildingInfo();
    }
}
