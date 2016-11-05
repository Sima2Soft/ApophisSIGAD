using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

using System.Linq;
using Teste.ApophisSigad.Dominio.Entidades;
using System.Collections.Generic;

namespace Teste.ApophisSigad.Dominio
{
    [TestClass]
    public class DominioTeste
    {

        private string teste01 = "Testevalor01";
        private string teste02 = "Testevalor02";
        private Nullable<long> id = 10;
        private Nullable<int> idInt = 5;
        private Nullable<DateTime> data = DateTime.Now;
        private DocumentoArquivistico da;
        private DocumentoArquivistico[] arrayDa;
        private IList<DocumentoArquivistico> iListDa;
        private List<DocumentoArquivistico> listDa;

        [TestMethod]
        public void PegaTodosOsAtributosPorReflection()
        {
            BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

            var atributos = typeof(DominioTeste).GetFields(visibilidadePermitida);
            var valores = typeof(DominioTeste).GetFields(visibilidadePermitida).Select(u => u.GetValue(this)).ToList();            
            
            Assert.IsTrue(atributos != null && valores.Count > 0);

        }
        public void TestaEquals()
        {
            
        }

        public void TestaHashCode()
        {

        }

        public void TestaToString()
        {

        }
    }
}
