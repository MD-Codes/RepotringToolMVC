using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class publicwhip
    {

        private publicwhipRegmem[] regmemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("regmem")]
        public publicwhipRegmem[] regmem
        {
            get
            {
                return this.regmemField;
            }
            set
            {
                this.regmemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class publicwhipRegmem
    {

        private publicwhipRegmemCategory[] categoryField;

        private string personidField;

        private string membernameField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public publicwhipRegmemCategory[] category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string personid
        {
            get
            {
                return this.personidField;
            }
            set
            {
                this.personidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string membername
        {
            get
            {
                return this.membernameField;
            }
            set
            {
                this.membernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class publicwhipRegmemCategory
    {

        private publicwhipRegmemCategoryItem[] recordField;

        private byte typeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
        public publicwhipRegmemCategoryItem[] record
        {
            get
            {
                return this.recordField;
            }
            set
            {
                this.recordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class publicwhipRegmemCategoryItem
    {

        private publicwhipRegmemCategoryItemStrong strongField;

        private string[] brField;

        private string[] textField;

        /// <remarks/>
        public publicwhipRegmemCategoryItemStrong strong
        {
            get
            {
                return this.strongField;
            }
            set
            {
                this.strongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br")]
        public string[] br
        {
            get
            {
                return this.brField;
            }
            set
            {
                this.brField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class publicwhipRegmemCategoryItemStrong
    {

        private publicwhipRegmemCategoryItemStrongEM emField;

        /// <remarks/>
        public publicwhipRegmemCategoryItemStrongEM em
        {
            get
            {
                return this.emField;
            }
            set
            {
                this.emField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class publicwhipRegmemCategoryItemStrongEM
    {

        private string[] brField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br")]
        public string[] br
        {
            get
            {
                return this.brField;
            }
            set
            {
                this.brField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

}

