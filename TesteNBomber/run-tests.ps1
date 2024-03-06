$env:UrlRequest = "https://apirest/contador"
$env:WarmUpDurationSeconds = "10"
$env:VirtualUsers = "100"
$env:IntervalSeconds = "1"
$env:DurationSeconds = "30"
$env:HostPing = "host.io"
$env:ReportFileName = "nbomber-report.html"
$env:ReportFolder = "D:\DotNet8\ContainerApps\TesteNBomber\results\"

dotnet run -c Release