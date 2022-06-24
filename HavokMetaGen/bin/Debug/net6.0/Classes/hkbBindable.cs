using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBindable: hkReferencedObject
	{
		public const string version = "0";
		public hkbVariableBindingSet m_variableBindingSet { get; set; }
		public const string m_variableBindingSet_Name = "variableBindingSet";
		public const string m_variableBindingSet_Type = "ref";
		public int m_variableBindingSet_refId { get; set; }
		public const string m_variableBindingSet_Class = "hkbVariableBindingSet";
		public byte m_areBindablesCached { get; set; }
		public const string m_areBindablesCached_Name = "areBindablesCached";
		public const string m_areBindablesCached_Type = "byte";

	}
}
