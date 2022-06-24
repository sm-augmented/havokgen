using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBehaviorGraphData: hkReferencedObject
	{
		public const string version = "2";
		public List<float> m_attributeDefaults { get; set; }
		public const string m_attributeDefaults_Name = "attributeDefaults";
		public const string m_attributeDefaults_Type = "real";
		public const string m_attributeDefaults_Array = "True";
		public List<hkbVariableInfo> m_variableInfos { get; set; }
		public const string m_variableInfos_Name = "variableInfos";
		public const string m_variableInfos_Type = "struct";
		public const string m_variableInfos_Class = "hkbVariableInfo";
		public const string m_variableInfos_Array = "True";
		public List<hkbVariableInfo> m_characterPropertyInfos { get; set; }
		public const string m_characterPropertyInfos_Name = "characterPropertyInfos";
		public const string m_characterPropertyInfos_Type = "struct";
		public const string m_characterPropertyInfos_Class = "hkbVariableInfo";
		public const string m_characterPropertyInfos_Array = "True";
		public List<hkbEventInfo> m_eventInfos { get; set; }
		public const string m_eventInfos_Name = "eventInfos";
		public const string m_eventInfos_Type = "struct";
		public const string m_eventInfos_Class = "hkbEventInfo";
		public const string m_eventInfos_Array = "True";
		public List<hkbVariableValue> m_wordMinVariableValues { get; set; }
		public const string m_wordMinVariableValues_Name = "wordMinVariableValues";
		public const string m_wordMinVariableValues_Type = "struct";
		public const string m_wordMinVariableValues_Class = "hkbVariableValue";
		public const string m_wordMinVariableValues_Array = "True";
		public List<hkbVariableValue> m_wordMaxVariableValues { get; set; }
		public const string m_wordMaxVariableValues_Name = "wordMaxVariableValues";
		public const string m_wordMaxVariableValues_Type = "struct";
		public const string m_wordMaxVariableValues_Class = "hkbVariableValue";
		public const string m_wordMaxVariableValues_Array = "True";
		public hkbVariableValueSet m_variableInitialValues { get; set; }
		public const string m_variableInitialValues_Name = "variableInitialValues";
		public const string m_variableInitialValues_Type = "ref";
		public int m_variableInitialValues_refId { get; set; }
		public const string m_variableInitialValues_Class = "hkbVariableValueSet";
		public hkbBehaviorGraphStringData m_stringData { get; set; }
		public const string m_stringData_Name = "stringData";
		public const string m_stringData_Type = "ref";
		public int m_stringData_refId { get; set; }
		public const string m_stringData_Class = "hkbBehaviorGraphStringData";

	}
}
