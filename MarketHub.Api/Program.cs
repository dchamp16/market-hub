var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Add services to the container
builder.Services.AddOpenApi(); // Add OpenAPI support for API documentation
builder.Services.AddCors(options =>
{
    options.AddPolicy("MobileApp", policy =>
    {
        policy.WithOrigins() // Replace with your mobile app's URL
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build(); // Build the application

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection(); // Enable HTTPS redirection
app.UseCors("MobileApp"); // Use the CORS policy defined above
app.MapControllers(); // Map the controllers to the app

app.Run();