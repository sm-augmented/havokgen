using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpMoppBvTreeShape: hkMoppBvTreeShapeBase
	{
		public const string version = "0";
		public hkpSingleShapeContainer m_child { get; set; }
		public const string m_child_Name = "child";
		public const string m_child_Type = "struct";
		public const string m_child_Class = "hkpSingleShapeContainer";
		public int m_childSize { get; set; }
		public const string m_childSize_Name = "childSize";
		public const string m_childSize_Type = "int";

	}
}
