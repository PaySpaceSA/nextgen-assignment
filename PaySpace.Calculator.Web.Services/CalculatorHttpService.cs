using System.Net.Http.Json;

using PaySpace.Calculator.Web.Services.Abstractions;
using PaySpace.Calculator.Web.Services.Models;

namespace PaySpace.Calculator.Web.Services
{
    public class CalculatorHttpService : ICalculatorHttpService
    {
        public async Task<List<PostalCode>> GetPostalCodesAsync()
        {
            var response = await httpClient.GetAsync("api/posta1code");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Cannot fetch postal codes, status code: {response.StatusCode}");
            }

            return await response.Content.ReadFromJsonAsync<List<PostalCode>>() ?? [];
        }

        public async Task<List<CalculatorHistory>> GetHistoryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CalculateResult> CalculateTaxAsync(CalculateRequest calculationRequest)
        {
            throw new NotImplementedException();
        }
    }
}