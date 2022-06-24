using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbBlenderGenerator: hkbGenerator
	{
		public const string version = "2";
		public float m_referencePoseWeightThreshold { get; set; }
		public const string m_referencePoseWeightThreshold_Name = "referencePoseWeightThreshold";
		public const string m_referencePoseWeightThreshold_Type = "real";
		public float m_blendParameter { get; set; }
		public const string m_blendParameter_Name = "blendParameter";
		public const string m_blendParameter_Type = "real";
		public float m_minCyclicBlendParameter { get; set; }
		public const string m_minCyclicBlendParameter_Name = "minCyclicBlendParameter";
		public const string m_minCyclicBlendParameter_Type = "real";
		public float m_maxCyclicBlendParameter { get; set; }
		public const string m_maxCyclicBlendParameter_Name = "maxCyclicBlendParameter";
		public const string m_maxCyclicBlendParameter_Type = "real";
		public int m_indexOfSyncMasterChild { get; set; }
		public const string m_indexOfSyncMasterChild_Name = "indexOfSyncMasterChild";
		public const string m_indexOfSyncMasterChild_Type = "int";
		public int m_flags { get; set; }
		public const string m_flags_Name = "flags";
		public const string m_flags_Type = "int";
		public byte m_subtractLastChild { get; set; }
		public const string m_subtractLastChild_Name = "subtractLastChild";
		public const string m_subtractLastChild_Type = "byte";
		public List<hkbBlenderGeneratorChild> m_children { get; set; }
		public const string m_children_Name = "children";
		public const string m_children_Type = "ref";
		public List<int> m_children_refId { get; set; }
		public const string m_children_Class = "hkbBlenderGeneratorChild";
		public const string m_children_Array = "True";
		public int m_tagTrackIndex { get; set; }
		public const string m_tagTrackIndex_Name = "tagTrackIndex";
		public const string m_tagTrackIndex_Type = "int";
		public float m_endIntervalWeight { get; set; }
		public const string m_endIntervalWeight_Name = "endIntervalWeight";
		public const string m_endIntervalWeight_Type = "real";
		public int m_numActiveChildren { get; set; }
		public const string m_numActiveChildren_Name = "numActiveChildren";
		public const string m_numActiveChildren_Type = "int";
		public int m_beginIntervalIndex { get; set; }
		public const string m_beginIntervalIndex_Name = "beginIntervalIndex";
		public const string m_beginIntervalIndex_Type = "int";
		public int m_endIntervalIndex { get; set; }
		public const string m_endIntervalIndex_Name = "endIntervalIndex";
		public const string m_endIntervalIndex_Type = "int";
		public byte m_initSync { get; set; }
		public const string m_initSync_Name = "initSync";
		public const string m_initSync_Type = "byte";
		public byte m_doSubtractiveBlend { get; set; }
		public const string m_doSubtractiveBlend_Name = "doSubtractiveBlend";
		public const string m_doSubtractiveBlend_Type = "byte";

	}
}
