namespace ePmg.Dominio.Modelo.Comum.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class AjudaAttribute : System.Attribute
    {        
        private string nome;
        private string descricao;

        public AjudaAttribute(string nome, string descricao)
        {

        }   

        public AjudaAttribute(string nome)
        {

        }   
                                 
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}