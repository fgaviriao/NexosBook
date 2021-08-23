namespace Book.Data.Repositories
{
    public interface IBookConfigurationRepository
    {
        BookConfiguration GetConfiguration();
        bool SaveChanges();
        void Update(BookConfiguration data);
    }
}