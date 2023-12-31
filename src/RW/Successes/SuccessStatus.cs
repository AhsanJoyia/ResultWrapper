using RW.Common;

namespace RW.Successes;

public class SuccessStatus<T> : IResultWrapper<T>
{
    bool IResultBase.IsSuccess { get; set; } = true;
    public SuccessStatus(string successMessage, int successCode)
    {
        Message = successMessage;
        Code = successCode;
    }
    public string Message { get; set; }
    public int Code { get; set; }
    T? IResultWrapper<T>.Payload { get; set; }
    T? IResultWrapper<T>.Errors { get; set; }
    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
