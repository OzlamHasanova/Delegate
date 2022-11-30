
class Car : Vehicle
{
    public string Brand;
    public string Model;
    public int FuelCapacity;
    public int FuelFor1Km;
    public int CurrentFuel;
    

    public Car(string Brand,string Model,int FuelCapacity,int FuelFor1Km, int Year) : base(Year)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.FuelCapacity = FuelCapacity;
        this.FuelFor1Km = FuelFor1Km;
    }
}
