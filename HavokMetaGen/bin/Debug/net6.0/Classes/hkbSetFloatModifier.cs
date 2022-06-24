using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbSetFloatModifier: hkbModifier
	{
		public const string version = "0";
		public int m_variableIndex { get; set; }
		public const string m_variableIndex_Name = "variableIndex";
		public const string m_variableIndex_Type = "int";
		public float m_value { get; set; }
		public const string m_value_Name = "value";
		public const string m_value_Type = "real";
		public byte m_resetOnDeactivate { get; set; }
		public const string m_resetOnDeactivate_Name = "resetOnDeactivate";
		public const string m_resetOnDeactivate_Type = "byte";

	}
}
