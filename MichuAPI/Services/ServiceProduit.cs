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
        public async Task<List<Produit>> EnregistreeProduits(string jsonProduits, string nomIndex)
        {
            ProduitDAL produitDal = new ProduitDAL();
            return await produitDal.EnregistreeProduits(jsonProduits, nomIndex);
        }
    }
}
