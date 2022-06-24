using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkaSplineCompressedAnimation: hkaAnimation
	{
		public const string version = "0";
		public int m_numFrames { get; set; }
		public const string m_numFrames_Name = "numFrames";
		public const string m_numFrames_Type = "int";
		public int m_numBlocks { get; set; }
		public const string m_numBlocks_Name = "numBlocks";
		public const string m_numBlocks_Type = "int";
		public int m_maxFramesPerBlock { get; set; }
		public const string m_maxFramesPerBlock_Name = "maxFramesPerBlock";
		public const string m_maxFramesPerBlock_Type = "int";
		public int m_maskAndQuantizationSize { get; set; }
		public const string m_maskAndQuantizationSize_Name = "maskAndQuantizationSize";
		public const string m_maskAndQuantizationSize_Type = "int";
		public float m_blockDuration { get; set; }
		public const string m_blockDuration_Name = "blockDuration";
		public const string m_blockDuration_Type = "real";
		public float m_blockInverseDuration { get; set; }
		public const string m_blockInverseDuration_Name = "blockInverseDuration";
		public const string m_blockInverseDuration_Type = "real";
		public float m_frameDuration { get; set; }
		public const string m_frameDuration_Name = "frameDuration";
		public const string m_frameDuration_Type = "real";
		public List<int> m_blockOffsets { get; set; }
		public const string m_blockOffsets_Name = "blockOffsets";
		public const string m_blockOffsets_Type = "int";
		public const string m_blockOffsets_Array = "True";
		public List<int> m_floatBlockOffsets { get; set; }
		public const string m_floatBlockOffsets_Name = "floatBlockOffsets";
		public const string m_floatBlockOffsets_Type = "int";
		public const string m_floatBlockOffsets_Array = "True";
		public List<int> m_transformOffsets { get; set; }
		public const string m_transformOffsets_Name = "transformOffsets";
		public const string m_transformOffsets_Type = "int";
		public const string m_transformOffsets_Array = "True";
		public List<int> m_floatOffsets { get; set; }
		public const string m_floatOffsets_Name = "floatOffsets";
		public const string m_floatOffsets_Type = "int";
		public const string m_floatOffsets_Array = "True";
		public List<byte> m_data { get; set; }
		public const string m_data_Name = "data";
		public const string m_data_Type = "byte";
		public const string m_data_Array = "True";
		public int m_endian { get; set; }
		public const string m_endian_Name = "endian";
		public const string m_endian_Type = "int";

	}
}
