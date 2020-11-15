using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFe.Architecture.Domain.Models
{
    public class NFe
    {       
        [XmlElement(ElementName = "infNFe")]
        public InfNFe InformacoesNFe { get; set; }
        
        public class InfNFe
        {
            [XmlElement("ide")]
            public Identificacao Identificacao { get; set; }

            [XmlElement("emit")]
            public Emitente Emitente { get; set; }

            //[XmlElement("dest")]
            //public List<Destinatario> Destinatario { get; set; }

            [XmlElement("det")]
            public List<Detalhe> Detalhe { get; set; }
            public Total Total { get; set; }
            [XmlElement(ElementName = "transp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
            public Transp Transp { get; set; }
            [XmlElement(ElementName = "pag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
            public Pag Pag { get; set; }
            [XmlElement(ElementName = "infAdic", Namespace = "http://www.portalfiscal.inf.br/nfe")]
            public InfAdic InfAdic { get; set; }
            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "versao")]
            public string Versao { get; set; }
        }
    }
}
