using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbReactionStateChooser: hkbStateChooser
	{
		public const string version = "0";
		public List<hkbReactionStateChooserReactionState> m_reactionStates { get; set; }
		public const string m_reactionStates_Name = "reactionStates";
		public const string m_reactionStates_Type = "ref";
		public List<int> m_reactionStates_refId { get; set; }
		public const string m_reactionStates_Class = "hkbReactionStateChooserReactionState";
		public const string m_reactionStates_Array = "True";

	}
}
