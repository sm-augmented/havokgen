using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaBoneAttachment: hkReferencedObject
	{
		public const string version = "1";
		public string m_originalSkeletonName { get; set; }
		public const string m_originalSkeletonName_Name = "originalSkeletonName";
		public const string m_originalSkeletonName_Type = "string";
		public List<float> m_boneFromAttachment { get; set; }
		public const string m_boneFromAttachment_Name = "boneFromAttachment";
		public const string m_boneFromAttachment_Type = "vec16";
		public hkReferencedObject m_attachment { get; set; }
		public const string m_attachment_Name = "attachment";
		public const string m_attachment_Type = "ref";
		public int m_attachment_refId { get; set; }
		public const string m_attachment_Class = "hkReferencedObject";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public int m_boneIndex { get; set; }
		public const string m_boneIndex_Name = "boneIndex";
		public const string m_boneIndex_Type = "int";

	}
}
