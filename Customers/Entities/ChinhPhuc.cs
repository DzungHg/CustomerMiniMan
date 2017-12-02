using System;


namespace CustomerAccountsUsingRaptorDb.Entities
{
    public class ChinhPhuc
    {
        public ChinhPhuc()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid IdCongTy { get; set; }
        public DateTime HetHan { get; set; }
        public DateTime BatDau { get; set; }
        public string PipeLine { get; set; }
    }
}
