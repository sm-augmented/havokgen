using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkxMeshUserChannelInfo: hkxAttributeHolder
	{
		public const string version = "0";
		public string m_name { get; set; }
		public const string m_name_Name = "name";
		public const string m_name_Type = "string";
		public string m_className { get; set; }
		public const string m_className_Name = "className";
		public const string m_className_Type = "string";

	}
}
