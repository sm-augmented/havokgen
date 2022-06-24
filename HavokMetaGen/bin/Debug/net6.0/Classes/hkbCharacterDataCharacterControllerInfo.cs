using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCharacterDataCharacterControllerInfo
	{
		public const string version = "0";
		public float m_capsuleHeight { get; set; }
		public const string m_capsuleHeight_Name = "capsuleHeight";
		public const string m_capsuleHeight_Type = "real";
		public float m_capsuleRadius { get; set; }
		public const string m_capsuleRadius_Name = "capsuleRadius";
		public const string m_capsuleRadius_Type = "real";
		public int m_collisionFilterInfo { get; set; }
		public const string m_collisionFilterInfo_Name = "collisionFilterInfo";
		public const string m_collisionFilterInfo_Type = "int";
		public hkpCharacterControllerCinfo m_characterControllerCinfo { get; set; }
		public const string m_characterControllerCinfo_Name = "characterControllerCinfo";
		public const string m_characterControllerCinfo_Type = "ref";
		public int m_characterControllerCinfo_refId { get; set; }
		public const string m_characterControllerCinfo_Class = "hkpCharacterControllerCinfo";

	}
}
