using System.Collections.Generic;
using ePmg.Dominio.Modelo.Enums;

namespace ePmg.Dominio.Modelo
{
    public class MetadadoPadraoBuilder
    {
        private string nome;
        private string identificador;
        private string definicao;
        private Obrigatoriedade obrigatoriedade;
        private string objetivo;
        private string comentario;
        private string naoConfundirCom;
        private List<string> qualificadores = new List<string>();
        private string exemplo;
        private string sintaxeHtml;
        private string esquema;
        private Mapeamento mapeamento;

        MetadadoPadraoBuilder()
        {}

        public static MetadadoPadraoBuilder of()
        {
            return new MetadadoPadraoBuilder();
        }

        public MetadadoPadraoBuilder ComNome(string nome)
        {
            this.nome = nome;
            return this;
        }

        public MetadadoPadraoBuilder ComIdentificador (string identificador)
        {
            this.identificador = identificador;
            return this;
        }
        public MetadadoPadraoBuilder ComDefinicao (string definicao)
        {
            this.definicao = definicao;
            return this;
        }
        public MetadadoPadraoBuilder ComObrigatoriedade (Obrigatoriedade obrigatoriedade)
        {
            this.obrigatoriedade = obrigatoriedade;
            return this;
        }
        public MetadadoPadraoBuilder ComObjetivo(string objetivo)
        {
            this.objetivo = objetivo;
            return this;
        }
        public MetadadoPadraoBuilder ComComentario (string comentario)
        {
            this.comentario = comentario;
            return this;
        }
        public MetadadoPadraoBuilder ComNaoConfundirCom(string naoConfundirCom)
        {
            this.naoConfundirCom = naoConfundirCom;
            return this;
        }
        public MetadadoPadraoBuilder ComAdicaoDeQualificador (string qualificador)
        {
            if(qualificador != null)
            {
                this.qualificadores.Add(qualificador);
                return this;
            }
            return null;                    
        }
        public MetadadoPadraoBuilder ComExemplo (string exemplo)
        {
            this.exemplo = exemplo;
            return this;
        }
        public MetadadoPadraoBuilder ComSintaxeHtml (string sintaxeHtml)
        {
            this.sintaxeHtml = sintaxeHtml;
            return this;
        }
        public MetadadoPadraoBuilder ComEsquema (string esquema)
        {
            this.esquema = esquema;
            return this;
        }
        public MetadadoPadraoBuilder ComMapeamento(Mapeamento mapeamento)
        {
            this.mapeamento = mapeamento;
            return this;
        }

        public MetadadoPadrao Build()
        {
            return MetadadoPadrao.of(
                this.nome,this.identificador,this.definicao,this.obrigatoriedade, this.objetivo,this.comentario,this.naoConfundirCom,this.qualificadores,this.exemplo,this.sintaxeHtml,this.esquema,this.mapeamento       );            
        }      
        

    }    
}