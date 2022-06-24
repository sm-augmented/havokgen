using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttachmentSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbHandle m_targetHandle { get; set; }
		public const string m_targetHandle_Name = "targetHandle";
		public const string m_targetHandle_Type = "ref";
		public int m_targetHandle_refId { get; set; }
		public const string m_targetHandle_Class = "hkbHandle";
		public string m_targetBoneName { get; set; }
		public const string m_targetBoneName_Name = "targetBoneName";
		public const string m_targetBoneName_Type = "string";
		public string m_selfBoneName { get; set; }
		public const string m_selfBoneName_Name = "selfBoneName";
		public const string m_selfBoneName_Type = "string";
		public byte m_ignoreRotation { get; set; }
		public const string m_ignoreRotation_Name = "ignoreRotation";
		public const string m_ignoreRotation_Type = "byte";
		public byte m_ignoreCollisionBetweenActors { get; set; }
		public const string m_ignoreCollisionBetweenActors_Name = "ignoreCollisionBetweenActors";
		public const string m_ignoreCollisionBetweenActors_Type = "byte";
		public byte m_useContinuousAttachment { get; set; }
		public const string m_useContinuousAttachment_Name = "useContinuousAttachment";
		public const string m_useContinuousAttachment_Type = "byte";
		public List<float> m_defaultPosition { get; set; }
		public const string m_defaultPosition_Name = "defaultPosition";
		public const string m_defaultPosition_Type = "vec4";
		public List<float> m_defaultRotation { get; set; }
		public const string m_defaultRotation_Name = "defaultRotation";
		public const string m_defaultRotation_Type = "vec4";
		public byte m_disablePhysics { get; set; }
		public const string m_disablePhysics_Name = "disablePhysics";
		public const string m_disablePhysics_Type = "byte";
		public hkbHandle m_selfHandle { get; set; }
		public const string m_selfHandle_Name = "selfHandle";
		public const string m_selfHandle_Type = "struct";
		public const string m_selfHandle_Class = "hkbHandle";
		public float m_blendFraction { get; set; }
		public const string m_blendFraction_Name = "blendFraction";
		public const string m_blendFraction_Type = "real";
		public float m_mostRecentTimeStep { get; set; }
		public const string m_mostRecentTimeStep_Name = "mostRecentTimeStep";
		public const string m_mostRecentTimeStep_Type = "real";
		public List<float> m_selfWorldFromBone { get; set; }
		public const string m_selfWorldFromBone_Name = "selfWorldFromBone";
		public const string m_selfWorldFromBone_Type = "vec12";

	}
}
