using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Threading.Tasks;

namespace StorageSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await TableStorageSampleAsync();
        }

        private static async Task TableStorageSampleAsync()
        {
            CloudStorageAccount account = CloudStorageAccount.Parse("use your azure storage connection");
            CloudTableClient tableClient = account.CreateCloudTableClient();
            CloudTable booksTable = tableClient.GetTableReference("books");
            bool created = await booksTable.CreateIfNotExistsAsync();
            BookEntity myBook = new BookEntity("wroxpress", Guid.NewGuid().ToString())
            {
                Title = "Professional C# 6",
                Publisher = "Wrox Press"
            };
            TableOperation insertOperation = TableOperation.Insert(myBook);
            TableResult result = await booksTable.ExecuteAsync(insertOperation);
        }
    }
}
