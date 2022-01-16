using ApexRestaurant.Repository;
using ApexRestaurant.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

 RepositoryModule.Register(builder.Services,
                builder.Configuration.GetConnectionString("DefaultConnection"),
            builder.GetType().Assembly.FullName);
            
            ServicesModule.Register(builder.Services);

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

app.Run();
