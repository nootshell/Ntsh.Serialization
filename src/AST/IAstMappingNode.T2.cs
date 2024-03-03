namespace Ntsh.Serialization.AST {

	public interface IAstMappingNode<out TKeyNode, out TValueNode> : IAstNode where TKeyNode : IAstNode where TValueNode : IAstNode {

		TKeyNode Key { get; }
		TValueNode Value { get; }

	}

}
