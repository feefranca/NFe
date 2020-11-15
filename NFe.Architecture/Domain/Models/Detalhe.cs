using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NFe.Architecture.Domain.Models
{
    public class Detalhe
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }
    }
}
