using System.Collections.Generic; 

namespace Havok 
{
	public partial class hkbProjectStringData: hkReferencedObject
	{
		public const string version = "1";
		public List<string> m_animationFilenames { get; set; }
		public const string m_animationFilenames_Name = "animationFilenames";
		public const string m_animationFilenames_Type = "string";
		public const string m_animationFilenames_Array = "True";
		public List<string> m_behaviorFilenames { get; set; }
		public const string m_behaviorFilenames_Name = "behaviorFilenames";
		public const string m_behaviorFilenames_Type = "string";
		public const string m_behaviorFilenames_Array = "True";
		public List<string> m_characterFilenames { get; set; }
		public const string m_characterFilenames_Name = "characterFilenames";
		public const string m_characterFilenames_Type = "string";
		public const string m_characterFilenames_Array = "True";
		public List<string> m_eventNames { get; set; }
		public const string m_eventNames_Name = "eventNames";
		public const string m_eventNames_Type = "string";
		public const string m_eventNames_Array = "True";
		public string m_animationPath { get; set; }
		public const string m_animationPath_Name = "animationPath";
		public const string m_animationPath_Type = "string";
		public string m_behaviorPath { get; set; }
		public const string m_behaviorPath_Name = "behaviorPath";
		public const string m_behaviorPath_Type = "string";
		public string m_characterPath { get; set; }
		public const string m_characterPath_Name = "characterPath";
		public const string m_characterPath_Type = "string";
		public string m_fullPathToSource { get; set; }
		public const string m_fullPathToSource_Name = "fullPathToSource";
		public const string m_fullPathToSource_Type = "string";
		public string m_rootPath { get; set; }
		public const string m_rootPath_Name = "rootPath";
		public const string m_rootPath_Type = "string";

	}
}
