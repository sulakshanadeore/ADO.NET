namespace ExceptionLibrary
{


	[Serializable]
	public class ProductNameTooLongException : Exception
	{
		public ProductNameTooLongException() { }
		public ProductNameTooLongException(string message) : base(message) { }
		public ProductNameTooLongException(string message, Exception inner) : base(message, inner) { }
		protected ProductNameTooLongException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
