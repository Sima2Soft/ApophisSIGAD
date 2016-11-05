using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ApophisSigad.Dominio.Comum.Enums
{
    /// <summary>
    /// Indicação do grau de formalização do documento:
    /// • minuta/rascunho(pré-original): versão preliminar do documento;
    /// • original: primeiro documento completo e efetivo;
    /// • cópia: resultado da reprodução do documento.
    /// </summary>
    public enum GrauDeFormalizacao
    {
        /// <summary>
        /// Minuta/Rascunho(pré-original): versão preliminar do documento;
        /// </summary>
        MinutaOuRascunho = 1,

        /// <summary>
        /// Original: primeiro documento completo e efetivo;
        /// </summary>
        Original = 2,

        /// <summary>
        /// Cópia: resultado da reprodução do documento.
        /// </summary>
        Copia = 3
    }
}
