using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkRootLevelContainerNamedVariant
	{
		public const string version = "0";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public string m_className { get; set; }
		public const string m_className_Name = "className";
		public const string m_className_Type = "string";
		public hkReferencedObject m_variant { get; set; }
		public const string m_variant_Name = "variant";
		public const string m_variant_Type = "ref";
		public int m_variant_refId { get; set; }
		public const string m_variant_Class = "hkReferencedObject";

	}
}
