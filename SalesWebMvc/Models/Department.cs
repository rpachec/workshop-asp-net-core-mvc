using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSalles(DateTime initial, DateTime final)
        {
            //soma todas as vendas do departamento chamando o método criado
            //TotalSales na classe Seller de todos os Sellers.

            //retornar a soma de sellers tal que a soma das vendas do seller
            //esteja entre a data inicial e final
            return Sellers.Sum(seller => seller.TotalSales(initial, final));

        }
    }
}
 