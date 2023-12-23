using HomeAutomation.Helpers.Desktop.Application.Services.Clients;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services.Clients;

public class ApiGatewayServiceCLient : IApiGatewayServiceClient
{
    public T SendMessage<T>(string message, string authKey)
    {
        throw new NotImplementedException();
    }
}