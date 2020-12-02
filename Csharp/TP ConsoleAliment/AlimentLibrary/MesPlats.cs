using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class MesPlats
    {
        #region Attributs
        private List<Plat> listePlats = new List<Plat>();
        #endregion

            #region CRUD
        // Ajouter un plat : le C dans CRUD
        public bool AjouterPlat(Plat plat)
        {
            if (plat == null)
                throw new Exception();

            Plat p = RechercherPlat(plat.Id);
            if (p != null)
                return false; // Le plat existe déjà

            listePlats.Add(plat);
            return true;
        }

        // Supprimer un plat : le D dans CRUD
        public bool SupprimerPlat(Plat plat)
        {
            return SupprimerPlat(plat.Id);
        }
        public bool SupprimerPlat(int id)
        {
            Plat p = RechercherPlat(id);
            if (p == null)
                return false; // Le plat n'existe pas

            listePlats.Remove(p);
            return true;
        }

        // Modifier un plat : le U dans CRUD
        public bool ModifierPlat(Plat plat)
        {
            if (plat == null)
                return false;
            /*if (plat == null)
                throw new Exception();*/

            Plat platAModifier = RechercherPlat(plat.Id);
            if (platAModifier == null)
                return false; // Le plat n'existe pas

            // On fait des modification du poids de chaque aliment
            /** TODO : A faire */
            foreach(PlatAliment platAliment in plat.Aliments)
            {
                PlatAliment platAlimentAModifier = platAModifier.RechercherPlatAliment(platAliment);
                if (platAlimentAModifier != null)
                {
                    platAlimentAModifier.Poids = platAliment.Poids;
                }
            }
            return true;
        }
        #endregion

        #region Méthodes de recherche
        public Plat RechercherPlat(int id)
        {
            return listePlats.Find(delegate (Plat Plat)
            {
                return Plat.Id == id;
            });
        }

        public List<Plat> RechercherPlatsLibelleCommencePar(string libelle)
        {
            return listePlats.FindAll(delegate (Plat plat)
            {
                return plat.Libelle.StartsWith(libelle,
                            StringComparison.InvariantCultureIgnoreCase);
            });
        }

        public List<Plat> RechercherPlatsParCalorie(double min, double max)
        {
            /** TODO : A faire 
             * 
             * Retourne tous les plats dont les calories sont dans l'intervalle indiqué
             * 
             **/
            return listePlats.FindAll(delegate (Plat plat)
            {
                return plat.TotalCalorie() >= min && plat.TotalCalorie() < max;
            });
        }
        #endregion


        public void AfficherPlats()
        {
            foreach (Plat p in listePlats)
            {

                Console.WriteLine(p.FicheDescriptive);
            }
        }
    }
}
