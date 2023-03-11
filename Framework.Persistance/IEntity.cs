namespace Framework.Persistance
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
