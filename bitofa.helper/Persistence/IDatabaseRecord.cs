namespace BitOfA.Helper.Persistence
{
    public interface IKeyedRecord<T> where T : struct
    {
        public T Id { get; set; }
    }
    public interface IIntKeyRecord : IKeyedRecord<int>
    {

    }
    public class TestRecord : IIntKeyRecord
    {
        public int Id { get; set; }
    }
}
