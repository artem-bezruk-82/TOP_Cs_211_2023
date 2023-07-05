namespace material_03_task4
{
    public class RequestItem
    {
        public Article ArticleItem { get; set; }
        public int? Quantity { get; set; }

        public RequestItem(Article articleItem, int? quantity)
        {
            ArticleItem = articleItem;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"[{ArticleItem}] - {Quantity}";
        }
    }
}

