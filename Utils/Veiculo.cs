using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ReadXML.Utils
{
    public class Veiculo
    {
        [XmlElement("idveiculo")]
        public long IdVeiculo { get; set; }

        [XmlElement("tipoveiculo")]
        public string TipoVeiculo { get; set; }

        [XmlElement("dataCadastro")]
        public string DataCadastro { get; set; }
    }
}