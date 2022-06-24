using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbVariableBindingSet: hkReferencedObject
	{
		public const string version = "2";
		public List<hkbVariableBindingSetBinding> m_bindings { get; set; }
		public const string m_bindings_Name = "bindings";
		public const string m_bindings_Type = "struct";
		public const string m_bindings_Class = "hkbVariableBindingSetBinding";
		public const string m_bindings_Array = "True";
		public int m_indexOfBindingToEnable { get; set; }
		public const string m_indexOfBindingToEnable_Name = "indexOfBindingToEnable";
		public const string m_indexOfBindingToEnable_Type = "int";
		public byte m_hasOutputBinding { get; set; }
		public const string m_hasOutputBinding_Name = "hasOutputBinding";
		public const string m_hasOutputBinding_Type = "byte";

	}
}
