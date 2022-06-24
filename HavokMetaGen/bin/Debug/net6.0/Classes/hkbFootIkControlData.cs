using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkControlData
	{
		public const string version = "0";
		public hkbFootIkGains m_gains { get; set; }
		public const string m_gains_Name = "gains";
		public const string m_gains_Type = "struct";
		public const string m_gains_Class = "hkbFootIkGains";

	}
}
