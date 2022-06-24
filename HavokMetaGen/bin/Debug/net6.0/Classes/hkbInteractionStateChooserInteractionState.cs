using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbInteractionStateChooserInteractionState: hkbStateChooserEntry
	{
		public const string version = "0";
		public string m_interactionKey { get; set; }
		public const string m_interactionKey_Name = "interactionKey";
		public const string m_interactionKey_Type = "string";

	}
}
