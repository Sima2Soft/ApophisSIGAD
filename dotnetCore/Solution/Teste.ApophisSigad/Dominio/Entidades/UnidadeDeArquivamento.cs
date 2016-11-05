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
    /// Entidade UnidadeDeArquivamento
    /// Representa no Mundo Real: Unidade de Arquivamento
    /// 
    /// Uma Unidade de Arquivamento pode ocorrer somente em Classes <see cref="Classe"/> que não
    /// têm outras Classes <see cref="Classe"/> a elas subordinadas, em qualquer nível de hierarquia do
    /// Plano de Classificação <see cref="PlanoDeClassificacao"/>. Cada unidade de Arquivamento tem, pelo menos,
    /// um Volume <see cref="Volume"/>, que armazena Documentos Arquivísticos <see cref="DocumentoArquivistico"/>. 
    /// </summary>
    public class UnidadeDeArquivamento
    {
        #region Atributos
        
        #endregion

        #region Construtores

        #endregion

        #region Propriedades        

        [FichaIndividual(
            "Número do processo/dossiê/Pasta",
            "Número ou código alfanumérico de registro do processo ou dossiê.",
            "Identificar de  forma   unívoca e   persistente um  processo    ou  dossiê. " +
            "Permitir o controle dos registros de autuações de processos e dos registros de abertura de dossiês. " +
            "Permitir a pesquisa sobre processos e / ou dossiês. ",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.NaoSeAplica,
            "As	instituições	devem	seguir	normas	específicas	em	seu	âmbito	de	atuação	ou esfera de competência",
            "Processo n. 0032.000125 / 2008;" + 
            "Processo n. 0400.001412 / 2000 - 26.",
            "3.1.10"
            )]
        public String NumeroDaUnidadeDeArquivamento { get; set; }

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

        [FichaIndividual(
            "Título",
            "Elemento de descrição que nomeia o documento ou processo / dossiê.Pode ser " +
            "formal ou atribuído: " +
            "• formal: designação registrada no documento; " +
            "•  atribuído: designação  providenciada   para    identificação   de  um  documento " +
            "formalmente desprovido de título.",
            "Identificar	o	documento. Servir como elemento de acesso ao documento.",
            ValoresDeObrigatoriedade.Facultativo, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio,
            "Cada instituição deverá fixar critérios para títulos	atribuídos.",
            "Processo de Aquisição de Equipamentos de Informática; " +
            "Balancete da Universidade ACD 2007.",
            "1.6.2 / 3.1.5 / 5.2.6")]
        public String Titulo { get; set; }

        [FichaIndividual(
            "Descrição",
            "Exposição concisa do conteúdo do documento, processo ou dossiê.",
            "Identificar o conteúdo	do documento." +
            "Facilitar a pesquisa.",
            ValoresDeObrigatoriedade.Facultativo, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Facultativo,
            "Cada instituição deverá fixar critérios e modelos com elementos básicos para a " +
            "elaboração da descrição.",
            "Convênio de cooperação para desenvolvimento de aplicações do laser entre a " +
            "Instituição A e a Instituição B, com recursos do Programa Nacional ABC.",
            "3.1.5 / 3.1.11")]
        public virtual String Descricao { get; set; }

        [FichaIndividual(
            "Assunto",
            "Palavras-chave que representam o conteúdo do documento. " +
            "Pode ser de preenchimento livre ou com o uso de vocabulário controlado ou tesauro. " +
            "Diferente	do	já  estabelecido    no  código  de  classificação.",
            "Referir de forma sucinta o teor geral do documento.",
            ValoresDeObrigatoriedade.Facultativo, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Facultativo,
            "As	instituições	devem	definir	sua	política	de	indexação.",
            null,
            "3.1.5 / 3.1.11 / 3.2.11 / 5.2.6"
            )]
        public virtual String Assunto { get; set; }

        public Classe Classe { get; private set; }
        public TipoDeUnidadeDeArquivamento TipoUnidadeDeArquivamento { get; private set; }
        public IList<Volume> Volumes { get; private set; }

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
