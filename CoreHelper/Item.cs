using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreHelper
{
    public interface IItem
    {
        Guid Id { get; }

        IList<IItem> Children { get; }

        IDictionary<string, IFieldFact> FactCollection { get; }

        IFieldFact this[string key] { get; set; }

        void AddChild(IItem child);

        T GetFact<T>(string parameterName) where T : class, IFact;

        T GetFact<T>(string parameterName, Guid childId) where T : class, IFact;

        IDictionary<string, IFieldFact> GetFacts();

        IDictionary<string, IFieldFact> GetFacts(Guid childId);
    }

    public abstract class Item : IItem
    {
        protected Item(Guid id)
        {
            Id = id;
            Children = new List<IItem>();
            FactCollection = new Dictionary<string, IFieldFact>();
        }

        public Guid Id { get; }

        public IList<IItem> Children { get; }

        public IDictionary<string, IFieldFact> FactCollection { get; }

        public IFieldFact this[string key]
        {
            get => FactCollection.ContainsKey(key) ? FactCollection[key] : default(IFieldFact);
            set => FactCollection[key] = value;
        }

        public void AddChild(IItem child)
        {
            Children.Add(child);
        }

        public T GetFact<T>(string parameterName) where T : class, IFact
        {
            if (FactCollection.ContainsKey(parameterName))
            {
                return FactCollection[parameterName] as T;
            }

            foreach (var child in Children)
            {
                var value = child.GetFact<T>(parameterName);

                if (value != null)
                {
                    return value;
                }
            }

            return null;
        }

        public T GetFact<T>(string parameterName, Guid childId) where T : class, IFact
        {
            if (FactCollection.ContainsKey(parameterName))
            {
                return FactCollection[parameterName] as T;
            }

            IItem currentChild = Children.First(x => x.Id == childId);

            var value = currentChild.GetFact<T>(parameterName, childId);

            if (value != null)
            {
                return value;
            }

            return null;
        }

        public IDictionary<string, IFieldFact> GetFacts()
        {
            IDictionary<string, IFieldFact> collection = new Dictionary<string, IFieldFact>(FactCollection);

            foreach (var child in Children)
            {
                var childFacts = child.GetFacts();
                foreach (var childFact in childFacts)
                {
                    collection.Add(childFact.Key, childFact.Value);
                }
            }

            return collection;
        }

        public IDictionary<string, IFieldFact> GetFacts(Guid childId)
        {
            IDictionary<string, IFieldFact> collection = new Dictionary<string, IFieldFact>(FactCollection);

            IItem currentChild = Children.First(x => x.Id == childId);

            var childFacts = currentChild.GetFacts();
            foreach (var childFact in childFacts)
            {
                collection.Add(childFact.Key, childFact.Value);
            }

            return collection;
        }
    }
}
