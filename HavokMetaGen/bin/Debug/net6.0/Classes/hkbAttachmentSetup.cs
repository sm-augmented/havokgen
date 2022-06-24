using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttachmentSetup: hkReferencedObject
	{
		public const string version = "3";
		public float m_blendInTime { get; set; }
		public const string m_blendInTime_Name = "blendInTime";
		public const string m_blendInTime_Type = "real";
		public float m_moveAttacherFraction { get; set; }
		public const string m_moveAttacherFraction_Name = "moveAttacherFraction";
		public const string m_moveAttacherFraction_Type = "real";
		public float m_gain { get; set; }
		public const string m_gain_Name = "gain";
		public const string m_gain_Type = "real";
		public float m_extrapolationTimeStep { get; set; }
		public const string m_extrapolationTimeStep_Name = "extrapolationTimeStep";
		public const string m_extrapolationTimeStep_Type = "real";
		public float m_fixUpGain { get; set; }
		public const string m_fixUpGain_Name = "fixUpGain";
		public const string m_fixUpGain_Type = "real";
		public float m_maxLinearDistance { get; set; }
		public const string m_maxLinearDistance_Name = "maxLinearDistance";
		public const string m_maxLinearDistance_Type = "real";
		public float m_maxAngularDistance { get; set; }
		public const string m_maxAngularDistance_Name = "maxAngularDistance";
		public const string m_maxAngularDistance_Type = "real";
		public int m_attachmentType { get; set; }
		public const string m_attachmentType_Name = "attachmentType";
		public const string m_attachmentType_Type = "int";
		public byte m_ignoreRotation { get; set; }
		public const string m_ignoreRotation_Name = "ignoreRotation";
		public const string m_ignoreRotation_Type = "byte";
		public byte m_ignoreUpComponent { get; set; }
		public const string m_ignoreUpComponent_Name = "ignoreUpComponent";
		public const string m_ignoreUpComponent_Type = "byte";
		public string m_attacherBoneName { get; set; }
		public const string m_attacherBoneName_Name = "attacherBoneName";
		public const string m_attacherBoneName_Type = "string";
		public string m_attacheeBoneName { get; set; }
		public const string m_attacheeBoneName_Name = "attacheeBoneName";
		public const string m_attacheeBoneName_Type = "string";
		public byte m_ignoreCollisionsBetweenActors { get; set; }
		public const string m_ignoreCollisionsBetweenActors_Name = "ignoreCollisionsBetweenActors";
		public const string m_ignoreCollisionsBetweenActors_Type = "byte";
		public byte m_ignoreAttacheePhysics { get; set; }
		public const string m_ignoreAttacheePhysics_Name = "ignoreAttacheePhysics";
		public const string m_ignoreAttacheePhysics_Type = "byte";

	}
}
