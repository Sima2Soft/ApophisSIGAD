using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.ApophisSigad.Dominio.Comum.Anotacao;

namespace Teste.ApophisSigad.Dominio.Comum.Enums
{
        [FichaIndividual(
            "Tipo de meio",
            "Identificação do meio do documento/volume/processo/dossiê:	digital, não digital ou híbrido.",
            "Identificar	se	o	documento/volume/processo/dossiê	é	digital,	não	digital	ou	híbrido " +
            "para controlar as relações entre os meios e o monitoramento de preservação.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Obrigatorio,
            "No documento/volume/processo/dossiê híbrido, os relacionamentos deverão ser registrados para identificar " +
            "a parte não digital e a parte digital." +
            "Ver elemento 1.1.28 – Relação com outros documentos.",
            null,
            "1.6.1 / 1.6.2 / 3.4 / 4.3.13"
            )]
   public enum TipoDeMeio
    {
        Digital = 0,
        NaoDigital = 1,
        Hibrido = 2
    }
}
