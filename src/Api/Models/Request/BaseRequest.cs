namespace Api.Models.Request;

public class BaseRequest<T>
{
    public string Message { get; set; }
    public T? Data { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public BaseRequest(string message)
    {
        Message = message;
    }
    public BaseRequest(string message, T? data)
    {
        Message = message;
        Data = data;
    }
}
