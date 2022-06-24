using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStateMachineStateInfo: hkbBindable
	{
		public const string version = "7";
		public List<hkbStateListener> m_listeners { get; set; }
		public const string m_listeners_Name = "listeners";
		public const string m_listeners_Type = "ref";
		public List<int> m_listeners_refId { get; set; }
		public const string m_listeners_Class = "hkbStateListener";
		public const string m_listeners_Array = "True";
		public hkbStateMachineEventPropertyArray m_enterNotifyEvents { get; set; }
		public const string m_enterNotifyEvents_Name = "enterNotifyEvents";
		public const string m_enterNotifyEvents_Type = "ref";
		public int m_enterNotifyEvents_refId { get; set; }
		public const string m_enterNotifyEvents_Class = "hkbStateMachineEventPropertyArray";
		public hkbStateMachineEventPropertyArray m_exitNotifyEvents { get; set; }
		public const string m_exitNotifyEvents_Name = "exitNotifyEvents";
		public const string m_exitNotifyEvents_Type = "ref";
		public int m_exitNotifyEvents_refId { get; set; }
		public const string m_exitNotifyEvents_Class = "hkbStateMachineEventPropertyArray";
		public hkbStateMachineTransitionInfoArray m_transitions { get; set; }
		public const string m_transitions_Name = "transitions";
		public const string m_transitions_Type = "ref";
		public int m_transitions_refId { get; set; }
		public const string m_transitions_Class = "hkbStateMachineTransitionInfoArray";
		public hkbGenerator m_generator { get; set; }
		public const string m_generator_Name = "generator";
		public const string m_generator_Type = "ref";
		public int m_generator_refId { get; set; }
		public const string m_generator_Class = "hkbGenerator";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public int m_stateId { get; set; }
		public const string m_stateId_Name = "stateId";
		public const string m_stateId_Type = "int";
		public float m_probability { get; set; }
		public const string m_probability_Name = "probability";
		public const string m_probability_Type = "real";
		public byte m_enable { get; set; }
		public const string m_enable_Name = "enable";
		public const string m_enable_Type = "byte";
		public byte m_isConduit { get; set; }
		public const string m_isConduit_Name = "isConduit";
		public const string m_isConduit_Type = "byte";
		public int m_interactionPort { get; set; }
		public const string m_interactionPort_Name = "interactionPort";
		public const string m_interactionPort_Type = "int";
		public hkbInteractionPayload m_interactionResponse { get; set; }
		public const string m_interactionResponse_Name = "interactionResponse";
		public const string m_interactionResponse_Type = "ref";
		public int m_interactionResponse_refId { get; set; }
		public const string m_interactionResponse_Class = "hkbInteractionPayload";
		public int m_interactionHandleIndex { get; set; }
		public const string m_interactionHandleIndex_Name = "interactionHandleIndex";
		public const string m_interactionHandleIndex_Type = "int";
		public byte m_conduitStatusDirty { get; set; }
		public const string m_conduitStatusDirty_Name = "conduitStatusDirty";
		public const string m_conduitStatusDirty_Type = "byte";

	}
}
