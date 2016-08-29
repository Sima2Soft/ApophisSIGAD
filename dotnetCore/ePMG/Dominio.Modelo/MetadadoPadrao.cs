using System.Collections.Generic;
using System.Text;
using ePmg.Dominio.Modelo.Enums;

namespace ePmg.Dominio.Modelo
{    
    public class MetadadoPadrao
    {
        private string nome;
        private string identificador;
        private string definicao;
        private Obrigatoriedade obrigatoriedade;
        private string objetivo;
        private string comentario;
        private string naoConfundirCom;
        private IList<string> qualificadores;
        private string exemplo;
        private string sintaxeHtml;
        private string esquema;
        private Mapeamento mapeamento;

        MetadadoPadrao()
        {}

        MetadadoPadrao(string nome,string identificador,string definicao,Obrigatoriedade obrigatoriedade,string objetivo,string comentario,string naoConfundirCom,IList<string> qualificadores,string exemplo,            string sintaxeHtml,string esquema,Mapeamento mapeamento)
        {
            this.nome = nome;
            this.identificador =identificador;
            this.definicao = definicao;
            this.obrigatoriedade = obrigatoriedade;
            this.objetivo = objetivo;
            this.comentario = comentario;
            this.naoConfundirCom = naoConfundirCom;
            this.qualificadores = qualificadores;
            this.exemplo = exemplo;
            this.sintaxeHtml = sintaxeHtml;
            this.esquema = esquema;
            this.mapeamento = mapeamento;
        }        

        public static MetadadoPadrao of(string nome,string identificador,string definicao,Obrigatoriedade obrigatoriedade,string objetivo,string comentario,string naoConfundirCom,IList<string> qualificadores,string exemplo,            string sintaxeHtml,string esquema,Mapeamento mapeamento)
        {
            return new MetadadoPadrao(nome,identificador,definicao,obrigatoriedade,objetivo,comentario,naoConfundirCom,qualificadores,exemplo,sintaxeHtml,esquema,mapeamento);
        }

        public static MetadadoPadrao of()
        {
            return new MetadadoPadrao();
        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
                builder.AppendLine(nome);
                builder.AppendLine(identificador);
                builder.AppendLine(definicao);
                builder.AppendLine(obrigatoriedade.ToString());
                builder.AppendLine(objetivo);
                builder.AppendLine(comentario);
                builder.AppendLine(naoConfundirCom);
                builder.AppendLine(string.Join(",",qualificadores));
                builder.AppendLine(exemplo);
                builder.AppendLine(sintaxeHtml);
                builder.AppendLine(esquema);
                builder.AppendLine(mapeamento.ToString());
                return builder.ToString();
        }
    } //Fim de MetadadoPadrao
} //Fim do namespace