using ePmg.Dominio.Modelo.Comum.Attributes;

namespace ePmg.Dominio.Modelo.Enums
{
    public enum Mapeamento
    {
        [Ajuda("e-GMS","Government Metadata Standard")]
        eGMS = 1,

        [Ajuda("AGLS","Australian Government Locator Service")]
        AGLS = 2,

        [Ajuda("GILS","Government Locator Service")]
        GILS = 3,

        [Ajuda("FGDC","Federal Geographic Data Committee (FGDC) Metadata")]
        FGDC = 4,

        [Ajuda("MARC","MAchine-Readable Cataloging")]
        MARC = 5        
    }
}