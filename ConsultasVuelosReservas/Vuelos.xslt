<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    
    <xsl:template match="/">
      <table >

       
        <tr style ="background-color: #C0C0C0">
          <td style=" border: thin double #800000"> FechaHora </td>
          <td style=" border: thin double #800000"> AeropuertoSalida </td>
          <td style=" border: thin double #800000"> Aeropuertollegada </td>
          <td style=" border: thin double #800000"> Asiento </td>
        
        </tr>

        
        <xsl:for-each select="Raiz/Reservas">
          <tr>
            <td>
              <xsl:value-of select="FechaHora" />
            </td>
            <td>
              <xsl:value-of select="Aeropuertosalida" />
            </td>
            <td>
              <xsl:value-of select="Aeropuertollegada" />
            </td>
            <td>
              <xsl:value-of select="Asiento" />
            </td>
          </tr>
        </xsl:for-each>
      </table>
    </xsl:template>
</xsl:stylesheet>
