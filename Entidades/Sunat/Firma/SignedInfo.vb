Imports System.Security.Cryptography.Xml
Imports System.Xml.Serialization

Public Class SignedInfo

    <XmlElement("CanonicalizationMethod")>
    Public Property CanonicalizationMethod As CanonicalizationMethod

    <XmlElement("SignatureMethod")>
    Public Property SignatureMethod As SignatureMethod

    <XmlElement("Reference")>
    Public Property Reference As Reference

End Class
