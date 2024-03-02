using System;




namespace Ntsh.Serialization.Formatting {

	public class QuotingStyleNotSupportedException : NotSupportedException {

		public QuotingStyleNotSupportedException(string? message) : base(message) { }

		public QuotingStyleNotSupportedException() : base() { }

	}

}
