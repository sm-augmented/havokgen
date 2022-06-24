using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbEntityPropertyCharacterPhysicsOverride: hkbEntityPropertyControlData
	{
		public const string version = "0";
		public byte m_applyLinearAccelerationAndLimits { get; set; }
		public const string m_applyLinearAccelerationAndLimits_Name = "applyLinearAccelerationAndLimits";
		public const string m_applyLinearAccelerationAndLimits_Type = "byte";
		public byte m_applyGravity { get; set; }
		public const string m_applyGravity_Name = "applyGravity";
		public const string m_applyGravity_Type = "byte";
		public byte m_restrictMovementToSurface { get; set; }
		public const string m_restrictMovementToSurface_Name = "restrictMovementToSurface";
		public const string m_restrictMovementToSurface_Type = "byte";

	}
}
