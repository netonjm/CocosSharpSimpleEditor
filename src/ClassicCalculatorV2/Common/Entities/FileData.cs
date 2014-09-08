using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;




#if !WINDOWS_PHONE
    [Serializable]
#endif
    public class FileData
    {

#if !WINDOWS_PHONE
        //[XmlAttribute]
        [XmlArray]
#endif
        public CustomElement[] Elements { get; set; }

#if !WINDOWS_PHONE
        [XmlAttribute]
#endif
        public int ResolutionWidth { get; set; }

#if !WINDOWS_PHONE
        [XmlAttribute]
#endif
        public int ResolutionHeight { get; set; }

    }
