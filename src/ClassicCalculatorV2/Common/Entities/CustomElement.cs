using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


#if !WINDOWS_PHONE
[Serializable]
#endif
public class CustomElement
{

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int X { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int Y { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public string ID { get; set; }


#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public bool IsDocked { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public bool IsLocked { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int TypeId { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int IsVisible { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public string FileName { get; set; }

    //#if !WINDOWS_PHONE
    //        [XmlAttribute]
    //#endif
    //        public object Content { get; set; }


#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int Width { get; set; }

#if !WINDOWS_PHONE
    [XmlAttribute]
#endif
    public int Height { get; set; }

}
