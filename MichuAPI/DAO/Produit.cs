using System;
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

        /// <summary>
        /// Fonction d'extraction du prix et de la devise du prix
        /// </summary>
        /// <param name="sPrix"></param>
        public void ExtrairePrixEtDevise(string sPrix)
        {
            //récupération du symbole de la devise 
            char radicalDevise = sPrix[sPrix.Length - 1];
            //récupération du prix en double
            double prix = Double.Parse(sPrix.Substring(0, sPrix.Length - 1));

            this.Prix = prix;
            this.SetDevise(radicalDevise);

        }

        /// <summary>
        /// assignement d'une devide en fonction d'un radical de devise 
        /// </summary>
        /// <param name="radicalDevise">radical de la devise en Char (symbole monétaire)</param>
        private void SetDevise(char radicalDevise)
        {
            switch (radicalDevise)
            {
                case '€':
                    this.Devise = Devise.Euros;
                    break;
                case '$':
                    this.Devise = Devise.Dollar;
                    break;
                default:
                    this.Devise = Devise.Undefined;
                    break;
            }
        }

    }
}
