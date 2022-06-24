using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbVariableValueSet: hkReferencedObject
	{
		public const string version = "0";
		public List<hkbVariableValue> m_wordVariableValues { get; set; }
		public const string m_wordVariableValues_Name = "wordVariableValues";
		public const string m_wordVariableValues_Type = "struct";
		public const string m_wordVariableValues_Class = "hkbVariableValue";
		public const string m_wordVariableValues_Array = "True";
		public List<List<float>> m_quadVariableValues { get; set; }
		public const string m_quadVariableValues_Name = "quadVariableValues";
		public const string m_quadVariableValues_Type = "vec4";
		public const string m_quadVariableValues_Array = "True";
		public List<hkReferencedObject> m_variantVariableValues { get; set; }
		public const string m_variantVariableValues_Name = "variantVariableValues";
		public const string m_variantVariableValues_Type = "ref";
		public List<int> m_variantVariableValues_refId { get; set; }
		public const string m_variantVariableValues_Class = "hkReferencedObject";
		public const string m_variantVariableValues_Array = "True";

	}
}
