namespace Project4
{
    public interface IContainer<T>
    {
        void Clear();

        bool IsEmpty();

        int Count { get; set; }
    }
}