using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkpSetupStabilizationAtom: hkpConstraintAtom
	{
		public const string version = "1";
		public byte m_enabled { get; set; }
		public const string m_enabled_Name = "enabled";
		public const string m_enabled_Type = "byte";
		public float m_maxAngle { get; set; }
		public const string m_maxAngle_Name = "maxAngle";
		public const string m_maxAngle_Type = "real";
		public List<byte> m_padding { get; set; }
		public const string m_padding_Name = "padding";
		public const string m_padding_Type = "byte";
		public const string m_padding_Count = "8";

	}
}
