#addin nuget:?package=Cake.SemVer&version=2.0.0
#addin nuget:?package=semver&version=2.0.4

// Enviroment
var isRunningOnWindows = IsRunningOnWindows();

// Arguments.
var target = Argument("target", "Default");
var configuration = "Release";

// Define directories.
var solutionFile = new FilePath("src/CircleImageView.sln");
var artifactsDirectory = new DirectoryPath("artifacts");

// Versioning. Used for all the packages and assemblies for now.
var version = CreateSemVer(2, 2, 0);

Setup((context) =>
{
	Information("Configuration: {0}", configuration);
});

Task("Clean")
	.Does(() =>
	{	
		CleanDirectory(artifactsDirectory);

		DotNetBuild(solutionFile, settings => settings
				.SetConfiguration(configuration)
				.WithTarget("Clean")
				.SetVerbosity(Verbosity.Minimal));
	});

Task("Restore")
	.Does(() => 
	{
		NuGetRestore(solutionFile);
	});

Task("Build")
	.IsDependentOn("Clean")
	.IsDependentOn("Restore")
	.Does(() =>  
	{	
		DotNetBuild(solutionFile, settings => settings
					.SetConfiguration(configuration)
					.WithTarget("Build")
					.WithProperty("NoWarn", "1591") // ignore missing XML doc warnings
					.SetVerbosity(Verbosity.Minimal));
	});

Task ("NuGet")
	.IsDependentOn ("Build")
	.Does (() =>
	{
		Information("Nuget version: {0}", version);
		
		NuGetPack("./nuspec/CircleImageView.nuspec", 
			new NuGetPackSettings 
				{ 
					Version = version.ToString(),
					Verbosity = NuGetVerbosity.Normal,
					OutputDirectory = artifactsDirectory,
					BasePath = "./",
					ArgumentCustomization = args => args.Append("-NoDefaultExcludes")		
				});	
	});

Task("Default")
	.IsDependentOn("NuGet")
	.Does(() => {});

RunTarget(target);