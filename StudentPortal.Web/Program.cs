using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Data;

var builder = WebApplication.CreateBuilder(args);
/*Entity Framework Core (EF Core) is an open-source, lightweight, and extensible version of the
 * Entity Framework data access technology provided by Microsoft. It enables .NET developers to 
 * work with relational databases using domain-specific objects without having to write SQL queries directly.

Key features of Entity Framework Core include:

Object-Relational Mapping (ORM): EF Core allows developers to define domain model classes (entities) that
represent database tables, and it automatically generates SQL queries to perform CRUD 
(Create, Read, Update, Delete) operations on those tables.

LINQ Support: EF Core provides support for LINQ (Language Integrated Query), allowing developers to
write queries using familiar C# syntax, which are then translated into SQL queries by EF Core.

Database Providers: EF Core supports various relational database providers, including SQL Server, 
SQLite, PostgreSQL, MySQL, and others. It also supports in-memory databases for testing purposes.

Migrations: EF Core includes a migration feature that enables developers to update the database schema 
to match changes in the domain model. Migrations allow for incremental updates to the database without losing data.

Configuration and Customization: EF Core provides flexible configuration options for entities, 
relationships, and database mappings. Developers can customize the behavior of EF Core using conventions
or explicit configuration.
*/
// Add services to the container.
builder.Services.AddControllersWithViews();

// injecting the application db context and we are telling the app that for this context use sql server through the appsettings.json connection string
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("StudentPortal")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
