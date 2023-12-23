namespace HomeAutomation.Helpers.Desktop.Application.Services.Clients;

public interface IApiGatewayServiceClient
{
    public T SendMessage<T>(string message, string authKey);
}