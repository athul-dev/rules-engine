namespace RootObject
{

	public interface IHelixResultRootObject : IRotatingResultRootObject
	{

	}

	public class HelixResultRootObject : RotatingResultRootObject, IHelixResultRootObject
	{

		public HelixResultRootObject(System.Guid id) : base(id) {}

	}

}
