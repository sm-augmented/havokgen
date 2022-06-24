using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpMotion: hkReferencedObject
	{
		public const string version = "3";
		public byte m_type { get; set; }
		public const string m_type_Name = "type";
		public const string m_type_Type = "byte";
		public byte m_deactivationIntegrateCounter { get; set; }
		public const string m_deactivationIntegrateCounter_Name = "deactivationIntegrateCounter";
		public const string m_deactivationIntegrateCounter_Type = "byte";
		public List<int> m_deactivationNumInactiveFrames { get; set; }
		public const string m_deactivationNumInactiveFrames_Name = "deactivationNumInactiveFrames";
		public const string m_deactivationNumInactiveFrames_Type = "int";
		public const string m_deactivationNumInactiveFrames_Count = "2";
		public hkMotionState m_motionState { get; set; }
		public const string m_motionState_Name = "motionState";
		public const string m_motionState_Type = "struct";
		public const string m_motionState_Class = "hkMotionState";
		public List<float> m_inertiaAndMassInv { get; set; }
		public const string m_inertiaAndMassInv_Name = "inertiaAndMassInv";
		public const string m_inertiaAndMassInv_Type = "vec4";
		public List<float> m_linearVelocity { get; set; }
		public const string m_linearVelocity_Name = "linearVelocity";
		public const string m_linearVelocity_Type = "vec4";
		public List<float> m_angularVelocity { get; set; }
		public const string m_angularVelocity_Name = "angularVelocity";
		public const string m_angularVelocity_Type = "vec4";
		public List<List<float>> m_deactivationRefPosition { get; set; }
		public const string m_deactivationRefPosition_Name = "deactivationRefPosition";
		public const string m_deactivationRefPosition_Type = "vec4";
		public const string m_deactivationRefPosition_Count = "2";
		public List<int> m_deactivationRefOrientation { get; set; }
		public const string m_deactivationRefOrientation_Name = "deactivationRefOrientation";
		public const string m_deactivationRefOrientation_Type = "int";
		public const string m_deactivationRefOrientation_Count = "2";
		public hkpMotion m_savedMotion { get; set; }
		public const string m_savedMotion_Name = "savedMotion";
		public const string m_savedMotion_Type = "ref";
		public int m_savedMotion_refId { get; set; }
		public const string m_savedMotion_Class = "hkpMotion";
		public int m_savedQualityTypeIndex { get; set; }
		public const string m_savedQualityTypeIndex_Name = "savedQualityTypeIndex";
		public const string m_savedQualityTypeIndex_Type = "int";
		public float m_gravityFactor { get; set; }
		public const string m_gravityFactor_Name = "gravityFactor";
		public const string m_gravityFactor_Type = "real";

	}
}
