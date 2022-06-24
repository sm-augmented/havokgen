using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyCollisionModeData: hkbEntityPropertyControlData
	{
		public const string version = "0";
		public int m_collisionMode { get; set; }
		public const string m_collisionMode_Name = "collisionMode";
		public const string m_collisionMode_Type = "int";

	}
}
