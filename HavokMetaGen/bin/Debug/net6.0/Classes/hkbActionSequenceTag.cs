using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbActionSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public string m_actionName { get; set; }
		public const string m_actionName_Name = "actionName";
		public const string m_actionName_Type = "string";
		public string m_contextName { get; set; }
		public const string m_contextName_Name = "contextName";
		public const string m_contextName_Type = "string";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";

	}
}
