using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBehaviorGraph: hkbGenerator
	{
		public const string version = "1";
		public int m_variableMode { get; set; }
		public const string m_variableMode_Name = "variableMode";
		public const string m_variableMode_Type = "int";
		public hkbGenerator m_rootGenerator { get; set; }
		public const string m_rootGenerator_Name = "rootGenerator";
		public const string m_rootGenerator_Type = "ref";
		public int m_rootGenerator_refId { get; set; }
		public const string m_rootGenerator_Class = "hkbGenerator";
		public hkbBehaviorGraphData m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "ref";
		public int m_data_refId { get; set; }
		public const string m_data_Class = "hkbBehaviorGraphData";
		public int m_numIntermediateOutputs { get; set; }
		public const string m_numIntermediateOutputs_Name = "numIntermediateOutputs";
		public const string m_numIntermediateOutputs_Type = "int";
		public int m_numStaticNodes { get; set; }
		public const string m_numStaticNodes_Name = "numStaticNodes";
		public const string m_numStaticNodes_Type = "int";
		public int m_nextUniqueId { get; set; }
		public const string m_nextUniqueId_Name = "nextUniqueId";
		public const string m_nextUniqueId_Type = "int";
		public byte m_isActive { get; set; }
		public const string m_isActive_Name = "isActive";
		public const string m_isActive_Type = "byte";
		public byte m_isLinked { get; set; }
		public const string m_isLinked_Name = "isLinked";
		public const string m_isLinked_Type = "byte";
		public byte m_updateActiveNodes { get; set; }
		public const string m_updateActiveNodes_Name = "updateActiveNodes";
		public const string m_updateActiveNodes_Type = "byte";
		public byte m_stateOrTransitionChanged { get; set; }
		public const string m_stateOrTransitionChanged_Name = "stateOrTransitionChanged";
		public const string m_stateOrTransitionChanged_Type = "byte";

	}
}
