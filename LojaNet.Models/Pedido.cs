using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.Models
{
    public class Pedido
    {
        public string Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }

        public class Item
        {
            public int Ordem { get; set; }
            public Produto Produto { get; set; }
            public int Quantidade { get; set; }
            public Decimal Preco { get; set; }

        }

    }
}
