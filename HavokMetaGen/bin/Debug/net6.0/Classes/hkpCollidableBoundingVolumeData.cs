using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpCollidableBoundingVolumeData
	{
		public const string version = "0";
		public List<int> m_min { get; set; }
		public const string m_min_Name = "min";
		public const string m_min_Type = "int";
		public const string m_min_Count = "3";
		public List<byte> m_expansionMin { get; set; }
		public const string m_expansionMin_Name = "expansionMin";
		public const string m_expansionMin_Type = "byte";
		public const string m_expansionMin_Count = "3";
		public byte m_expansionShift { get; set; }
		public const string m_expansionShift_Name = "expansionShift";
		public const string m_expansionShift_Type = "byte";
		public List<int> m_max { get; set; }
		public const string m_max_Name = "max";
		public const string m_max_Type = "int";
		public const string m_max_Count = "3";
		public List<byte> m_expansionMax { get; set; }
		public const string m_expansionMax_Name = "expansionMax";
		public const string m_expansionMax_Type = "byte";
		public const string m_expansionMax_Count = "3";
		public byte m_padding { get; set; }
		public const string m_padding_Name = "padding";
		public const string m_padding_Type = "byte";
		public int m_numChildShapeAabbs { get; set; }
		public const string m_numChildShapeAabbs_Name = "numChildShapeAabbs";
		public const string m_numChildShapeAabbs_Type = "int";
		public int m_capacityChildShapeAabbs { get; set; }
		public const string m_capacityChildShapeAabbs_Name = "capacityChildShapeAabbs";
		public const string m_capacityChildShapeAabbs_Type = "int";

	}
}
