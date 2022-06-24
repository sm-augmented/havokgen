using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyTargetableModeData: hkbEntityPropertyControlData
	{
		public const string version = "0";
		public int m_targetableMode { get; set; }
		public const string m_targetableMode_Name = "targetableMode";
		public const string m_targetableMode_Type = "int";

	}
}
