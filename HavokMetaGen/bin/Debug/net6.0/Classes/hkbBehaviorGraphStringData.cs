using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBehaviorGraphStringData: hkReferencedObject
	{
		public const string version = "1";
		public List<string> m_eventNames { get; set; }
		public const string m_eventNames_Name = "eventNames";
		public const string m_eventNames_Type = "string";
		public const string m_eventNames_Array = "True";
		public List<string> m_attributeNames { get; set; }
		public const string m_attributeNames_Name = "attributeNames";
		public const string m_attributeNames_Type = "string";
		public const string m_attributeNames_Array = "True";
		public List<string> m_variableNames { get; set; }
		public const string m_variableNames_Name = "variableNames";
		public const string m_variableNames_Type = "string";
		public const string m_variableNames_Array = "True";
		public List<string> m_characterPropertyNames { get; set; }
		public const string m_characterPropertyNames_Name = "characterPropertyNames";
		public const string m_characterPropertyNames_Type = "string";
		public const string m_characterPropertyNames_Array = "True";

	}
}
