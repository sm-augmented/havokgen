using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbFootIkControlsModifierLeg
	{
		public const string version = "0";
		public List<float> m_groundPosition { get; set; }
		public const string m_groundPosition_Name = "groundPosition";
		public const string m_groundPosition_Type = "vec4";
		public hkbEventProperty m_ungroundedEvent { get; set; }
		public const string m_ungroundedEvent_Name = "ungroundedEvent";
		public const string m_ungroundedEvent_Type = "struct";
		public const string m_ungroundedEvent_Class = "hkbEventProperty";
		public float m_verticalError { get; set; }
		public const string m_verticalError_Name = "verticalError";
		public const string m_verticalError_Type = "real";
		public byte m_hitSomething { get; set; }
		public const string m_hitSomething_Name = "hitSomething";
		public const string m_hitSomething_Type = "byte";
		public byte m_isPlantedMS { get; set; }
		public const string m_isPlantedMS_Name = "isPlantedMS";
		public const string m_isPlantedMS_Type = "byte";

	}
}
