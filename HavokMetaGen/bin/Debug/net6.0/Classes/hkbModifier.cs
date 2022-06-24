using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbModifier: hkbNode
	{
		public const string version = "0";
		public byte m_enable { get; set; }
		public const string m_enable_Name = "enable";
		public const string m_enable_Type = "byte";
		public List<byte> m_padModifier { get; set; }
		public const string m_padModifier_Name = "padModifier";
		public const string m_padModifier_Type = "byte";
		public const string m_padModifier_Count = "3";

	}
}
