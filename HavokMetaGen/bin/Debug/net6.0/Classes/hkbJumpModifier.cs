using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbJumpModifier: hkbModifier
	{
		public const string version = "0";
		public float m_inAirDriftGain { get; set; }
		public const string m_inAirDriftGain_Name = "inAirDriftGain";
		public const string m_inAirDriftGain_Type = "real";
		public float m_inAirMoveGain { get; set; }
		public const string m_inAirMoveGain_Name = "inAirMoveGain";
		public const string m_inAirMoveGain_Type = "real";
		public float m_requestedHeight { get; set; }
		public const string m_requestedHeight_Name = "requestedHeight";
		public const string m_requestedHeight_Type = "real";
		public float m_jumpingGravity { get; set; }
		public const string m_jumpingGravity_Name = "jumpingGravity";
		public const string m_jumpingGravity_Type = "real";
		public float m_hangJumpGravity { get; set; }
		public const string m_hangJumpGravity_Name = "hangJumpGravity";
		public const string m_hangJumpGravity_Type = "real";
		public float m_fallingGravity { get; set; }
		public const string m_fallingGravity_Name = "fallingGravity";
		public const string m_fallingGravity_Type = "real";
		public float m_hangTime { get; set; }
		public const string m_hangTime_Name = "hangTime";
		public const string m_hangTime_Type = "real";
		public float m_inputSpeed { get; set; }
		public const string m_inputSpeed_Name = "inputSpeed";
		public const string m_inputSpeed_Type = "real";
		public List<float> m_inputDirection { get; set; }
		public const string m_inputDirection_Name = "inputDirection";
		public const string m_inputDirection_Type = "vec4";
		public byte m_useInitialVelocity { get; set; }
		public const string m_useInitialVelocity_Name = "useInitialVelocity";
		public const string m_useInitialVelocity_Type = "byte";
		public List<float> m_initialVelocity { get; set; }
		public const string m_initialVelocity_Name = "initialVelocity";
		public const string m_initialVelocity_Type = "vec4";
		public float m_startHeight { get; set; }
		public const string m_startHeight_Name = "startHeight";
		public const string m_startHeight_Type = "real";
		public float m_maxDesiredHeight { get; set; }
		public const string m_maxDesiredHeight_Name = "maxDesiredHeight";
		public const string m_maxDesiredHeight_Type = "real";
		public float m_maxAchievedHeight { get; set; }
		public const string m_maxAchievedHeight_Name = "maxAchievedHeight";
		public const string m_maxAchievedHeight_Type = "real";
		public float m_elapsedTime { get; set; }
		public const string m_elapsedTime_Name = "elapsedTime";
		public const string m_elapsedTime_Type = "real";
		public float m_hangTimeRemaining { get; set; }
		public const string m_hangTimeRemaining_Name = "hangTimeRemaining";
		public const string m_hangTimeRemaining_Type = "real";
		public List<float> m_initialMovementRequest { get; set; }
		public const string m_initialMovementRequest_Name = "initialMovementRequest";
		public const string m_initialMovementRequest_Type = "vec4";
		public List<float> m_currentVelocity { get; set; }
		public const string m_currentVelocity_Name = "currentVelocity";
		public const string m_currentVelocity_Type = "vec4";
		public float m_gain { get; set; }
		public const string m_gain_Name = "gain";
		public const string m_gain_Type = "real";
		public List<float> m_desiredVelocity { get; set; }
		public const string m_desiredVelocity_Name = "desiredVelocity";
		public const string m_desiredVelocity_Type = "vec4";
		public List<float> m_outputVelocity { get; set; }
		public const string m_outputVelocity_Name = "outputVelocity";
		public const string m_outputVelocity_Type = "vec4";
		public List<float> m_previousPosition { get; set; }
		public const string m_previousPosition_Name = "previousPosition";
		public const string m_previousPosition_Type = "vec4";
		public byte m_firstTime { get; set; }
		public const string m_firstTime_Name = "firstTime";
		public const string m_firstTime_Type = "byte";
		public float m_targetHeight { get; set; }
		public const string m_targetHeight_Name = "targetHeight";
		public const string m_targetHeight_Type = "real";
		public float m_lastTimeStep { get; set; }
		public const string m_lastTimeStep_Name = "lastTimeStep";
		public const string m_lastTimeStep_Type = "real";

	}
}
