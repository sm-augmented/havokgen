using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpTypedBroadPhaseHandle: hkpBroadPhaseHandle
	{
		public const string version = "0";
		public int m_type { get; set; }
		public const string m_type_Name = "type";
		public const string m_type_Type = "int";
		public int m_ownerOffset { get; set; }
		public const string m_ownerOffset_Name = "ownerOffset";
		public const string m_ownerOffset_Type = "int";
		public int m_objectQualityType { get; set; }
		public const string m_objectQualityType_Name = "objectQualityType";
		public const string m_objectQualityType_Type = "int";
		public int m_collisionFilterInfo { get; set; }
		public const string m_collisionFilterInfo_Name = "collisionFilterInfo";
		public const string m_collisionFilterInfo_Type = "int";

	}
}
