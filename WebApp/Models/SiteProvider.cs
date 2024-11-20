namespace WebApp.Models;
public class SiteProvider{
    CategoryRepository? category;
    IConfiguration configuration;
    public SiteProvider(IConfiguration configuration)
        => this.configuration = configuration;
    public CategoryRepository Category 
        => category ?? new CategoryRepository(configuration);

UploadRepository? upload;
    public UploadRepository Upload 
        => upload ?? new UploadRepository(configuration);
}