using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Teste.ApophisSigad.Dominio.Comum.Anotacao;
using Teste.ApophisSigad.Dominio.Comum.Enums;

namespace Teste.ApophisSigad.Dominio.Entidades
{
    /// <summary>
    /// Entidade Volume
    /// Representa no Mundo Real: Volume
    /// 
    /// Cada Unidade de Arquivamento <see cref="UnidadeDeArquivamento"/> é composta por um ou mais Volumes. 
    /// Esta prática tem origem nos documentos não digitais <see cref="Documento"/>, de forma a possibilitar que os
    /// Volumes tenham tamanho e peso de fácil manejo. No caso dos Documentos Digitais <see cref="Documento"/>, tal
    /// prática pode se mostrar aproprieada em situações em que a divisão de volumes faciliete a manipulação
    /// das Unidades de Arquivamento <see cref="UnidadeDeArquivamento"/>, como por exemplo, nas atividades
    /// de seleção, transferência etc.
    /// Em geral, a maior parte das Unidades de Arquivamento <see cref="UnidadeDeArquivamento"/> não apresenta
    /// mais de um Volume <see cref="Volume"/>. Neste caso, o conceito de Volume <see cref="Volume"/> é transparente
    /// para os usuários.
    /// </summary>
    public class Volume
    {
        #region Atributos

        #endregion

        #region Construtores

        #endregion

        #region Propriedades

        [FichaIndividual(
            "Identificador	do	volume",
            "Identificador	único	atribuído	ao	volume	do	processo	ou	dossiê	no	ato	de	sua captura para o SIGAD.",
            "Identificar de  forma   unívoca o   volume	do	processo    ou  dossiê  para    que o   SIGAD possa " +
            "gerenciá - lo. " +
            "Estabelecer a relação entre o processo ou dossiê e os volumes e documentos que os integram. ",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Obrigatorio,
            "Aplicável no âmbito do SIGAD. " +
            "Pode ser um  elemento identificador simples e conter  um  componente para localização em ambiente eletrônico. " +
            "Pode ser gerado automaticamente pelo SIGAD. " +
            "É recomendável que possa se  integrar a sistemas de  identificadores persistentes. " +
            "As instituições devem seguir normas específicas em seu âmbito de atuação ou esfera de competência. ",
            null,
            "1.5 / 1.6.2 / 3.1.7 / 3.1.9 / 5.2.6")]
        public long? VolumeId { get; private set; }

        [FichaIndividual(
        "Tipo de meio",
        "Identificação do meio do documento/volume/processo/dossiê:	digital, não digital ou híbrido.",
        "Identificar	se	o	documento/volume/processo/dossiê	é	digital,	não	digital	ou	híbrido " +
        "para controlar as relações entre os meios e o monitoramento de preservação.",
        ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio,
        "No documento/volume/processo/dossiê híbrido, os relacionamentos deverão ser registrados para identificar " +
        "a parte não digital e a parte digital." +
        "Ver elemento 1.1.28 – Relação com outros documentos.",
        null,
        "1.6.1 / 1.6.2 / 3.4 / 4.3.13"
        )]
        public TipoDeMeio TipoDeMeio { get; private set; }
        public UnidadeDeArquivamento UnidadeDeArquivamento { get; private set; }
        public IList<DocumentoArquivistico> DocumentosArquivisticos { get; private set; }

        #endregion

        #region Métodos

        #endregion

        #region Sobrescritas do Papai

        /// <summary>
        /// Provê igualdade entre classes de mesmo tipo de DocumentoArquivistico
        /// </summary>
        /// <param name="o">Objeto a ser verificada a igualdade</param>
        /// <returns>true => se for igual e false => se for diferente</returns>			
        public override bool Equals(object o)
        {
            if (o.GetType().IsAssignableFrom(GetType()))
            {
                BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
                FieldInfo[] classeLocal = typeof(DocumentoArquivistico).GetFields(visibilidadePermitida);
                FieldInfo[] classeExterna = o.GetType().GetFields(visibilidadePermitida);

                int totalDeCamposLocais = classeLocal.Select(cl => cl.GetValue(this)).ToList().Count;
                int totalDeCamposExternos = classeExterna.Select(ce => ce.GetValue(this)).ToList().Count;

                var atributos = typeof(DominioTeste).GetFields(visibilidadePermitida).Select(u => u.GetValue(this)).ToList();

                if ((classeLocal != null && totalDeCamposLocais > 0) && classeExterna != null && totalDeCamposExternos > 0)
                {

                    var igualdade = (from l in classeLocal
                                     from e in classeExterna
                                     where l.Name == e.Name && l.GetValue(this) == e.GetValue(this)
                                     select l).ToList();

                    if (igualdade != null && igualdade.Count.Equals(totalDeCamposLocais))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// A hash code is a numeric value that is used to insert and identify an object in a hash-based collection
        /// such as the Dictionary<TKey, TValue> class, the Hashtable class,or a type derived from the DictionaryBase class.
        /// Two objects that are equal return hash codes that are equal.
        /// </summary>
        /// <returns>O valor do hash gerado ou 0 para a Classe DocumentoArquivistico</returns>
        public override int GetHashCode()
        {
            BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

            int resultado = new Random().Next(0, DateTime.Now.Hour);

            //Pega os Atributos da Classe            
            FieldInfo[] atributos = GetType().GetFields(visibilidadePermitida);

            foreach (FieldInfo atributo in atributos)
            {
                //Calcula de acordo com o tipo e o valor do campo
                switch (atributo.FieldType.Name)
                {
                    case "Boolean":
                        resultado = 31 * resultado + (bool.Parse(atributo.GetValue(this).ToString()) ? 1 : 0);
                        break;
                    case "Byte":
                        resultado = 31 * resultado + Convert.ToInt16((byte.Parse(atributo.GetValue(this).ToString())));
                        break;
                    /*case "char":
                        resultado = 31 * resultado + (char.Parse(atributo.GetValue(this).ToString()));
                        break;
                    */
                    case "Short":
                        resultado = 31 * resultado + (short.Parse(atributo.GetValue(this).ToString()));
                        break;
                    case "Int":
                        resultado = 31 * resultado + (int.Parse(atributo.GetValue(this).ToString()));
                        break;
                    case "Long":
                        resultado = 31 * resultado + int.Parse(atributo.GetValue(this).ToString()) ^ (int.Parse(atributo.GetValue(this).ToString()) >> 32);
                        break;
                    case "Float":
                        resultado = 31 * resultado + Convert.ToInt16(atributo.GetValue(this));
                        break;
                    case "Double":
                        resultado = 31 * resultado + Convert.ToInt16(double.Parse(atributo.GetValue(this).ToString())) ^ (Convert.ToInt16(double.Parse(atributo.GetValue(this).ToString())) >> 32);
                        break;
                }

                switch (atributo.FieldType.FullName)
                {
                    case "System.Nullable`1[System.Int64]":
                        resultado = 31 * resultado + (int.Parse(atributo.GetValue(this).ToString()));
                        break;

                    case "System.Nullable`1[System.Int32]":
                        resultado = 31 * resultado + int.Parse(atributo.GetValue(this).ToString()) ^ (int.Parse(atributo.GetValue(this).ToString()) >> 32);
                        break;
                }
            }
            //// Objects

            //resultado = 31 * resultado + Arrays.hashCode(arrayField);              // var bits » 32-bit

            //resultado = 31 * resultado + referenceField.hashCode();                // var bits » 32-bit (non-nullable)   
            //resultado = 31 * resultado +                                           // var bits » 32-bit (nullable)   
            //    (nullableReferenceField == null
            //        ? 0
            //        : nullableReferenceField.hashCode());

            //return resultado;
            return resultado;
        }

        /// <summary>
        /// Mostra a saída formatada dos valores presentes
        /// nos atributos de DocumentoArquivistico
        /// </summary>
        /// <returns>Uma string contendo os valores dos atributos da Classe Incluindo seus relacionamentos</returns>
        public override string ToString()
        {
            BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
            StringBuilder builder = new StringBuilder();

            //Pega os Atributos da Classe            
            FieldInfo[] atributos = GetType().GetFields(visibilidadePermitida);
            builder.Append("[ ");
            foreach (FieldInfo campo in atributos)
            {
                builder.Append(String.Format("{0} => {1} ", campo.Name, campo.GetValue(this)));
            }

            builder.Append(" ] ");
            return !String.IsNullOrEmpty(builder.ToString()) ? builder.ToString() : String.Empty;
        }
        #endregion

    }
}
