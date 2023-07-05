using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_03_task4
{
    public struct Request
    {
        public int Code { get; }
        public DateTime RequestDate { get; }
        public Client Client { get; set; }

        List<RequestItem> RequestItems { get; set; }
        public double TotalPrice { get; private set; }
        public static int Count { get; private set; }

        static Request() { Count = 0; }

        public Request(Client client, List<RequestItem> requestItems)
        {
            Code = ++Count;
            RequestDate = DateTime.Now;
            Client = client;
            RequestItems = requestItems;
            TotalPrice = 0;
            SetTotalPrice();
        }

        public Request(Client client) : this(client, new List<RequestItem>()) { }

        private void SetTotalPrice()
        {
            TotalPrice = 0;
            foreach (var item in RequestItems)
            {
                TotalPrice += (item.ArticleItem.Price ?? 0) * (item.Quantity ?? 0);
                Client.AddExpanse(TotalPrice);
                
            }
        }

        private int? GetRequestItemIndex(Article article)
        {
            if (RequestItems.Count > 0)
            {
                for (int i = 0; i < RequestItems.Count; i++)
                {
                    if (RequestItems[i].ArticleItem.Code == article.Code)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public void AddRequestItem(RequestItem requestItem)
        {
            int? index = GetRequestItemIndex(requestItem.ArticleItem);
            if (index == null)
            {
                RequestItems.Add(requestItem);
            }
            else
            {
                RequestItems[(int)index].Quantity += requestItem.Quantity;
            }
            SetTotalPrice();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Code}\t Requested Date: {RequestDate.ToString()}\nClient: {Client}");
            foreach (var item in RequestItems)
            {
                sb.Append($"\n{item}");
            }
            return sb.ToString();
        }
    }
}
