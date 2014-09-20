using LojaVirtual.RegraNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace LojaVirtual.Servico
{
    /// <summary>
    /// Summary description for WebServiceProdutos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class WebServiceProdutos : System.Web.Services.WebService
    {
        JavaScriptSerializer js = new JavaScriptSerializer();

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string ListarProdutos()
        {
            try
            {
                
                return js.Serialize(Produto.Listar());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string GetProduto(int id)
        {
            try
            {
                return js.Serialize(Produto.Get(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public void Insert(Produto produto)
        {
            try
            {
                produto.Cadastrar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public void Update(Produto produto)
        {
            try
            {
                produto.Atualizar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public void Delete(int id)
        {
            try
            {
                Produto.Excluir(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
