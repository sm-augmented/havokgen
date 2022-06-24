using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCacheVariableModifier: hkbModifier
	{
		public const string version = "0";
		public int m_inputVariableIndex { get; set; }
		public const string m_inputVariableIndex_Name = "inputVariableIndex";
		public const string m_inputVariableIndex_Type = "int";
		public int m_outputVariableIndex { get; set; }
		public const string m_outputVariableIndex_Name = "outputVariableIndex";
		public const string m_outputVariableIndex_Type = "int";
		public byte m_canGenerateOnSPU { get; set; }
		public const string m_canGenerateOnSPU_Name = "canGenerateOnSPU";
		public const string m_canGenerateOnSPU_Type = "byte";

	}
}
