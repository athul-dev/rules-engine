using System;
using System.Collections.Generic;

namespace CoreHelper
{
    public interface IFact
    {
        string Name { get; }

        Type Type { get; }

        IDictionary<string, Predicate<IToken>> SlotPredicates { get; }

        IDictionary<string, ISlot> Slots { get; }

        object GetValue(string slotValue);

    }
}