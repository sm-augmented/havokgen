using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttackDistanceSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbHandle m_targetHandle { get; set; }
		public const string m_targetHandle_Name = "targetHandle";
		public const string m_targetHandle_Type = "ref";
		public int m_targetHandle_refId { get; set; }
		public const string m_targetHandle_Class = "hkbHandle";
		public float m_defaultDistance { get; set; }
		public const string m_defaultDistance_Name = "defaultDistance";
		public const string m_defaultDistance_Type = "real";
		public float m_targetDistance { get; set; }
		public const string m_targetDistance_Name = "targetDistance";
		public const string m_targetDistance_Type = "real";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";
		public List<float> m_cachedSelfPosition { get; set; }
		public const string m_cachedSelfPosition_Name = "cachedSelfPosition";
		public const string m_cachedSelfPosition_Type = "vec4";
		public float m_branchInMultiplier { get; set; }
		public const string m_branchInMultiplier_Name = "branchInMultiplier";
		public const string m_branchInMultiplier_Type = "real";

	}
}
