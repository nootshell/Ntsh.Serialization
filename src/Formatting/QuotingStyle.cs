namespace Ntsh.Serialization.Formatting {

	public enum QuotingStyle {
		/// <summary>No quoting.</summary>
		None,

		/// <summary>Always quote.</summary>
		Always,

		/// <summary>Only quote if the context requires it.</summary>
		OnlyIfRequired,

		/// <summary>The hardcoded default.</summary>
		Default = Always
	}

}
