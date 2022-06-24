using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConstraintInstance: hkReferencedObject
	{
		public const string version = "1";
		public hkpConstraintData m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "ref";
		public int m_data_refId { get; set; }
		public const string m_data_Class = "hkpConstraintData";
		public hkpModifierConstraintAtom m_constraintModifiers { get; set; }
		public const string m_constraintModifiers_Name = "constraintModifiers";
		public const string m_constraintModifiers_Type = "ref";
		public int m_constraintModifiers_refId { get; set; }
		public const string m_constraintModifiers_Class = "hkpModifierConstraintAtom";
		public List<hkpEntity> m_entities { get; set; }
		public const string m_entities_Name = "entities";
		public const string m_entities_Type = "ref";
		public List<int> m_entities_refId { get; set; }
		public const string m_entities_Class = "hkpEntity";
		public const string m_entities_Count = "2";
		public byte m_priority { get; set; }
		public const string m_priority_Name = "priority";
		public const string m_priority_Type = "byte";
		public byte m_wantRuntime { get; set; }
		public const string m_wantRuntime_Name = "wantRuntime";
		public const string m_wantRuntime_Type = "byte";
		public byte m_destructionRemapInfo { get; set; }
		public const string m_destructionRemapInfo_Name = "destructionRemapInfo";
		public const string m_destructionRemapInfo_Type = "byte";
		public hkpConstraintInstanceSmallArraySerializeOverrideType m_listeners { get; set; }
		public const string m_listeners_Name = "listeners";
		public const string m_listeners_Type = "struct";
		public const string m_listeners_Class = "hkpConstraintInstanceSmallArraySerializeOverrideType";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public int m_userData { get; set; }
		public const string m_userData_Name = "userData";
		public const string m_userData_Type = "int";
		public int m_uid { get; set; }
		public const string m_uid_Name = "uid";
		public const string m_uid_Type = "int";

	}
}
