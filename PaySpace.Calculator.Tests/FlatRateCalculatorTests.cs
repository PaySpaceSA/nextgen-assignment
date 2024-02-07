using Moq;

using NUnit.Framework;

using PaySpace.Calculator.Data;
using PaySpace.Calculator.Data.Models;
using PaySpace.Calculator.Services.Abstractions;

namespace PaySpace.Calculator.Tests
{
    [TestFixture]
    internal sealed class FlatRateCalculatorTests
    {
        private Mock<ICalculatorSettingsService> calculatorSettingsService;

        [SetUp]
        public void Setup()
        {
            this.calculatorSettingsService = new Mock<ICalculatorSettingsService>();
        }

        [TestCase(999999, 174999.825)]
        [TestCase(1000, 175)]
        [TestCase(5, 0.875)]
        public async Task Calculate_Should_Return_Expected_Tax(decimal income, decimal expectedTax)
        {
            // Arrange
            this.calculatorSettingsService.Setup(x => x.GetSettingsAsync(CalculatorType.FlatRate)).ReturnsAsync(GetSettings());

            // Act


            // Assert
        }

        private static List<CalculatorSetting> GetSettings()
        {
            return CalculatorContext.GetCalculatorSettings().Where(cs => cs.Calculator == CalculatorType.FlatRate).ToList();
        }
    }
}