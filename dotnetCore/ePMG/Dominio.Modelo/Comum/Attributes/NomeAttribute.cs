using System;

namespace ePmg.Dominio.Modelo.Comum.Attributes 
{
    /// <summary>
    /// Especifica o nome correto e real de algum artefato
    /// Nome = O Nome original a ser informado.
    /// </summary>
    [Obsolete("Usar o Atributo Ajuda ao invés desse.")]
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class NomeAttribute : Attribute
    {        
        readonly string nome;
                
        public NomeAttribute (string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new InvalidOperationException("A Descricao não pode ser vazia!");
            }else{
                this.nome = nome;
            }
        }
        
        public string Nome { get; set; }
                
    }
}