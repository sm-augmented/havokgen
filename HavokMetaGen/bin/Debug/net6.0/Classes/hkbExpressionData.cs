using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbExpressionData
	{
		public const string version = "0";
		public string m_expression { get; set; }
		public const string m_expression_Name = "expression";
		public const string m_expression_Type = "string";
		public int m_assignmentVariableIndex { get; set; }
		public const string m_assignmentVariableIndex_Name = "assignmentVariableIndex";
		public const string m_assignmentVariableIndex_Type = "int";
		public int m_assignmentEventIndex { get; set; }
		public const string m_assignmentEventIndex_Name = "assignmentEventIndex";
		public const string m_assignmentEventIndex_Type = "int";
		public int m_eventMode { get; set; }
		public const string m_eventMode_Name = "eventMode";
		public const string m_eventMode_Type = "int";
		public byte m_raisedEvent { get; set; }
		public const string m_raisedEvent_Name = "raisedEvent";
		public const string m_raisedEvent_Type = "byte";
		public byte m_wasTrueInPreviousFrame { get; set; }
		public const string m_wasTrueInPreviousFrame_Name = "wasTrueInPreviousFrame";
		public const string m_wasTrueInPreviousFrame_Type = "byte";

	}
}
