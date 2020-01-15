using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaultCommonLibrary;

namespace VaultWebService.Services
{
    public interface IVaultDataService
    {
        Task<IEnumerable<VaultDataObject>> GetVaultDataObjects();
        Task<VaultDataObject> GetVaultDataObject(int RecordNumber);
    }

    public class VaultDataService : IVaultDataService
    {
        private List<VaultDataObject> _dataObjects = new List<VaultDataObject>
        {
            new VaultDataObject(1,"test1@gmail.com","test1","pword1"),
            new VaultDataObject(2,"test2@gmail.com","test2","pword2"),
            new VaultDataObject(3,"test3@gmail.com","test3","pword3")
        };

        public async Task<IEnumerable<VaultDataObject>> GetVaultDataObjects()
        {
            return await Task.Run(() => _dataObjects);
        }

        public async Task<VaultDataObject> GetVaultDataObject(int RecordNumber)
        {
            var dObj = await Task.Run(() => _dataObjects.SingleOrDefault((x) => x.RecordNumber == RecordNumber));

            // return null if object not found
            if (dObj == null)
                return null;

            return dObj;
        }
    }
}
