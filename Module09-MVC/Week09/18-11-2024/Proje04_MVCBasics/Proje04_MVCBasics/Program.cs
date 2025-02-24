//Bu satýrda bir web uygulama oluþturucu yaratýlýyor.
var builder = WebApplication.CreateBuilder(args);

//Bu satýr projemizin MVC özelliklerini taþýmasýný saðlar.
builder.Services.AddControllersWithViews();

//Bu satýrda ise yaratýlan uygulama oluþturucu ile bir uygulama oluþturuluyor.
var app = builder.Build();

//Burada çaðrýlan uygulamalar/metotlar Middleware olarak adlandýlýrýrlar. (Ara yazýlým)

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

//Bu satýrda oluþturulmuþ uygulama çalýþtýrýlýyor.
app.Run();
