var builder = WebApplication.CreateBuilder(args);

// Add Services to container.

var app = builder.Build();

// Configure the HTTO request pipelines

app.Run();
