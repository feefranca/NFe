using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NFe.Architecture.Domain.Models
{
	[XmlRoot(ElementName = "infProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class InfProt
	{
		[XmlElement(ElementName = "tpAmb", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpAmb { get; set; }
		[XmlElement(ElementName = "verAplic", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VerAplic { get; set; }
		[XmlElement(ElementName = "chNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string ChNFe { get; set; }
		[XmlElement(ElementName = "dhRecbto", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DhRecbto { get; set; }
		[XmlElement(ElementName = "nProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NProt { get; set; }
		[XmlElement(ElementName = "digVal", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DigVal { get; set; }
		[XmlElement(ElementName = "cStat", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CStat { get; set; }
		[XmlElement(ElementName = "xMotivo", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XMotivo { get; set; }
	}
}
