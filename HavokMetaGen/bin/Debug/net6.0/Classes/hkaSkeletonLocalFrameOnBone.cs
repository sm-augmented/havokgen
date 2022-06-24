using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSkeletonLocalFrameOnBone
	{
		public const string version = "0";
		public hkLocalFrame m_localFrame { get; set; }
		public const string m_localFrame_Name = "localFrame";
		public const string m_localFrame_Type = "ref";
		public int m_localFrame_refId { get; set; }
		public const string m_localFrame_Class = "hkLocalFrame";
		public int m_boneIndex { get; set; }
		public const string m_boneIndex_Name = "boneIndex";
		public const string m_boneIndex_Type = "int";

	}
}
