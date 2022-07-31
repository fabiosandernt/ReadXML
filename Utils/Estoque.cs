using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ReadXML.Utils
{
    [Serializable, XmlRoot("estoque")]
    public class Estoque
    {
        [XmlElement("veiculo")]
        public Veiculo[] Veiculos { get; set; }
    }
}