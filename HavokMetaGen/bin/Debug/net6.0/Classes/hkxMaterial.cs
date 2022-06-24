using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxMaterial: hkxAttributeHolder
	{
		public const string version = "1";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public List<hkxMaterialTextureStage> m_stages { get; set; }
		public const string m_stages_Name = "stages";
		public const string m_stages_Type = "struct";
		public const string m_stages_Class = "hkxMaterialTextureStage";
		public const string m_stages_Array = "True";
		public List<float> m_diffuseColor { get; set; }
		public const string m_diffuseColor_Name = "diffuseColor";
		public const string m_diffuseColor_Type = "vec4";
		public List<float> m_ambientColor { get; set; }
		public const string m_ambientColor_Name = "ambientColor";
		public const string m_ambientColor_Type = "vec4";
		public List<float> m_specularColor { get; set; }
		public const string m_specularColor_Name = "specularColor";
		public const string m_specularColor_Type = "vec4";
		public List<float> m_emissiveColor { get; set; }
		public const string m_emissiveColor_Name = "emissiveColor";
		public const string m_emissiveColor_Type = "vec4";
		public List<hkxMaterial> m_subMaterials { get; set; }
		public const string m_subMaterials_Name = "subMaterials";
		public const string m_subMaterials_Type = "ref";
		public List<int> m_subMaterials_refId { get; set; }
		public const string m_subMaterials_Class = "hkxMaterial";
		public const string m_subMaterials_Array = "True";
		public hkReferencedObject m_extraData { get; set; }
		public const string m_extraData_Name = "extraData";
		public const string m_extraData_Type = "ref";
		public int m_extraData_refId { get; set; }
		public const string m_extraData_Class = "hkReferencedObject";
		public List<hkxMaterialProperty> m_properties { get; set; }
		public const string m_properties_Name = "properties";
		public const string m_properties_Type = "struct";
		public const string m_properties_Class = "hkxMaterialProperty";
		public const string m_properties_Array = "True";

	}
}
