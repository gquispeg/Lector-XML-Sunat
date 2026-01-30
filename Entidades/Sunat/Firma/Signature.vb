Imports System.Security.Cryptography.Xml
Imports System.Xml.Serialization

<XmlRoot("Signature", Namespace:="http://www.w3.org/2000/09/xmldsig#")>
Public Class Signature
    <XmlElement("SignedInfo")>
    Public Property SignedInfo As SignedInfo

    <XmlElement("SignatureValue")>
    Public Property SignatureValue As String

    <XmlElement("KeyInfo")>
    Public Property KeyInfo As KeyInfo
End Class
