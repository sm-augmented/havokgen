using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpCdBody
	{
		public const string version = "1";
		public hkpShape m_shape { get; set; }
		public const string m_shape_Name = "shape";
		public const string m_shape_Type = "ref";
		public int m_shape_refId { get; set; }
		public const string m_shape_Class = "hkpShape";
		public int m_shapeKey { get; set; }
		public const string m_shapeKey_Name = "shapeKey";
		public const string m_shapeKey_Type = "int";
		public hkpCdBody m_parent { get; set; }
		public const string m_parent_Name = "parent";
		public const string m_parent_Type = "ref";
		public int m_parent_refId { get; set; }
		public const string m_parent_Class = "hkpCdBody";

	}
}
