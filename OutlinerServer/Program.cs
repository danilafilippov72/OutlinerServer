using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using OutlinerServer.Models;
using OutlinerServer.Models.Tab;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMvc().WithRazorPagesRoot("/View/Layout");

//builder.Services.AddDbContext<DBTempTabNodeDtos>(opt => opt.UseInMemoryDatabase("Outliner"));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
//app.UseEndpoints(endpoints => endpoints.MapFallbackToPage("/_Host"));
app.MapFallbackToPage("/_Host");

app.MapPost("/CreateUpdateTempTabNodeDtos", async (TabNodeDto tabNodeDto) =>
{
    using DBTempTabNodeDtos db = new();
    TabNodeDto? tabNodeDtoToUpdate = db.TabNodeDtos.FirstOrDefault(tabNodeDto1 => tabNodeDto1.Id == tabNodeDto.Id);
    if (tabNodeDtoToUpdate != null)
    {
        tabNodeDtoToUpdate.Id = tabNodeDto.Id;
        tabNodeDtoToUpdate.openerTabId = tabNodeDto.openerTabId;
        tabNodeDtoToUpdate.Title = tabNodeDto.Title;
        tabNodeDtoToUpdate.Url = tabNodeDto.Url;
        tabNodeDtoToUpdate.FaviconUrl = tabNodeDto.FaviconUrl;
        tabNodeDtoToUpdate.WindowId = tabNodeDto.WindowId;
    }
    else db.TabNodeDtos.Add(tabNodeDto);
    await db.SaveChangesAsync();

    return Results.Created($"/CreateUpdateTempTabNodeDtos/{tabNodeDto.Id}", tabNodeDto);
});
app.MapGet("/todoitems", async () =>
{
    using DBTempTabNodeDtos db = new DBTempTabNodeDtos();
    return await db.TabNodeDtos.ToListAsync();

    //return Results.Created($"/todoitems/{tabNodeDto.Id}", tabNodeDto);
});

app.Run();
