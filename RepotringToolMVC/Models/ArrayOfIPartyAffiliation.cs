using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ArrayOfIPartyAffiliation
    {

        private ArrayOfIPartyAffiliationIPartyAffiliation[] iPartyAffiliationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPartyAffiliation")]
        public ArrayOfIPartyAffiliationIPartyAffiliation[] IPartyAffiliation
        {
            get
            {
                return this.iPartyAffiliationField;
            }
            set
            {
                this.iPartyAffiliationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfIPartyAffiliationIPartyAffiliation
    {

        private ushort userIdField;

        private string partyNameField;

        /// <remarks/>
        public ushort UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        public string PartyName
        {
            get
            {
                return this.partyNameField;
            }
            set
            {
                this.partyNameField = value;
            }
        }
    }


}
