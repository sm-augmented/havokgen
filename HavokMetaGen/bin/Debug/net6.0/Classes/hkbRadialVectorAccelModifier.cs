using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbRadialVectorAccelModifier: hkbModifier
	{
		public const string version = "0";
		public List<float> m_referenceVector { get; set; }
		public const string m_referenceVector_Name = "referenceVector";
		public const string m_referenceVector_Type = "vec4";
		public List<float> m_targetVector { get; set; }
		public const string m_targetVector_Name = "targetVector";
		public const string m_targetVector_Type = "vec4";
		public float m_inputSpeed { get; set; }
		public const string m_inputSpeed_Name = "inputSpeed";
		public const string m_inputSpeed_Type = "real";
		public byte m_normalizeTargetVector { get; set; }
		public const string m_normalizeTargetVector_Name = "normalizeTargetVector";
		public const string m_normalizeTargetVector_Type = "byte";
		public float m_outputAngle { get; set; }
		public const string m_outputAngle_Name = "outputAngle";
		public const string m_outputAngle_Type = "real";
		public float m_outputSpeed { get; set; }
		public const string m_outputSpeed_Name = "outputSpeed";
		public const string m_outputSpeed_Type = "real";
		public float m_maxChange { get; set; }
		public const string m_maxChange_Name = "maxChange";
		public const string m_maxChange_Type = "real";
		public float m_angleThreshold { get; set; }
		public const string m_angleThreshold_Name = "angleThreshold";
		public const string m_angleThreshold_Type = "real";
		public List<float> m_lastFrameVector { get; set; }
		public const string m_lastFrameVector_Name = "lastFrameVector";
		public const string m_lastFrameVector_Type = "vec4";
		public float m_lastFrameAngle { get; set; }
		public const string m_lastFrameAngle_Name = "lastFrameAngle";
		public const string m_lastFrameAngle_Type = "real";
		public float m_lastTimeStep { get; set; }
		public const string m_lastTimeStep_Name = "lastTimeStep";
		public const string m_lastTimeStep_Type = "real";

	}
}
