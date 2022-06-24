using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbHandle: hkReferencedObject
	{
		public const string version = "1";
		public hkLocalFrame m_frame { get; set; }
		public const string m_frame_Name = "frame";
		public const string m_frame_Type = "ref";
		public int m_frame_refId { get; set; }
		public const string m_frame_Class = "hkLocalFrame";
		public hkpRigidBody m_rigidBody { get; set; }
		public const string m_rigidBody_Name = "rigidBody";
		public const string m_rigidBody_Type = "ref";
		public int m_rigidBody_refId { get; set; }
		public const string m_rigidBody_Class = "hkpRigidBody";
		public int m_animationBoneIndex { get; set; }
		public const string m_animationBoneIndex_Name = "animationBoneIndex";
		public const string m_animationBoneIndex_Type = "int";
		public hkbCharacter m_character { get; set; }
		public const string m_character_Name = "character";
		public const string m_character_Type = "ref";
		public int m_character_refId { get; set; }
		public const string m_character_Class = "hkbCharacter";

	}
}
