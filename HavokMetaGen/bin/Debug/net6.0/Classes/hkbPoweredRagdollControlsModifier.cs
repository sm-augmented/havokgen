using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbPoweredRagdollControlsModifier: hkbModifier
	{
		public const string version = "5";
		public hkbPoweredRagdollControlData m_controlData { get; set; }
		public const string m_controlData_Name = "controlData";
		public const string m_controlData_Type = "struct";
		public const string m_controlData_Class = "hkbPoweredRagdollControlData";
		public hkbBoneIndexArray m_bones { get; set; }
		public const string m_bones_Name = "bones";
		public const string m_bones_Type = "ref";
		public int m_bones_refId { get; set; }
		public const string m_bones_Class = "hkbBoneIndexArray";
		public hkbWorldFromModelModeData m_worldFromModelModeData { get; set; }
		public const string m_worldFromModelModeData_Name = "worldFromModelModeData";
		public const string m_worldFromModelModeData_Type = "struct";
		public const string m_worldFromModelModeData_Class = "hkbWorldFromModelModeData";
		public hkbBoneWeightArray m_boneWeights { get; set; }
		public const string m_boneWeights_Name = "boneWeights";
		public const string m_boneWeights_Type = "ref";
		public int m_boneWeights_refId { get; set; }
		public const string m_boneWeights_Class = "hkbBoneWeightArray";

	}
}
