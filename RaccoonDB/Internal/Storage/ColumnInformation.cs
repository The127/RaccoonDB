namespace RaccoonDB.Internal.Storage
{
    public class ColumnInformation
    {
        private RaccoonDbDataType _type = RaccoonDbDataType.Unitialized;
                
        public string Name { get; set; } = null!;
        public string TypeName { get; set; } = null!;

        public RaccoonDbDataType Type
        {
            get
            {
                if (_type == RaccoonDbDataType.Unitialized)
                {
                    _type = TypeName.ConvertToDbDataType();
                }
                return _type;
            }
            set => _type = value;
        }

        public bool Unique { get; set; }
        public bool NotNull { get; set; }
        public bool PrimaryKey { get; set; }
        public bool ForeignKey { get; set; }
        public string? ForeignTable { get; set; }
        public string? ForeignColumn { get; set; }
        public bool Auto { get; set; }
    }
}