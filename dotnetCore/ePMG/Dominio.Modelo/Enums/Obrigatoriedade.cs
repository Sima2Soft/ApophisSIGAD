using ePmg.Dominio.Modelo.Comum.Attributes; 

namespace ePmg.Dominio.Modelo.Enums
{
    /// <summary>
    /// Define o grau de uso do elemento, divididos em:
    /// 1 - Obrigatório: este elemento deve obrigatoriamente ter um valor;
    /// 2 - Obrigatório se aplicável: a este elemento deve ser fornecido um valor se  o tipo de recurso assim o requerer;
    /// 3- Opcional: a este elemento pode ser fornecido um valor se o dado estiver disponível e apropriado ao recurso.
    /// A obrigatoriedade aplica-se ao elemento e a seus qualificadores quando for o caso.
    /// </summary>     
    public enum Obrigatoriedade
    {
        [Ajuda("Obrigatório","O elemento deve obrigatoriamente ter um valor.")]        
        Obrigatorio = 1,

        [Ajuda("Obrigatório se Aplicável","O elemento deve ser fornecido um valor se  o tipo de recurso assim o requerer.")]        
        ObrigatorioSeAplicavel = 2,

        [Ajuda("Opcional","O elemento pode ser fornecido um valor se o dado estiver disponível e apropriado ao recurso.")]
        Opcional = 3
    }
}