using CoreHelper;

namespace Core
{
    public interface IWorkingMemory
    {
        IRootObject RootObject { get; }
    }
    public class WorkingMemory:IWorkingMemory
    {
        public WorkingMemory(IRootObject rootObject)
        {
            RootObject = rootObject;
        }

        public IRootObject RootObject { get; }
    }

    internal interface IWorkingMemoryManager
    {
        IWorkingMemory Memory { get; }
    }

    internal class WorkingMemoryManager : IWorkingMemoryManager
    {
        public IWorkingMemory Memory { get; }

        public WorkingMemoryManager(IWorkingMemory workingMemory)
        {
            this.Memory = workingMemory;
        }

    }
}