using System.Collections.Generic;




namespace Ntsh.Serialization.AST {

	public interface IAstParentNode<TChildNode> : IAstNode where TChildNode : IAstNode {

		ICollection<TChildNode> Children { get; }

	}

}
