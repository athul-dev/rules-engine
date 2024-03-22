namespace RootObject
{

	public interface ISurviewResultRootObject : IResultRootObject
	{

	}

	public class SurviewResultRootObject : ResultRootObject, ISurviewResultRootObject
	{

		public SurviewResultRootObject(System.Guid id) : base(id) {}

	}

}
