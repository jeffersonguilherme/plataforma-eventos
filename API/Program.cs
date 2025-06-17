using Application.EventoCQ.Commands;
using Application.ParticipanteCQ.Commands;
using Infra.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EventoDbContext>();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(CreateEventoCommand).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
