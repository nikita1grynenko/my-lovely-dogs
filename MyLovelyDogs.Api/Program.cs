using MyLovelyDogs.Application.Contracts;
using MyLovelyDogs.Application.Services;
using MyLovelyDogs.Infrastructure.ExternalServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient<TheDogApiClient>(client =>
{
    client.BaseAddress = new Uri("https://api.thedogapi.com");
    client.DefaultRequestHeaders.Add("x-api-key", "live_koMms4dtKDtSe6xbjxZgUpv40y3DN72gTuM3LDMfNfjvttTCYbMOeyqvid5Imtff");
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IDogService, DogService>();
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

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
