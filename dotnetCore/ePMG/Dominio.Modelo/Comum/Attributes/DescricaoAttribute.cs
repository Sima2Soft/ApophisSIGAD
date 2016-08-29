using System;

namespace ePmg.Dominio.Modelo.Comum.Attributes
{
    [Obsolete("Usar o Atributo Ajuda ao invés desse.")]
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    sealed class DescricaoAttribute : Attribute
    {        
        private string descricao;
                
        public DescricaoAttribute (string descricao)
        {
            if (String.IsNullOrEmpty(descricao))
            {
                throw new InvalidOperationException("A Descricao não pode ser vazia!");
            }else{
                this.descricao  = descricao;
            }                                            
        }

        public string Descricao { get; set; }
    }
}