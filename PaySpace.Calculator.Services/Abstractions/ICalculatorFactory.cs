namespace PaySpace.Calculator.Services.Abstractions
{
    public interface ICalculatorFactory
    {
        Task<ICalculator> CreateCalculatorAsync(string postalCode);
    }
}