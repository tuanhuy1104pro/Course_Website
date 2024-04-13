using Course_Website.StartUpExtension;



var builder = WebApplication.CreateBuilder(args);
builder.Services.ServicesStartUp(builder.Configuration);
var app = builder.Build();

app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

