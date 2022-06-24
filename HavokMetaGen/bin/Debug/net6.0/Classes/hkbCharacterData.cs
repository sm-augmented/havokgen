using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbCharacterData: hkReferencedObject
	{
		public const string version = "7";
		public hkbCharacterDataCharacterControllerInfo m_characterControllerInfo { get; set; }
		public const string m_characterControllerInfo_Name = "characterControllerInfo";
		public const string m_characterControllerInfo_Type = "struct";
		public const string m_characterControllerInfo_Class = "hkbCharacterDataCharacterControllerInfo";
		public List<float> m_modelUpMS { get; set; }
		public const string m_modelUpMS_Name = "modelUpMS";
		public const string m_modelUpMS_Type = "vec4";
		public List<float> m_modelForwardMS { get; set; }
		public const string m_modelForwardMS_Name = "modelForwardMS";
		public const string m_modelForwardMS_Type = "vec4";
		public List<float> m_modelRightMS { get; set; }
		public const string m_modelRightMS_Name = "modelRightMS";
		public const string m_modelRightMS_Type = "vec4";
		public List<hkbVariableInfo> m_characterPropertyInfos { get; set; }
		public const string m_characterPropertyInfos_Name = "characterPropertyInfos";
		public const string m_characterPropertyInfos_Type = "struct";
		public const string m_characterPropertyInfos_Class = "hkbVariableInfo";
		public const string m_characterPropertyInfos_Array = "True";
		public List<int> m_numBonesPerLod { get; set; }
		public const string m_numBonesPerLod_Name = "numBonesPerLod";
		public const string m_numBonesPerLod_Type = "int";
		public const string m_numBonesPerLod_Array = "True";
		public hkbVariableValueSet m_characterPropertyValues { get; set; }
		public const string m_characterPropertyValues_Name = "characterPropertyValues";
		public const string m_characterPropertyValues_Type = "ref";
		public int m_characterPropertyValues_refId { get; set; }
		public const string m_characterPropertyValues_Class = "hkbVariableValueSet";
		public hkbFootIkDriverInfo m_footIkDriverInfo { get; set; }
		public const string m_footIkDriverInfo_Name = "footIkDriverInfo";
		public const string m_footIkDriverInfo_Type = "ref";
		public int m_footIkDriverInfo_refId { get; set; }
		public const string m_footIkDriverInfo_Class = "hkbFootIkDriverInfo";
		public hkbHandIkDriverInfo m_handIkDriverInfo { get; set; }
		public const string m_handIkDriverInfo_Name = "handIkDriverInfo";
		public const string m_handIkDriverInfo_Type = "ref";
		public int m_handIkDriverInfo_refId { get; set; }
		public const string m_handIkDriverInfo_Class = "hkbHandIkDriverInfo";
		public hkbCharacterStringData m_stringData { get; set; }
		public const string m_stringData_Name = "stringData";
		public const string m_stringData_Type = "ref";
		public int m_stringData_refId { get; set; }
		public const string m_stringData_Class = "hkbCharacterStringData";
		public hkbMirroredSkeletonInfo m_mirroredSkeletonInfo { get; set; }
		public const string m_mirroredSkeletonInfo_Name = "mirroredSkeletonInfo";
		public const string m_mirroredSkeletonInfo_Type = "ref";
		public int m_mirroredSkeletonInfo_refId { get; set; }
		public const string m_mirroredSkeletonInfo_Class = "hkbMirroredSkeletonInfo";
		public float m_scale { get; set; }
		public const string m_scale_Name = "scale";
		public const string m_scale_Type = "real";
		public int m_numHands { get; set; }
		public const string m_numHands_Name = "numHands";
		public const string m_numHands_Type = "int";
		public int m_numFloatSlots { get; set; }
		public const string m_numFloatSlots_Name = "numFloatSlots";
		public const string m_numFloatSlots_Type = "int";

	}
}
