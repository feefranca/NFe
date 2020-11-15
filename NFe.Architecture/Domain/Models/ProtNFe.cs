using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NFe.Architecture.Domain.Models
{
    [XmlRoot(ElementName = "protNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class ProtNFe
    {
        [XmlElement(ElementName = "infProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public InfProt InfProt { get; set; }
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }
    }
}
