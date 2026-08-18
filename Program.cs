using AsianStoreInventory.Components;
using AsianStoreInventory.Data;
using AsianStoreInventory.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=inventory.db"));

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();


// ===============================
// CREATE DEFAULT USERS
// ===============================

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider
                     .GetRequiredService<AppDbContext>();

    // Create Admin if it doesn't exist
    if (!db.Users.Any(u => u.Username == "admin"))
    {
        db.Users.Add(new User
        {
            Username = "admin",
            Password = "Admin2026!",
            Role = "Admin"
        });
    }

    // Create Cashier if it doesn't exist
    if (!db.Users.Any(u => u.Username == "cashier"))
    {
        db.Users.Add(new User
        {
            Username = "cashier",
            Password = "Cashier2026!",
            Role = "Cashier"
        });
    }

    db.SaveChanges();
}


// ===============================
// APPLICATION CONFIGURATION
// ===============================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();