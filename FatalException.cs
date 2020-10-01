using System;

namespace VGn.LogModule
{
	public class FatalException : ApplicationException
	{
		public FatalException(string message) : base(message) { }
	}
}
