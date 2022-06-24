using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxAttributeHolder: hkReferencedObject
	{
		public const string version = "1";
		public List<hkxAttributeGroup> m_attributeGroups { get; set; }
		public const string m_attributeGroups_Name = "attributeGroups";
		public const string m_attributeGroups_Type = "ref";
		public List<int> m_attributeGroups_refId { get; set; }
		public const string m_attributeGroups_Class = "hkxAttributeGroup";
		public const string m_attributeGroups_Array = "True";

	}
}
