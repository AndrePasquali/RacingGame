namespace OcarinaStudios.MathRacing.Car.Fuel
{
    public interface IFuelManager
    {
        public void UpdateFuel();
        public bool IsFuelEmpty();
        public void FillFuel();

        public int GetFuelLevel();
    }
}