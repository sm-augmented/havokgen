using System.Text;
using System.Xml.Serialization;

namespace HavokMetaGen
{
	[XmlRoot(ElementName = "member")]
	public class Member
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "array")]
		public bool Array { get; set; }

		[XmlAttribute(AttributeName = "class")]
		public string Class { get; set; }

		[XmlAttribute(AttributeName = "count")]
		public int Count { get; set; }
	}

	[XmlRoot(ElementName = "class")]
	public class Class
	{

		[XmlElement(ElementName = "member")]
		public List<Member> Member { get; set; }

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public int Version { get; set; }

		[XmlAttribute(AttributeName = "parent")]
		public string Parent { get; set; }

		public void Generate()
        {
			var sb = new StringBuilder($"using System.Collections.Generic; {Environment.NewLine}{Environment.NewLine}namespace Havok {Environment.NewLine}{{{Environment.NewLine}");
			var parent = string.IsNullOrEmpty(Parent) ? "" : $": {Parent}";
			sb.AppendLine($"\tpublic partial class {Name}{parent}{Environment.NewLine}\t{{");
			sb.AppendLine($"\t\tpublic const string version = \"{Version}\";");

			foreach (var member in Member)
            {
				var trueType = member.Type;
				if (trueType == "void")
					continue;

				var isArr = member.Array;
				var isVec = trueType.StartsWith("vec");
				var isRef = member.Class != null;
				var isTuple = member.Count > 0;

				if (trueType == "ref" && !isRef)
					continue;

				if (trueType == "real")
                {
					trueType = "float";
				}
				else if (isRef)
                {
					trueType = member.Class;
                }
				else if (isVec)
                {
					trueType = "List<float>";
                }

				if (isTuple || isArr)
                {
					trueType = $"List<{trueType}>";
                }

				sb.AppendLine($"\t\tpublic {trueType} m_{member.Name} " + "{ get; set; }");
				sb.AppendLine($"\t\tpublic const string m_{member.Name}_Name = \"{member.Name}\";");
				sb.AppendLine($"\t\tpublic const string m_{member.Name}_Type = \"{member.Type}\";");

				if (isRef)
				{
					if (member.Type != "struct")
                    {
						var miniType = "int";
						if (isTuple || isArr)
						{
							miniType = "List<int>";
						}
						sb.AppendLine($"\t\tpublic {miniType} m_{member.Name}_refId " + "{ get; set; }");
					}
					
					sb.AppendLine($"\t\tpublic const string m_{member.Name}_Class = \"{member.Class}\";");
                }

				if (isArr)
                {
					sb.AppendLine($"\t\tpublic const string m_{member.Name}_Array = \"{member.Array}\";");
                }

				if (isTuple)
                {
					sb.AppendLine($"\t\tpublic const string m_{member.Name}_Count = \"{member.Count}\";");
                }
			}

			sb.AppendLine($"{Environment.NewLine}\t" + "}" + $"{Environment.NewLine}" + "}");

			var curDir = Directory.GetCurrentDirectory();
			var path = Path.Combine(curDir, "Classes", Name) + ".cs";
			File.WriteAllText(path, sb.ToString());
        }
	}

	[XmlRoot(ElementName = "root")]
	public class Root
	{

		[XmlElement(ElementName = "class")]
		public List<Class> Class { get; set; }

		public void Generate()
        {
			foreach (var klass in Class)
            {
				klass.Generate();
            }
        }
	}
}
