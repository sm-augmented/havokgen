using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkCombinerTOCTOCEntry
	{
		public const string version = "0";
		public List<byte> m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "byte";
		public const string m_name_Array = "True";
		public List<byte> m_ext { get; set; }
		public const string m_ext_Name = "ext";
		public const string m_ext_Type = "byte";
		public const string m_ext_Array = "True";
		public int m_hash { get; set; }
		public const string m_hash_Name = "hash";
		public const string m_hash_Type = "int";
		public byte m_num { get; set; }
		public const string m_num_Name = "num";
		public const string m_num_Type = "byte";

	}
}
