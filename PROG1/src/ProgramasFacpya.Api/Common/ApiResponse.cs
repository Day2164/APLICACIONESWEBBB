namespace ProgramasFacpya.Api.Common;

public class ApiResponse<T>
{
    public bool Status { get; set; }
    public T? Value { get; set; }
    public string? Msg { get; set; }

    public static ApiResponse<T> Ok(T value, string? msg = null)
    {
        return new ApiResponse<T>
        {
            Status = true,
            Value = value,
            Msg = msg
        };
    }

    public static ApiResponse<T> Error(string msg)
    {
        return new ApiResponse<T>
        {
            Status = false,
            Value = default,
            Msg = msg
        };
    }
}