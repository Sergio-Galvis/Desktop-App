using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    [XmlRoot(ElementName = "datos")]
    public class Datos
    {
        [XmlElement(ElementName = "razon_social")]
        public string Razon_social { get; set; }
        [XmlElement(ElementName = "identificacion")]
        public string Identificacion { get; set; }
        [XmlElement(ElementName = "tipo_cliente")]
        public string Tipo_cliente { get; set; }
        [XmlElement(ElementName = "zona")]
        public string Zona { get; set; }
        [XmlElement(ElementName = "codigo_solicitante")]
        public string Codigo_solicitante { get; set; }
        [XmlElement(ElementName = "estado_cliente")]
        public string Estado_cliente { get; set; }
        [XmlElement(ElementName = "codigo_terpel")]
        public string Codigo_terpel { get; set; }
        [XmlElement(ElementName = "direccion")]
        public string Direccion { get; set; }
        [XmlElement(ElementName = "nro_credito")]
        public string Nro_credito { get; set; }
        [XmlElement(ElementName = "propietario")]
        public string Propietario { get; set; }
        [XmlElement(ElementName = "nombre_ejecutivo")]
        public string Nombre_ejecutivo { get; set; }
        [XmlElement(ElementName = "regional")]
        public string Regional { get; set; }
        [XmlElement(ElementName = "codigo_sap")]
        public string Codigo_sap { get; set; }
        [XmlElement(ElementName = "grupo_vendedores")]
        public string Grupo_vendedores { get; set; }
        [XmlElement(ElementName = "activo_sap")]
        public string Activo_sap { get; set; }
        [XmlElement(ElementName = "credito")]
        public string Credito { get; set; }
        [XmlElement(ElementName = "credito_habilitado")]
        public string Credito_habilitado { get; set; }
        [XmlElement(ElementName = "modalidad")]
        public string Modalidad { get; set; }
        [XmlElement(ElementName = "bloqueo_tarjeta")]
        public string Bloqueo_tarjeta { get; set; }
        [XmlElement(ElementName = "contratos")]
        public string Contratos { get; set; }
        [XmlElement(ElementName = "rom")]
        public string Rom { get; set; }
        [XmlElement(ElementName = "ceco")]
        public string Ceco { get; set; }
        [XmlElement(ElementName = "tarjeta")]
        public string Tarjeta { get; set; }
        [XmlElement(ElementName = "calcomania")]
        public string Calcomania { get; set; }
        [XmlElement(ElementName = "nombre")]
        public string Nombre { get; set; }
    }

    [XmlRoot(ElementName = "aut")]
    public class Aut
    {
        [XmlElement(ElementName = "diarias")]
        public string Diarias { get; set; }
        [XmlElement(ElementName = "semanales")]
        public string Semanales { get; set; }
        [XmlElement(ElementName = "quincenales")]
        public string Quincenales { get; set; }
        [XmlElement(ElementName = "mensuales")]
        public string Mensuales { get; set; }
    }

    [XmlRoot(ElementName = "con")]
    public class Con
    {
        [XmlElement(ElementName = "diarias")]
        public string Diarias { get; set; }
        [XmlElement(ElementName = "semanales")]
        public string Semanales { get; set; }
        [XmlElement(ElementName = "quincenales")]
        public string Quincenales { get; set; }
        [XmlElement(ElementName = "mensuales")]
        public string Mensuales { get; set; }
    }

    [XmlRoot(ElementName = "blo")]
    public class Blo
    {
        [XmlElement(ElementName = "diarias")]
        public string Diarias { get; set; }
        [XmlElement(ElementName = "semanales")]
        public string Semanales { get; set; }
        [XmlElement(ElementName = "quincenales")]
        public string Quincenales { get; set; }
        [XmlElement(ElementName = "mensuales")]
        public string Mensuales { get; set; }
    }

    [XmlRoot(ElementName = "dis")]
    public class Dis
    {
        [XmlElement(ElementName = "diarias")]
        public string Diarias { get; set; }
        [XmlElement(ElementName = "semanales")]
        public string Semanales { get; set; }
        [XmlElement(ElementName = "quincenales")]
        public string Quincenales { get; set; }
        [XmlElement(ElementName = "mensuales")]
        public string Mensuales { get; set; }
    }

    [XmlRoot(ElementName = "visitas")]
    public class Visitas
    {
        [XmlElement(ElementName = "aut")]
        public Aut Aut { get; set; }
        [XmlElement(ElementName = "con")]
        public Con Con { get; set; }
        [XmlElement(ElementName = "blo")]
        public Blo Blo { get; set; }
        [XmlElement(ElementName = "dis")]
        public Dis Dis { get; set; }
    }

    [XmlRoot(ElementName = "volumen")]
    public class Volumen
    {
        [XmlElement(ElementName = "aut")]
        public Aut Aut { get; set; }
        [XmlElement(ElementName = "con")]
        public Con Con { get; set; }
        [XmlElement(ElementName = "blo")]
        public Blo Blo { get; set; }
        [XmlElement(ElementName = "dis")]
        public Dis Dis { get; set; }
    }

    [XmlRoot(ElementName = "estado")]
    public class Estado
    {
        [XmlElement(ElementName = "visitas")]
        public Visitas Visitas { get; set; }
        [XmlElement(ElementName = "volumen")]
        public Volumen Volumen { get; set; }
    }

    [XmlRoot(ElementName = "asistente")]
    public class Asistente
    {
        [XmlElement(ElementName = "datos")]
        public Datos Datos { get; set; }
        [XmlElement(ElementName = "estado")]
        public Estado Estado { get; set; }
    }

    [XmlRoot(ElementName = "terpel")]
    public class Terpel
    {
        [XmlElement(ElementName = "asistente")]
        public Asistente Asistente { get; set; }
    }

}

