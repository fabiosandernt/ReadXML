using System.Net;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using ReadXML.Utils;

namespace ReadXml 
{
    public class Program 
    {
        static async Task Main(string[] args) 
        {
            var serializer = new XmlSerializer(typeof(Estoque));
            var estoqueResponse = new Estoque();

            using (var textReader = new StreamReader("./veiculo.xml"))
            {
                estoqueResponse  = (Estoque)serializer.Deserialize(textReader);
            }

            foreach(var item in estoqueResponse.Veiculos) {
                Console.WriteLine(new {item.IdVeiculo, item.TipoVeiculo, item.DataCadastro}.ToString());
            }
        }

    }
}