using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbStruggleControlsModifier: hkbModifier
	{
		public const string version = "1";
		public string m_struggleType { get; set; }
		public const string m_struggleType_Name = "struggleType";
		public const string m_struggleType_Type = "string";
		public int m_targetHandleIndex { get; set; }
		public const string m_targetHandleIndex_Name = "targetHandleIndex";
		public const string m_targetHandleIndex_Type = "int";

	}
}
