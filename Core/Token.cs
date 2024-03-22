using System;
using CoreHelper;

namespace Core
{
    
    public class WorkingMemoryItem<T> : IWorkingMemoryItem<T>
    {
        public WorkingMemoryItem(T field)
        {
            Field = field;
        }

        public T Field { get;}
        
    }


   

    public class Token : IToken
    {
        public Token(IWorkingMemoryItem<IFact> workingMemoryItem, Guid id)
        {
            WorkingMemoryItem = workingMemoryItem;
            Id = id;
        }

        public IWorkingMemoryItem<IFact> WorkingMemoryItem { get; }
        public Guid Id { get; }
    }



    public interface IFlagToken
    {
        IWorkingMemoryItem<IFlag> WorkingMemoryItem { get; }
    }

    public class FlagToken : IFlagToken
    {
        public IWorkingMemoryItem<IFlag> WorkingMemoryItem { get; }
    }


    public interface IFlag
    {
        string Name { get; }

        bool Value { get; }
    }

}