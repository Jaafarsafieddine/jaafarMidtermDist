var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// New Endpoint: Greeting API
app.MapGet("/api/greeting", () =>
{
    return Results.Ok(new { Message = "Hello! Welcome to the enhanced Weather App Lassssst Time!" });
});

// Existing Controllers Mapping
app.MapControllers();

app.Run();
