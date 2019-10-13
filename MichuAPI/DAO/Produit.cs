using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MichuAPI.DAO
{
    /// <summary>
    /// classe représentant un produit
    /// </summary>
    public class Produit
    {
        public Produit()
        {
        }

        public string Nom { get; set; }
        public double Prix { get; set; }
        public Devise Devise { get; set; }
        public string PrixPoid { get; set; }
        public string QuantiteeContionnement { get; set; }

        public static List<Produit> DeserialiserProduits( string jsonProduits)
        {
            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(jsonProduits);
            return produits;
        }
        

    }
}
