using System;

namespace CoreHelper
{
    public interface IToken
    {
        IWorkingMemoryItem<IFact> WorkingMemoryItem { get; }

        Guid Id { get; }
    }
}