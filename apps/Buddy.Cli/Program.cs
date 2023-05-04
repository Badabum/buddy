// See https://aka.ms/new-console-template for more information


using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
});

await app.RunAsync(args);