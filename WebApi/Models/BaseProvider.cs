namespace WebApi.Models;
public abstract class BaseProvider : IDisposable{
    StoreContext? context;
    IHttpContextAccessor accessor;
    public BaseProvider(IHttpContextAccessor accessor) => this.accessor = accessor;

    protected StoreContext Context => context 
            ??= accessor.HttpContext!.RequestServices.GetRequiredService<StoreContext>();

    public void Dispose()
    {
        if (context != null){
            context.Dispose();
        }
    }
}