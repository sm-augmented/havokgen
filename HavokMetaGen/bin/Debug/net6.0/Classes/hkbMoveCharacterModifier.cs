using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbMoveCharacterModifier: hkbModifier
	{
		public const string version = "0";
		public List<float> m_offsetPerSecondMS { get; set; }
		public const string m_offsetPerSecondMS_Name = "offsetPerSecondMS";
		public const string m_offsetPerSecondMS_Type = "vec4";
		public float m_timeSinceLastModify { get; set; }
		public const string m_timeSinceLastModify_Name = "timeSinceLastModify";
		public const string m_timeSinceLastModify_Type = "real";

	}
}
