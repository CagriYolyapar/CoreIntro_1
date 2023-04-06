//Burası MiddleWare işlemlerinin yapıldıgı alandır...

//MiddleWare requestleriniz ilgili adrese gitmeden önce Proje ile ilgili ayarlamalarınızın yapıldığı yerdir...

//Önce sistemin inşaası saglanır...

WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //burada sistemi mekanizma önce yaratılır...

builder.Services.AddControllersWithViews(); //builder'a Controllerlar ve Viewlar ile ilgili özelliklere sahip olması gerektigini bildirdim...




WebApplication app = builder.Build(); //bu mekanizmanın inşaa işlemini tetiklemesi saglanır... Elimize gecen deger (app isimli degişkende saklanır) artık işlemlerimizi yapabiliriz...

app.UseRouting(); //burada Url bazlı bir yönlendirme kullanılacagını söylüyoruz...Eger bunu demezsek

//app.MapDefaultControllerRoute(); //bu rota haritalamasında Controller Home  , Action da Index olsun demekle aynı şeydir...

//Lakin eger baslangıc sayfanızı kendi istediginiz şekilde tasarlamak istiyorsanız


app.MapControllerRoute(
    name:"default",
    pattern : "{controller=Category}/{action=CategoryList}/{id?}"

    );

app.Run();
