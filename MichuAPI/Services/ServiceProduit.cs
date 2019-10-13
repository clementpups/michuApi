using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elasticsearch.Net;
using MichuAPI.DAL;
using MichuAPI.DAO;

namespace MichuAPI.Services
{
    public class ServiceProduit
    {
        public ServiceProduit()
        {
            
        }
        public async Task<StringResponse> EnregistreeProduits(string jsonProduits, string nomIndex)
        {
            ProduitDAL produitDal = new ProduitDAL();
            return await produitDal.EnregistreeProduits(jsonProduits, nomIndex);
        }
    }
}
