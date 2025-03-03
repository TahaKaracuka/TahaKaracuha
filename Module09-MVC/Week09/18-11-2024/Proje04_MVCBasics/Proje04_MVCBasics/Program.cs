//Bu satırda bir web uygulama oluşturucu yaratılıyor.
var builder = WebApplication.CreateBuilder(args);

//Bu satır projemizin MVC özelliklerini taşımasını sağlar.
builder.Services.AddControllersWithViews();

//Bu satırda ise yaratılan uygulama oluşturucu ile bir uygulama oluşturuluyor.
var app = builder.Build();

//Burada çağrılan uygulamalar/metotlar Middleware olarak adlandılırırlar. (Ara yazılım)

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

//Bu satırda oluşturulmuş uygulama çalıştırılıyor.
app.Run();
