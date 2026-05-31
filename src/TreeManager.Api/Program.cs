var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "ok",
        service = "tree-manager-api",
        timestamp = DateTime.UtcNow
    });
});

app.Run();