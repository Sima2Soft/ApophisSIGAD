using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ApophisSigad.Dominio.Comum.Anotacao
{
    /// <summary>
    ///  Os valores possíveis são: 
    ///  Obrigatório (o) = 1
    ///  Obrigatório se aplicável (oA) = 2, 
    ///  Facultativo(f) = 3,
    ///  Não se aplica(NA) = 4.    
    /// </summary>
    public enum ValoresDeObrigatoriedade
    {
        Obrigatorio = 1,
        ObrigatorioSeAplicavel = 2,
        Facultativo = 3,
        NaoSeAplica = 4
    }

    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Enum,
        Inherited = false,
        AllowMultiple = true)]
    sealed class FichaIndividualAttribute : Attribute
    {                
        readonly string designacao;
        readonly string definicao;
        readonly string objetivo;
        readonly ValoresDeObrigatoriedade aplicaSeAProcessoOuDossie;
        readonly ValoresDeObrigatoriedade aplicaSeAVolume;
        readonly ValoresDeObrigatoriedade aplicaSeADocumento;
        readonly String notaDeAplicacao;
        readonly String exemplos;
        readonly String requisitos;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="designacao">Designação: Indicação do nome atribuído ao elemento</param>
        /// <param name="definicao">Definição: Indica que informação deve ser registrada no elemento de metadado</param>
        /// <param name="objetivo">Objetivo: A referência do que se pretende alcançar com a aplicação do elemento;</param>
        /// <param name="aplicaSeAProcessoOuDossie">Aplica-se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada processo/dossiê. Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA). </param>
        /// <param name="aplicaSeAVolume">Aplica-se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada volume. Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA). </param>
        /// <param name = "aplicaSeADocumento" > Aplica - se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada documento.Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA). </param>
        /// <param name="notaDeAplicacao">Nota de aplicação: Sugere formas de aplicação do elemento</param>
        /// <param name="exemplos">Exemplos: Apresenta alguns exemplos de aplicação que explicam o elemento</param>
        /// <param name="requisitos">Requisito: Os requisitos funcionais relacionados com o elemento de metadado</param>        
        public FichaIndividualAttribute(            
            string designacao,
            string definicao,
            string objetivo,
            ValoresDeObrigatoriedade aplicaSeAProcessoOuDossie,
            ValoresDeObrigatoriedade aplicaSeAVolume,
            ValoresDeObrigatoriedade aplicaSeADocumento,
            String notaDeAplicacao,
            String exemplos,
            String requisitos)
        {
            this.designacao = designacao;
            this.definicao = definicao;
            this.objetivo = objetivo;
            this.aplicaSeAProcessoOuDossie = aplicaSeAProcessoOuDossie;
            this.aplicaSeAVolume = aplicaSeAVolume;
            this.aplicaSeADocumento = aplicaSeADocumento;            
            this.notaDeAplicacao = notaDeAplicacao;
            this.exemplos = exemplos;
            this.requisitos = requisitos;            
        }
        
        public String Designacao
        {
            get { return this.designacao; }            
        }

        public String Definicao
        {
            get { return this.definicao; }
        }

        public String Objetivo
        {
            get { return this.objetivo; }
        }

        public ValoresDeObrigatoriedade AplicaSeAProcessoOuDossie
        {
            get { return this.aplicaSeAProcessoOuDossie; }
        }

        public ValoresDeObrigatoriedade AplicaSeAVolume
        {
            get { return this.aplicaSeAVolume; }
        }

        public ValoresDeObrigatoriedade AplicaSeADocumento
        {
            get { return this.aplicaSeADocumento; }
        }
        public String NotaDeAplicacao
        {
            get { return this.notaDeAplicacao; }
        }
        public String Exemplos
        {
            get { return this.exemplos; }
        }
        public String Requisitos
        {
            get { return this.requisitos; }
        }               
    }    
}
