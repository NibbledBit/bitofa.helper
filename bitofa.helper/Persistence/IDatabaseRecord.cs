namespace BitOfA.Helper.Persistence
{
    public interface IKeyedRecord<T> where T : struct
    {
        public T Id { get; set; }
    }
    public interface IStandardRecord : IKeyedRecord<int>
    {

    }
    public class TestRecord : IStandardRecord
    {
        public int Id { get; set; }
    }
}
