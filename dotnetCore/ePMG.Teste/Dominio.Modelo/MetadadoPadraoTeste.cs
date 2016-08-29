using ePmg.Dominio.Modelo;
using ePmg.Dominio.Modelo.Enums;
using Xunit;
namespace ePmg.Teste
{
    public class MetadadoPadraoTeste
    {
        [Fact]
        public void ConstroiMetadadoPadrao()
        {
            MetadadoPadrao metadadoPadrao = MetadadoPadraoBuilder.of()
            .ComNome("Abrangência")
            .ComIdentificador("Coverage")
            .ComDefinicao("Extensão espacial e temporal do recurso.")
            .ComObrigatoriedade(Obrigatoriedade.ObrigatorioSeAplicavel)
            .ComObjetivo("Permitir que uma pesquisa se restrinja a recursos sobre um determinado lugar ou tempo.")
            .ComComentario("Esse elemento deve ser utilizado para descrever a informação contida no recurso e somente em situações onde o recurso se relaciona com um tempo ou lugar específico. Recomenda-se que a atribuição deste elemento seja feita por meio dos seus qualificadores: Abrangência Espacial e Abrangência Temporal. Abrangência.Espacial refere-se à localização geográfica identificada sempre que possível à ordem hierárquica tais como: bairro, distrito, município, estado, região, país, nesta ordem. Por exemplo, “Vitória, Espírito Santo, Brasil”, “Nordeste, Brasil”, “Vale do São Francisco, Brasil” As datas devem estar no padrão em formato do W3C, ex.: aaaa-mm-dd. Abrangência.Temporal refere-se à indicação de datas, de preferência completas, e dependendo do recurso com hora, minuto e segundo. As datas devem estar no padrão do W3C: aaaa-mm-dd.")
            .ComNaoConfundirCom("Data - indica um evento no ciclo de vida do recurso, como criação, publicação ou recebimento             Abrangência.Temporal refere-se ao período de tempo referido no                     conteúdo do recurso. Assunto - indica termos que representem o conteúdo do recurso.\nAbrangência refere-se à extensão espacial e temporal do recurso.\nLocalização - indica a localização física do recurso. Abrangência espacial diz respeito à jurisdição ou espaço geográfico referido no conteúdo do recurso.")
            .ComAdicaoDeQualificador("abrangencia.espacial\n(coverage.spatial)")
            .ComAdicaoDeQualificador("abrangencia.temporal\n(coverage.temporal)")                        
            .Build();

            Assert.True(!string.IsNullOrEmpty(metadadoPadrao.ToString()));
        }
    }   
}