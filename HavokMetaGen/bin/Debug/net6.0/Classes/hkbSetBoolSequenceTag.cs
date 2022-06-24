using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbSetBoolSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public int m_variableIndex { get; set; }
		public const string m_variableIndex_Name = "variableIndex";
		public const string m_variableIndex_Type = "int";
		public byte m_value { get; set; }
		public const string m_value_Name = "value";
		public const string m_value_Type = "byte";
		public byte m_resetOnExit { get; set; }
		public const string m_resetOnExit_Name = "resetOnExit";
		public const string m_resetOnExit_Type = "byte";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";

	}
}
