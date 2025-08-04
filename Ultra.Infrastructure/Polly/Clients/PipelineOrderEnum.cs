namespace Ultra.Infrastructure.Polly.Clients;

public enum PipelineOrderEnum
{
    OneHttpRqTimeout,
    RateLimiter,
    Retry
}
