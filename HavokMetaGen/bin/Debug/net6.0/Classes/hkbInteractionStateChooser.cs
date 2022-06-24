using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbInteractionStateChooser: hkbStateChooser
	{
		public const string version = "0";
		public List<hkbInteractionStateChooserInteractionState> m_interactionStates { get; set; }
		public const string m_interactionStates_Name = "interactionStates";
		public const string m_interactionStates_Type = "ref";
		public List<int> m_interactionStates_refId { get; set; }
		public const string m_interactionStates_Class = "hkbInteractionStateChooserInteractionState";
		public const string m_interactionStates_Array = "True";

	}
}
