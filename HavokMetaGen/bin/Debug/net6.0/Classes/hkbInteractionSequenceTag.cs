using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbInteractionSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public hkbHandle m_interactionTarget { get; set; }
		public const string m_interactionTarget_Name = "interactionTarget";
		public const string m_interactionTarget_Type = "ref";
		public int m_interactionTarget_refId { get; set; }
		public const string m_interactionTarget_Class = "hkbHandle";
		public hkbInteractionPayload m_interaction { get; set; }
		public const string m_interaction_Name = "interaction";
		public const string m_interaction_Type = "ref";
		public int m_interaction_refId { get; set; }
		public const string m_interaction_Class = "hkbInteractionPayload";
		public hkbEventProperty m_successEvent { get; set; }
		public const string m_successEvent_Name = "successEvent";
		public const string m_successEvent_Type = "struct";
		public const string m_successEvent_Class = "hkbEventProperty";
		public hkbEventProperty m_failEvent { get; set; }
		public const string m_failEvent_Name = "failEvent";
		public const string m_failEvent_Type = "struct";
		public const string m_failEvent_Class = "hkbEventProperty";
		public byte m_setAttackerHandles { get; set; }
		public const string m_setAttackerHandles_Name = "setAttackerHandles";
		public const string m_setAttackerHandles_Type = "byte";
		public byte m_responseReceived { get; set; }
		public const string m_responseReceived_Name = "responseReceived";
		public const string m_responseReceived_Type = "byte";

	}
}
