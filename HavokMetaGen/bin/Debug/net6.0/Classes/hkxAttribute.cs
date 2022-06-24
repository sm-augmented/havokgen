using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxAttribute
	{
		public const string version = "0";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public hkReferencedObject m_value { get; set; }
		public const string m_value_Name = "value";
		public const string m_value_Type = "ref";
		public int m_value_refId { get; set; }
		public const string m_value_Class = "hkReferencedObject";

	}
}
