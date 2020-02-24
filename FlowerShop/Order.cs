using System;
using System.Collections.Generic;
using System.Text;
//using Flowershop;

namespace FlowerShop
{
    public class Order : IOrder, IIdentified
    {
        private List<Flower> flowers;
        private bool isDelivered = false;
        public int Id { get; }
        public IOrderDAO DAO;

        // should apply a 20% mark-up to each flower.
        public double Price {
            get {
                return 0;
            }
        }

        public double Profit {
            get {
                return 0;
            }
        }

        public IReadOnlyList<IFlower> Ordered {
            get {
                return flowers.AsReadOnly();
            }
        }

        public IClient Client { get; private set; }

        public Order(IOrderDAO dao, IClient client)
        {
            Id = dao.AddOrder(client);
            this.DAO = dao; ///
        }

        // used when we already have an order with an Id.
        public Order(IOrderDAO dao, IClient client, bool isDelivered = false)
        {
            this.flowers = new List<Flower>();
            this.isDelivered = isDelivered;
            Client = client;
            Id = dao.AddOrder(client);
            this.DAO =dao; ///
        }

        public void AddFlowers(IFlower flower, int n)
        {
            throw new NotImplementedException();
        }
        //Prac2 part 6 (Fix Deliver method)
        public void Deliver()
        {
            //throw new NotImplementedException();
            this.isDelivered = true;
            //this.Order.isdelivered = true;
            //SetDelivered(Order);
            //this.SetDelivered = true;
            DAO.SetDelivered(this); //
        }
    }
}
