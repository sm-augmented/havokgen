using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbNode: hkbBindable
	{
		public const string version = "1";
		public int m_userData { get; set; }
		public const string m_userData_Name = "userData";
		public const string m_userData_Type = "int";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public int m_id { get; set; }
		public const string m_id_Name = "id";
		public const string m_id_Type = "int";
		public int m_cloneState { get; set; }
		public const string m_cloneState_Name = "cloneState";
		public const string m_cloneState_Type = "int";
		public List<byte> m_padNode { get; set; }
		public const string m_padNode_Name = "padNode";
		public const string m_padNode_Type = "byte";
		public const string m_padNode_Count = "1";

	}
}
