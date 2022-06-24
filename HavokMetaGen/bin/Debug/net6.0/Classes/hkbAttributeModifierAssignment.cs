using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttributeModifierAssignment
	{
		public const string version = "0";
		public int m_attributeIndex { get; set; }
		public const string m_attributeIndex_Name = "attributeIndex";
		public const string m_attributeIndex_Type = "int";
		public float m_attributeValue { get; set; }
		public const string m_attributeValue_Name = "attributeValue";
		public const string m_attributeValue_Type = "real";

	}
}
