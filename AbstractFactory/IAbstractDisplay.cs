namespace AbstractFactory
{
    public interface IAbstractDisplay
    {
        public string ShowMyInfo();
        public string GetMyBattaryType(IAbstractAccumulator accumulator);
    }
}