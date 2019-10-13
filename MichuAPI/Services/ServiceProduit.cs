using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MichuAPI.DAL;
using MichuAPI.DAO;

namespace MichuAPI.Services
{
    public class ServiceProduit
    {
        public ServiceProduit()
        {
            
        }
        public  Task<List<Produit>> EnregistreeProduits(string jsonProduits, string nomIndex)
        {
            return ProduitDAL.EnregistreeProduits(jsonProduits, nomIndex);
        }
    }
}
