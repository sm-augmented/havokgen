using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbWeaponHitPayload: hkbEventPayload
	{
		public const string version = "0";
		public string m_reactionType { get; set; }
		public const string m_reactionType_Name = "reactionType";
		public const string m_reactionType_Type = "string";

	}
}
