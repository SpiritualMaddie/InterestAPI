namespace InterestAPI.Services.IServices
{
    public interface IServices<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Add(T item);
        Task<T>? GetSpecific(int id);
        Task<T>? Update(int id, T request);
        Task<List<T>>? Delete(int id);
    }
}
