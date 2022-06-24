using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttackAlignmentSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbHandle m_targetHandle { get; set; }
		public const string m_targetHandle_Name = "targetHandle";
		public const string m_targetHandle_Type = "ref";
		public int m_targetHandle_refId { get; set; }
		public const string m_targetHandle_Class = "hkbHandle";
		public List<float> m_defaultDirection { get; set; }
		public const string m_defaultDirection_Name = "defaultDirection";
		public const string m_defaultDirection_Type = "vec4";
		public int m_defaultDirectionAlignment { get; set; }
		public const string m_defaultDirectionAlignment_Name = "defaultDirectionAlignment";
		public const string m_defaultDirectionAlignment_Type = "int";
		public byte m_isDefaultSteerable { get; set; }
		public const string m_isDefaultSteerable_Name = "isDefaultSteerable";
		public const string m_isDefaultSteerable_Type = "byte";
		public byte m_clampRotation { get; set; }
		public const string m_clampRotation_Name = "clampRotation";
		public const string m_clampRotation_Type = "byte";
		public float m_maxRotation { get; set; }
		public const string m_maxRotation_Name = "maxRotation";
		public const string m_maxRotation_Type = "real";
		public float m_offsetRotation { get; set; }
		public const string m_offsetRotation_Name = "offsetRotation";
		public const string m_offsetRotation_Type = "real";
		public byte m_useOffsetWithValidTarget { get; set; }
		public const string m_useOffsetWithValidTarget_Name = "useOffsetWithValidTarget";
		public const string m_useOffsetWithValidTarget_Type = "byte";
		public List<float> m_targetDirection { get; set; }
		public const string m_targetDirection_Name = "targetDirection";
		public const string m_targetDirection_Type = "vec4";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";
		public float m_lastTimeStep { get; set; }
		public const string m_lastTimeStep_Name = "lastTimeStep";
		public const string m_lastTimeStep_Type = "real";
		public List<float> m_cachedDirection { get; set; }
		public const string m_cachedDirection_Name = "cachedDirection";
		public const string m_cachedDirection_Type = "vec4";
		public float m_blendFraction { get; set; }
		public const string m_blendFraction_Name = "blendFraction";
		public const string m_blendFraction_Type = "real";

	}
}
