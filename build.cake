var name = "EnumeratorUtils";
var project = $"src/{name}/{name}.csproj";
var npi = EnvironmentVariable("npi");

Task("Pack").Does(() => {
    CleanDirectory("publish");
    DotNetCorePack(project, new DotNetCorePackSettings {
        OutputDirectory = "publish"
    });
});

Task("Publish-Nuget")
    .IsDependentOn("Pack")
    .Does(() => {
        var nupkg = new DirectoryInfo("publish").GetFiles("*.nupkg").LastOrDefault();
        var package = nupkg.FullName;
        NuGetPush(package, new NuGetPushSettings {
            Source = "https://www.nuget.org/api/v2/package",
            ApiKey = npi
        });
});

var target = Argument("target", "Pack");
RunTarget(target);