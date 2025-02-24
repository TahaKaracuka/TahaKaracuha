//Bu sat�rda bir web uygulama olu�turucu yarat�l�yor.
var builder = WebApplication.CreateBuilder(args);

//Bu sat�r projemizin MVC �zelliklerini ta��mas�n� sa�lar.
builder.Services.AddControllersWithViews();

//Bu sat�rda ise yarat�lan uygulama olu�turucu ile bir uygulama olu�turuluyor.
var app = builder.Build();

//Burada �a�r�lan uygulamalar/metotlar Middleware olarak adland�l�r�rlar. (Ara yaz�l�m)

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


//localhost:5200/Home/Index
//localhost:5200/Home
//localhost:5200
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Bu sat�rda olu�turulmu� uygulama �al��t�r�l�yor.
app.Run();
