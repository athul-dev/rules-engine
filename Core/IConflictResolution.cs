using System.Collections.Generic;
using System.Linq;
using CoreHelper;

namespace Core
{
    enum ConflictResolutionStrategy
    {
        Depth,
        Breadth
    }

    interface IConflictResolution
    {
        IRuleNode GetRuleNode();

        void AddRuleNode(int priority, IRuleNode node);

        bool HasRules();
    }

    static class ConflictResolutionFactory
    {
        public static IConflictResolution GetConflictResolution(ConflictResolutionStrategy conflictResolutionStrategy)
        {
            if (conflictResolutionStrategy == ConflictResolutionStrategy.Depth)
            {
                return new DepthConflictResolution();
            }
            if (conflictResolutionStrategy == ConflictResolutionStrategy.Breadth)
            {
                return new BreadthConflictResolution();
            }

            return null;
        }
    }

    class DepthConflictResolution:IConflictResolution
    {
        private readonly PriorityStack<IRuleNode> priorityStack = new PriorityStack<IRuleNode>();

        public IRuleNode GetRuleNode()
        {
           return priorityStack.Pop();
        }

        public void AddRuleNode(int priority, IRuleNode node)
        {
            priorityStack.Push(priority, node);
        }

        public bool HasRules()
        {
            return priorityStack.HasItems();
        }
    }

    class BreadthConflictResolution : IConflictResolution
    {
        private readonly PriorityQueue<IRuleNode> priorityQueue = new PriorityQueue<IRuleNode>();
        public IRuleNode GetRuleNode()
        {
            return priorityQueue.Dequeue();
        }

        public void AddRuleNode(int priority, IRuleNode node)
        {
            priorityQueue.Enqueue(priority, node);
        }

        public bool HasRules()
        {
            return priorityQueue.HasItems();
        }
    }


    /// <summary>
    /// Priority stack is used for Conflict resolution strategy - Depth 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityStack<T>
    {
        readonly SortedDictionary<int, IList<T>> internalDataStructure = new SortedDictionary<int, IList<T>>();

        public T Pop()
        {
            if (internalDataStructure.Keys.Count > 0)
            {
                var lastKey = internalDataStructure.Keys.Last();
                do
                {
                    if (!internalDataStructure.ContainsKey(lastKey))
                    {
                        continue;
                    }

                    if (internalDataStructure[lastKey].Count > 0)
                    {
                        var lastAddedElement = internalDataStructure[lastKey].Last();
                        internalDataStructure[lastKey].Remove(lastAddedElement);
                        return lastAddedElement;
                    }

                } while (lastKey-->=0);
               
            }
            return default(T);
        }

        public void Push(int priority, T value)
        {
            if (!internalDataStructure.ContainsKey(priority))
            {
                internalDataStructure[priority] = new List<T>();
            }

            if (internalDataStructure[priority].Contains(value))
            {
                internalDataStructure[priority].Remove(value);
            }

            internalDataStructure[priority].Add(value);
        }

        public bool HasItems()
        {
            foreach (var list in internalDataStructure)
            {
                if (list.Value.Count > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }

    /// <summary>
    ///  Priority queue is used for Conflict resolution strategy - breath 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueue<T>
    {
        readonly SortedDictionary<int, IList<T>> internalDataStructure = new SortedDictionary<int, IList<T>>();

        public T Dequeue()
        {
            if (internalDataStructure.Keys.Count > 0)
            {
                var lastKey = internalDataStructure.Keys.Last();
                do
                {
                    if (!internalDataStructure.ContainsKey(lastKey))
                    {
                        continue;
                    }

                    if (internalDataStructure[lastKey].Count > 0)
                    {
                        var firstElement = internalDataStructure[lastKey].First();
                        internalDataStructure[lastKey].Remove(firstElement);
                        return firstElement;
                    }

                } while (lastKey-- >= 0);

            }
            return default(T);
        }

        public void Enqueue(int priority, T value)
        {
            if (!internalDataStructure.ContainsKey(priority))
            {
                internalDataStructure[priority] = new List<T>();
            }

            if (internalDataStructure[priority].Contains(value))
            {
                internalDataStructure[priority].Remove(value);
            }

            internalDataStructure[priority].Add(value);
        }

        public bool HasItems()
        {
            foreach (var list in internalDataStructure)
            {
                if (list.Value.Count > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}