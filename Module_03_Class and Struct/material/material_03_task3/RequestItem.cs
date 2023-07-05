namespace material_03_task3 
{
    public struct RequestItem
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

