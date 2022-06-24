using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxMesh: hkReferencedObject
	{
		public const string version = "1";
		public List<hkxMeshSection> m_sections { get; set; }
		public const string m_sections_Name = "sections";
		public const string m_sections_Type = "ref";
		public List<int> m_sections_refId { get; set; }
		public const string m_sections_Class = "hkxMeshSection";
		public const string m_sections_Array = "True";
		public List<hkxMeshUserChannelInfo> m_userChannelInfos { get; set; }
		public const string m_userChannelInfos_Name = "userChannelInfos";
		public const string m_userChannelInfos_Type = "ref";
		public List<int> m_userChannelInfos_refId { get; set; }
		public const string m_userChannelInfos_Class = "hkxMeshUserChannelInfo";
		public const string m_userChannelInfos_Array = "True";

	}
}
