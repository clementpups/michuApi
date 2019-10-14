using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MichuAPI.DAO;
using MichuAPI.Services;
using Nest;

namespace MichuAPI.Controllers
{
    public class ProduitController : ApiController
    {
        /// <summary>
        /// fonction retournant une liste de produits 
        /// </summary>
        /// <param name="nomIndex">nom de l'index ou rechercher les produits</param>
        /// <returns></returns>
        public IEnumerable<Produit> Get(string nomIndex)
        {
            Task<ISearchResponse<Produit>> listeProduitElastic = ServiceProduit.RecupererProduits(nomIndex);
            IEnumerable<Produit> produits = null;
            if (!listeProduitElastic.IsFaulted)
            {
                produits = listeProduitElastic.Result.Documents.AsEnumerable();
            }
            return produits;
        }

        /// <summary>
        /// Post permettant d'enregistré une liste de produits dans un index
        /// </summary>
        /// <param name="jsonProduits">Liste des produits sérialisé au format Json</param>
        /// <param name="nomIndex">Nom de l'index (nom du magasin)</param>
        public void Post([FromBody]string jsonProduits, string nomIndex)
        {
            Task<IndexResponse> enregistement = ServiceProduit.EnregistrerProduits(jsonProduits, nomIndex);
            enregistement.Dispose();
        }

        // PUT: api/Produit/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Produit/5
        public void Delete(int id)
        {
        }
    }
}
