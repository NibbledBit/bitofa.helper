using System;

namespace BitOfA.Helper.Persistence
{
    public interface IKeyedRecord<T> where T : struct
    {
        public T Id { get; set; }
    }
    public interface IIntKeyedRecord : IKeyedRecord<int>
    {

    }
    public interface ILongKeyedRecord : IKeyedRecord<long>
    {

    }
    public interface IGuidKeyedRecord : IKeyedRecord<Guid>
    {

    }
}
