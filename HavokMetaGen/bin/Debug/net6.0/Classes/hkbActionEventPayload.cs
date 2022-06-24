using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbActionEventPayload: hkbEventPayload
	{
		public const string version = "0";
		public string m_actionName { get; set; }
		public const string m_actionName_Name = "actionName";
		public const string m_actionName_Type = "string";
		public string m_contextName { get; set; }
		public const string m_contextName_Name = "contextName";
		public const string m_contextName_Type = "string";

	}
}
