namespace TesteNBomber;

public class Configurations
{
    public static string UrlRequest => Environment.GetEnvironmentVariable("UrlRequest")!;
    public static int WarmUpDurationSeconds => Convert.ToInt32(Environment.GetEnvironmentVariable("WarmUpDurationSeconds"))!;
    public static int VirtualUsers => Convert.ToInt32(Environment.GetEnvironmentVariable("VirtualUsers"))!;
    public static int IntervalSeconds => Convert.ToInt32(Environment.GetEnvironmentVariable("IntervalSeconds"))!;
    public static int DurationSeconds => Convert.ToInt32(Environment.GetEnvironmentVariable("DurationSeconds"))!;
    public static string HostPing => Environment.GetEnvironmentVariable("HostPing")!;
    public static string ReportFileName => Environment.GetEnvironmentVariable("ReportFileName")!;
    public static string ReportFolder => Environment.GetEnvironmentVariable("ReportFolder")!;
}