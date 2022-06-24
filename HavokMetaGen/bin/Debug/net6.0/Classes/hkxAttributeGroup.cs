using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxAttributeGroup
	{
		public const string version = "0";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public List<hkxAttribute> m_attributes { get; set; }
		public const string m_attributes_Name = "attributes";
		public const string m_attributes_Type = "struct";
		public const string m_attributes_Class = "hkxAttribute";
		public const string m_attributes_Array = "True";

	}
}
