using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbReactionStateChooserReactionState: hkbStateChooserEntry
	{
		public const string version = "0";
		public string m_interactionKey { get; set; }
		public const string m_interactionKey_Name = "interactionKey";
		public const string m_interactionKey_Type = "string";
		public int m_hitZone { get; set; }
		public const string m_hitZone_Name = "hitZone";
		public const string m_hitZone_Type = "int";

	}
}
