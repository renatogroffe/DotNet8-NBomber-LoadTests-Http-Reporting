using NBomber.CSharp;
using NBomber.Http.CSharp;
using NBomber.Contracts.Stats;
using NBomber.Plugins.Network.Ping;
using NBomber.Http;
using TesteNBomber;

var httpClient = new HttpClient();

var scenario = Scenario.Create("http_scenario", async context =>
{
    var request =
        Http.CreateRequest("GET", Configurations.UrlRequest)
            .WithHeader("Accept", "application/json");

    var response = await Http.Send(httpClient, request);
    
    return response;
})
.WithWarmUpDuration(TimeSpan.FromSeconds(Configurations.WarmUpDurationSeconds))
.WithLoadSimulations(
    Simulation.Inject(
        rate: Configurations.VirtualUsers,
        interval: TimeSpan.FromSeconds(Configurations.IntervalSeconds),
        during: TimeSpan.FromSeconds(Configurations.DurationSeconds))
);

var pingPluginConfig = PingPluginConfig.CreateDefault(
    new[] { Configurations.HostPing });
var pingPlugin = new PingPlugin(pingPluginConfig);

NBomberRunner
    .RegisterScenarios(scenario)
    .WithReportFileName(Configurations.ReportFileName)
    .WithReportFormats(ReportFormat.Html)
    .WithWorkerPlugins(pingPlugin, new HttpMetricsPlugin())
    .WithReportFolder(Configurations.ReportFolder)
    .Run();