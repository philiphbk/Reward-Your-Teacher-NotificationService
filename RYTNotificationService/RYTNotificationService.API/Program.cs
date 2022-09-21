using EmailSenders.Services;
using EmailSenders.Settings;
using System;
using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data;
using RYTNotificationService.API.Data.Implementation;
using RYTNotificationService.API.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*builder.Services.AddApplicationServices(builder.Configuration);*/
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IMessageService, MessageService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailService, MailService>();

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
