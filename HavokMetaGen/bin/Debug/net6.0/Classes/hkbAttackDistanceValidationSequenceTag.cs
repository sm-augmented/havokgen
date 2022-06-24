using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbAttackDistanceValidationSequenceTag: hkbSequenceTag
	{
		public const string version = "0";
		public float m_validDistance { get; set; }
		public const string m_validDistance_Name = "validDistance";
		public const string m_validDistance_Type = "real";
		public byte m_isWithinValidDistance { get; set; }
		public const string m_isWithinValidDistance_Name = "isWithinValidDistance";
		public const string m_isWithinValidDistance_Type = "byte";
		public hkbEventProperty m_targetOutOfRangeEvent { get; set; }
		public const string m_targetOutOfRangeEvent_Name = "targetOutOfRangeEvent";
		public const string m_targetOutOfRangeEvent_Type = "struct";
		public const string m_targetOutOfRangeEvent_Class = "hkbEventProperty";
		public byte m_clearHandleWhenInvalid { get; set; }
		public const string m_clearHandleWhenInvalid_Name = "clearHandleWhenInvalid";
		public const string m_clearHandleWhenInvalid_Type = "byte";
		public hkbHandle m_targetHandle { get; set; }
		public const string m_targetHandle_Name = "targetHandle";
		public const string m_targetHandle_Type = "ref";
		public int m_targetHandle_refId { get; set; }
		public const string m_targetHandle_Class = "hkbHandle";
		public int m_lastPhase { get; set; }
		public const string m_lastPhase_Name = "lastPhase";
		public const string m_lastPhase_Type = "int";
		public List<float> m_cachedSelfPosition { get; set; }
		public const string m_cachedSelfPosition_Name = "cachedSelfPosition";
		public const string m_cachedSelfPosition_Type = "vec4";

	}
}
