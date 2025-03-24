using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaNet.Models;
using LojaNet.DAL;


namespace LojaNet.BLL
{
    public class ClienteDLL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }

            if (string.IsNullOrEmpty(cliente.Id))
            {
                //criar um id - .NET já possui uma ferramenta para esse fim (Guid)
                cliente.Id = Guid.NewGuid().ToString();
            }

            var dal = new ClienteDAL();
            dal.Incluir(cliente);

        }

        public Cliente obterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente obterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> obterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
