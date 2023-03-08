using MinimalwebAPI.Models;
using MinimalwebAPI.Repositories;
using MinimalwebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPersonalDataService, PersonalDataService>();
builder.Services.AddScoped<IPersonalDataRepository, PersonalDataRepository>(); // after build, order matters?


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPersonalDataRepository, PersonalDataRepository>();
builder.Services.AddScoped<IPersonalDataService, PersonalDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/personalData/{id}", async (int id, IPersonalDataService personalDataService)
    => {

        var (Result, PersonalData) = await personalDataService.GetAsync(id);
        return Result? Results.Ok(PersonalData) : Results.NotFound();

    })
    .Produces<PersonalData>(); // withour produces

app.MapPost("/personalData", async (PersonalData personalData, IPersonalDataService personalDataService)
    =>
{

    (bool Result, PersonalData PersonalData) result = await personalDataService.CreateAsync(personalData); // a new type of service instead of controller
    return result.Result ? Results.Ok(result.PersonalData) : Results.BadRequest();
})
    .Produces<PersonalData>(); // without produces

app.MapDelete("/personalData", async (int id, IPersonalDataService personalDataService)
    =>
{

    var result = await personalDataService.DeleteAsync(id); 
    return result? Results.NoContent() : Results.BadRequest();
})
    .Produces(StatusCodes.Status204NoContent)
    .Produces(StatusCodes.Status400BadRequest); // without produces

// put

app.MapPut("/personalData", async (PersonalData personalData, IPersonalDataService personalDataService)
    =>
{

    (bool Result, PersonalData PersonalData) result = await personalDataService.UpdateAsync(personalData); // a new type of service instead of controller
    return result.Result ? Results.Ok(result.PersonalData) : Results.BadRequest();
})
    .Produces<PersonalData>()
    .Produces(StatusCodes.Status400BadRequest); // without produces


app.Run();
