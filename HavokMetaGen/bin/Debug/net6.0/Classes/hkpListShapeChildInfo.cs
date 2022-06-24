using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpListShapeChildInfo
	{
		public const string version = "0";
		public hkpShape m_shape { get; set; }
		public const string m_shape_Name = "shape";
		public const string m_shape_Type = "ref";
		public int m_shape_refId { get; set; }
		public const string m_shape_Class = "hkpShape";
		public int m_collisionFilterInfo { get; set; }
		public const string m_collisionFilterInfo_Name = "collisionFilterInfo";
		public const string m_collisionFilterInfo_Type = "int";
		public int m_shapeSize { get; set; }
		public const string m_shapeSize_Name = "shapeSize";
		public const string m_shapeSize_Type = "int";
		public int m_numChildShapes { get; set; }
		public const string m_numChildShapes_Name = "numChildShapes";
		public const string m_numChildShapes_Type = "int";

	}
}
