using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpConvexTransformShapeBase: hkpConvexShape
	{
		public const string version = "0";
		public hkpSingleShapeContainer m_childShape { get; set; }
		public const string m_childShape_Name = "childShape";
		public const string m_childShape_Type = "struct";
		public const string m_childShape_Class = "hkpSingleShapeContainer";
		public int m_childShapeSize { get; set; }
		public const string m_childShapeSize_Name = "childShapeSize";
		public const string m_childShapeSize_Type = "int";

	}
}
