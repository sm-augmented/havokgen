using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbInteractionRequestPayload: hkbInteractionPayload
	{
		public const string version = "0";
		public int m_interactionPort { get; set; }
		public const string m_interactionPort_Name = "interactionPort";
		public const string m_interactionPort_Type = "int";
		public byte m_matchPhase { get; set; }
		public const string m_matchPhase_Name = "matchPhase";
		public const string m_matchPhase_Type = "byte";
		public string m_interactionString { get; set; }
		public const string m_interactionString_Name = "interactionString";
		public const string m_interactionString_Type = "string";

	}
}
