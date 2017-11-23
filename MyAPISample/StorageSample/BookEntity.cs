using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSample
{
    public class BookEntity : TableEntity
    {
        public BookEntity()
        {

        }

        public BookEntity(string partitionKey, string rowKey)
            : base(partitionKey, rowKey)
        {

        }

        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
