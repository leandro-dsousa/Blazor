using BlazorWebAssembly.Server.Domain.Shared;
using BlazorWebAssembly.Server.Authentication;
using BlazorWebAssembly.Server.Infraestructure;
using BlazorWebAssembly.Server.Domain.Users;
using BlazorWebAssembly.Server.Domain.UserAccounts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.Text;
using BlazorWebAssembly.Server.Infraestructure.Users;
using BlazorWebAssembly.Server.Infraestructure.UserAccounts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<AppDbContext>( options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
builder.Services.AddRazorPages();
builder.Services.AddAuthentication(o =>
{
    o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o => {
    o.RequireHttpsMetadata = false;
    o.SaveToken = true;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtAuthenticationManager.JWT_SECURITY_KEY)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

//builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserAccountRepository, UserAccountRepository>();
builder.Services.AddTransient<UserAccountService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7181/", "https://localhost:7181/")
    .AllowAnyMethod().WithHeaders(HeaderNames.ContentType)); 

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
