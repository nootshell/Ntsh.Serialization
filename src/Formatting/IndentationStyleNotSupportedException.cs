using System;




namespace Ntsh.Serialization.Formatting {

	public class IndentationStyleNotSupportedException : NotSupportedException {

		public IndentationStyleNotSupportedException(string? message) : base(message) { }

		public IndentationStyleNotSupportedException() : base() { }

	}

}
