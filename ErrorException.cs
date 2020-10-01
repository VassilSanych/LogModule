using System;

namespace VGn.LogModule
{
	public class ErrorException : ApplicationException
	{
		public ErrorException(string message) : base(message) { }
	}

	public class DebugException : ApplicationException
	{
		public DebugException(string message) : base(message) { }
	}
}
