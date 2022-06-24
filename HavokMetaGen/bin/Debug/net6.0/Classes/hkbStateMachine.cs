using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStateMachine: hkbGenerator
	{
		public const string version = "4";
		public hkbEvent m_eventToSendWhenStateOrTransitionChanges { get; set; }
		public const string m_eventToSendWhenStateOrTransitionChanges_Name = "eventToSendWhenStateOrTransitionChanges";
		public const string m_eventToSendWhenStateOrTransitionChanges_Type = "struct";
		public const string m_eventToSendWhenStateOrTransitionChanges_Class = "hkbEvent";
		public hkbStateChooser m_startStateChooser { get; set; }
		public const string m_startStateChooser_Name = "startStateChooser";
		public const string m_startStateChooser_Type = "ref";
		public int m_startStateChooser_refId { get; set; }
		public const string m_startStateChooser_Class = "hkbStateChooser";
		public int m_startStateId { get; set; }
		public const string m_startStateId_Name = "startStateId";
		public const string m_startStateId_Type = "int";
		public int m_returnToPreviousStateEventId { get; set; }
		public const string m_returnToPreviousStateEventId_Name = "returnToPreviousStateEventId";
		public const string m_returnToPreviousStateEventId_Type = "int";
		public int m_randomTransitionEventId { get; set; }
		public const string m_randomTransitionEventId_Name = "randomTransitionEventId";
		public const string m_randomTransitionEventId_Type = "int";
		public int m_transitionToNextHigherStateEventId { get; set; }
		public const string m_transitionToNextHigherStateEventId_Name = "transitionToNextHigherStateEventId";
		public const string m_transitionToNextHigherStateEventId_Type = "int";
		public int m_transitionToNextLowerStateEventId { get; set; }
		public const string m_transitionToNextLowerStateEventId_Name = "transitionToNextLowerStateEventId";
		public const string m_transitionToNextLowerStateEventId_Type = "int";
		public int m_syncVariableIndex { get; set; }
		public const string m_syncVariableIndex_Name = "syncVariableIndex";
		public const string m_syncVariableIndex_Type = "int";
		public int m_currentStateId { get; set; }
		public const string m_currentStateId_Name = "currentStateId";
		public const string m_currentStateId_Type = "int";
		public byte m_wrapAroundStateId { get; set; }
		public const string m_wrapAroundStateId_Name = "wrapAroundStateId";
		public const string m_wrapAroundStateId_Type = "byte";
		public int m_maxSimultaneousTransitions { get; set; }
		public const string m_maxSimultaneousTransitions_Name = "maxSimultaneousTransitions";
		public const string m_maxSimultaneousTransitions_Type = "int";
		public int m_startStateMode { get; set; }
		public const string m_startStateMode_Name = "startStateMode";
		public const string m_startStateMode_Type = "int";
		public int m_selfTransitionMode { get; set; }
		public const string m_selfTransitionMode_Name = "selfTransitionMode";
		public const string m_selfTransitionMode_Type = "int";
		public byte m_isActive { get; set; }
		public const string m_isActive_Name = "isActive";
		public const string m_isActive_Type = "byte";
		public List<hkbStateMachineStateInfo> m_states { get; set; }
		public const string m_states_Name = "states";
		public const string m_states_Type = "ref";
		public List<int> m_states_refId { get; set; }
		public const string m_states_Class = "hkbStateMachineStateInfo";
		public const string m_states_Array = "True";
		public hkbStateMachineTransitionInfoArray m_wildcardTransitions { get; set; }
		public const string m_wildcardTransitions_Name = "wildcardTransitions";
		public const string m_wildcardTransitions_Type = "ref";
		public int m_wildcardTransitions_refId { get; set; }
		public const string m_wildcardTransitions_Class = "hkbStateMachineTransitionInfoArray";
		public float m_timeInState { get; set; }
		public const string m_timeInState_Name = "timeInState";
		public const string m_timeInState_Type = "real";
		public float m_lastLocalTime { get; set; }
		public const string m_lastLocalTime_Name = "lastLocalTime";
		public const string m_lastLocalTime_Type = "real";
		public int m_previousStateId { get; set; }
		public const string m_previousStateId_Name = "previousStateId";
		public const string m_previousStateId_Type = "int";
		public int m_nextStartStateIndexOverride { get; set; }
		public const string m_nextStartStateIndexOverride_Name = "nextStartStateIndexOverride";
		public const string m_nextStartStateIndexOverride_Type = "int";
		public byte m_stateOrTransitionChanged { get; set; }
		public const string m_stateOrTransitionChanged_Name = "stateOrTransitionChanged";
		public const string m_stateOrTransitionChanged_Type = "byte";
		public byte m_echoNextUpdate { get; set; }
		public const string m_echoNextUpdate_Name = "echoNextUpdate";
		public const string m_echoNextUpdate_Type = "byte";
		public int m_echoStartStateId { get; set; }
		public const string m_echoStartStateId_Name = "echoStartStateId";
		public const string m_echoStartStateId_Type = "int";

	}
}
