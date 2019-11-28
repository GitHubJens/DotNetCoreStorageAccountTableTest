using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace DotNetCoreStorageTable.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("<ENTER CONNECTION STRING>");

            CloudTableClient client = storageAccount.CreateCloudTableClient();

            CloudTable table = client.GetTableReference("employee");

            table.CreateIfNotExistsAsync();

            var emp = new EmployeeSessionEntity(1, "BillG", 123456.33);

            TableOperation insertOp = TableOperation.Insert(emp);

            table.ExecuteAsync(insertOp);
        }
    }
}
