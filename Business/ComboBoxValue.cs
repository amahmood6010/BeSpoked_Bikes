namespace BeSpoked_Bikes
{
    class ComboboxValue
    {
        public long HiddenId { get; private set; }
        public string DisplayValue { get; private set; }
        public int? Qty_On_Hand { get; private set; }

        public ComboboxValue(long id, string value, int? qty_On_Hand =0)
        {
            HiddenId = id;
            DisplayValue = value;
            Qty_On_Hand = qty_On_Hand;
        }

        public override string ToString()
        {
            return DisplayValue;
        }

    }

}
