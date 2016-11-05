using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ApophisSigad.Dominio.Comum.Anotacao
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    sealed class EventoDeGestaoAttribute : Attribute
    {
        readonly string evento;
        readonly string definicaoEElemento;
        readonly ValoresDeObrigatoriedade aplicaSeAProcessoOuDossie;
        readonly ValoresDeObrigatoriedade aplicaSeAVolume;
        readonly ValoresDeObrigatoriedade aplicaSeADocumento;
        readonly string requisito;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evento">Indicação do evento que deve ser registrado em metadado;</param>
        /// <param name="definicaoEElemento">Indica	a definição	do evento e	que	informação deve	ser	registrada em metadados;</param>
        /// <param name="aplicaSeAProcessoOuDossie">Aplica-se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada processo/dossiê. Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA); </param>
        /// <param name="aplicaSeAVolume">Aplica-se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada volume. Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA); </param>
        /// <param name = "aplicaSeADocumento" > Aplica - se a: Indica a obrigatoriedade da aplicação do elemento para
        /// cada documento.Os valores possíveis são: obrigatório(o), obrigatório se aplicável(oA), 
        /// facultativo(f)ou não se aplica(NA); </param>
        /// <param name="requisito">Os requisitos funcionais relacionados com o elemento de metadado.</param>
        public EventoDeGestaoAttribute(
            string evento,
            string definicaoEElemento,
            ValoresDeObrigatoriedade aplicaSeAProcessoOuDossie,
            ValoresDeObrigatoriedade aplicaSeAVolume,
            ValoresDeObrigatoriedade aplicaSeADocumento,
            string requisito
            )
        {
            this.evento = evento;
            this.definicaoEElemento = definicaoEElemento;
            this.aplicaSeAProcessoOuDossie = aplicaSeAProcessoOuDossie;
            this.aplicaSeADocumento = aplicaSeADocumento;
            this.aplicaSeAVolume = aplicaSeAVolume;
            this.requisito = requisito;
        }        

        public string Evento
        {
            get { return this.evento; }
        }

        public string DefinicaoEElemento
        {
            get { return this.definicaoEElemento; }
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

        public string Requisito
        {
            get { return this.requisito; }
        }
    }
}
