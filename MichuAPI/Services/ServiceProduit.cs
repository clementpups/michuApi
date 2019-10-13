using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elasticsearch.Net;
using MichuAPI.DAL;
using MichuAPI.DAO;
using Nest;

namespace MichuAPI.Services
{
    public class ServiceProduit
    {
        public ServiceProduit()
        {
            
        }
        public static async Task<IndexResponse> EnregistrerProduits(string jsonProduits, string nomIndex)
        {
            return await ProduitDAL.EnregistrerProduits(jsonProduits, nomIndex);
        }

        public static async Task<ISearchResponse<Produit>> RecupererProduits(string nomIndex)
        {
            return await ProduitDAL.RecupererProduits(nomIndex);
        }
    }
}
