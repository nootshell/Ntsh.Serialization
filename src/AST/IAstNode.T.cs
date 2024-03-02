using System;




namespace Ntsh.Serialization.AST {

	public interface IAstNode<TNodeType> : IAstNode where TNodeType : Enum {

		TNodeType NodeType { get; }

	}

}
