using SalesWebMVC.Model;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        // Readonly é uma pratica quando se deseja que o arquivo sirva apenas para leitura, não podendo ser alterado
        private readonly SalesWebMVCContext _context; 

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            // acessa a fonte de dados da tabela vendedores e converte em uma lista
            return _context.Seller.ToList();
        }
    }
}
