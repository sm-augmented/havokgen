using HavokMetaGen;
using System.Xml.Serialization;

XmlSerializer serializer = new XmlSerializer(typeof(Root));
using (var reader = new StreamReader("metadata.xml"))
{
    var metadata = (Root)serializer.Deserialize(reader);
    metadata.Generate();
}