using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpProperty
	{
		public const string version = "0";
		public int m_key { get; set; }
		public const string m_key_Name = "key";
		public const string m_key_Type = "int";
		public int m_alignmentPadding { get; set; }
		public const string m_alignmentPadding_Name = "alignmentPadding";
		public const string m_alignmentPadding_Type = "int";
		public hkpPropertyValue m_value { get; set; }
		public const string m_value_Name = "value";
		public const string m_value_Type = "struct";
		public const string m_value_Class = "hkpPropertyValue";

	}
}
