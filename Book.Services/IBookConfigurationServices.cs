using Book.Services.Dto;

namespace Book.Services
{
    public interface IBookConfigurationServices
    {
        BookConfigurationDto Create(BookConfigurationDto data);
        BookConfigurationDto GetConfiguration();
    }
}