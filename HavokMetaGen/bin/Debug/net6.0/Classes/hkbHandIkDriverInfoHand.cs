using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbHandIkDriverInfoHand
	{
		public const string version = "1";
		public List<float> m_elbowAxisLS { get; set; }
		public const string m_elbowAxisLS_Name = "elbowAxisLS";
		public const string m_elbowAxisLS_Type = "vec4";
		public List<float> m_backHandNormalLS { get; set; }
		public const string m_backHandNormalLS_Name = "backHandNormalLS";
		public const string m_backHandNormalLS_Type = "vec4";
		public List<float> m_handOffsetLS { get; set; }
		public const string m_handOffsetLS_Name = "handOffsetLS";
		public const string m_handOffsetLS_Type = "vec4";
		public List<float> m_handOrienationOffsetLS { get; set; }
		public const string m_handOrienationOffsetLS_Name = "handOrienationOffsetLS";
		public const string m_handOrienationOffsetLS_Type = "vec4";
		public float m_maxElbowAngleDegrees { get; set; }
		public const string m_maxElbowAngleDegrees_Name = "maxElbowAngleDegrees";
		public const string m_maxElbowAngleDegrees_Type = "real";
		public float m_minElbowAngleDegrees { get; set; }
		public const string m_minElbowAngleDegrees_Name = "minElbowAngleDegrees";
		public const string m_minElbowAngleDegrees_Type = "real";
		public int m_shoulderIndex { get; set; }
		public const string m_shoulderIndex_Name = "shoulderIndex";
		public const string m_shoulderIndex_Type = "int";
		public int m_shoulderSiblingIndex { get; set; }
		public const string m_shoulderSiblingIndex_Name = "shoulderSiblingIndex";
		public const string m_shoulderSiblingIndex_Type = "int";
		public int m_elbowIndex { get; set; }
		public const string m_elbowIndex_Name = "elbowIndex";
		public const string m_elbowIndex_Type = "int";
		public int m_elbowSiblingIndex { get; set; }
		public const string m_elbowSiblingIndex_Name = "elbowSiblingIndex";
		public const string m_elbowSiblingIndex_Type = "int";
		public int m_wristIndex { get; set; }
		public const string m_wristIndex_Name = "wristIndex";
		public const string m_wristIndex_Type = "int";
		public byte m_enforceEndPosition { get; set; }
		public const string m_enforceEndPosition_Name = "enforceEndPosition";
		public const string m_enforceEndPosition_Type = "byte";
		public byte m_enforceEndRotation { get; set; }
		public const string m_enforceEndRotation_Name = "enforceEndRotation";
		public const string m_enforceEndRotation_Type = "byte";
		public string m_localFrameName { get; set; }
		public const string m_localFrameName_Name = "localFrameName";
		public const string m_localFrameName_Type = "string";

	}
}
