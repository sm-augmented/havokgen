using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpWorldObject: hkReferencedObject
	{
		public const string version = "0";
		public int m_userData { get; set; }
		public const string m_userData_Name = "userData";
		public const string m_userData_Type = "int";
		public hkpLinkedCollidable m_collidable { get; set; }
		public const string m_collidable_Name = "collidable";
		public const string m_collidable_Type = "struct";
		public const string m_collidable_Class = "hkpLinkedCollidable";
		public hkMultiThreadCheck m_multiThreadCheck { get; set; }
		public const string m_multiThreadCheck_Name = "multiThreadCheck";
		public const string m_multiThreadCheck_Type = "struct";
		public const string m_multiThreadCheck_Class = "hkMultiThreadCheck";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public List<hkpProperty> m_properties { get; set; }
		public const string m_properties_Name = "properties";
		public const string m_properties_Type = "struct";
		public const string m_properties_Class = "hkpProperty";
		public const string m_properties_Array = "True";

	}
}
