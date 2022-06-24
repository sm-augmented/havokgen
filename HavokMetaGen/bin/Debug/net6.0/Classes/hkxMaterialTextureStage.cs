using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxMaterialTextureStage
	{
		public const string version = "0";
		public hkReferencedObject m_texture { get; set; }
		public const string m_texture_Name = "texture";
		public const string m_texture_Type = "ref";
		public int m_texture_refId { get; set; }
		public const string m_texture_Class = "hkReferencedObject";
		public int m_usageHint { get; set; }
		public const string m_usageHint_Name = "usageHint";
		public const string m_usageHint_Type = "int";
		public int m_tcoordChannel { get; set; }
		public const string m_tcoordChannel_Name = "tcoordChannel";
		public const string m_tcoordChannel_Type = "int";

	}
}
