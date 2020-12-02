using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class Plat
    {
        private int id;
        private string libelle;

        /*
         * Les attributs suivants indiquent le maximum ou le minimun que l'on veut pour ce plat
         * A fixer dans le constructeur
         * 
         * 
         * TODO : ajouter les bornes min, max dans le constructeur
         */
        private double lipideMax;
        private double selMax;
        private double glucideMin;
        private double proteineMin;
        private double fibreMin;
        private List<PlatAliment> aliments = /** TODO : ceci etait à ajouter */ new List<PlatAliment>();

        #region Propriétés

        public List<PlatAliment> Aliments
        {
            get
            {
                return aliments;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Libelle
        {
            get
            {
                return libelle;
            }
            set
            {
                libelle = value;
            }
        }

        public string FicheDescriptive
        {
            get
            {
                /** TODO : A Faire 
                 * 
                 * Il faut afficher la quantité totale de lipide, glucide, ...
                 * 
                 */
                string result = string.Format("Le plat {0}, d'un poids total de {1} g est constitué de: \n ", Id, Poids());

                foreach (PlatAliment platAliment in aliments)
                {
                    result += string.Format("\t\tAliment: {0}, poids: {1} g\n", platAliment.Aliment.Libelle, platAliment.Poids);
                }
                return string.Format("{0}\tTotalProteines : {1} g, TotalGlucides : {2} g, TotalLipides : {3} g, TotalCalorie : {4} kcal", result, TotalProteines(), TotalGlucides(), TotalLipides(), TotalCalorieLinq());
            }
        }
        #endregion

        #region Constructeur
        public Plat(int id, string libelle)
            : this(id, libelle, double.MaxValue, double.MaxValue, 0, 0, 0)
        {
            /** TODO : A faire 
             * Aucune contrainte sur les bornes min, max
             */

        }
        public Plat(int id, string libelle, double lipideMax, double selMax, double glucideMin,
                    double proteineMin,double fibreMin)
        {
            /** TODO : A faire */
            Id = id;
            Libelle = libelle;
            this.lipideMax = lipideMax;
            this.selMax = selMax;
            this.glucideMin = glucideMin;
            this.proteineMin = proteineMin;
            this.fibreMin = fibreMin;

        }
        #endregion

        #region CRUD
        // Ajouter un platAliment : le C dans CRUD
        public bool AjouterPlatAliment(PlatAliment platAliment)
        {
            if (platAliment == null)
                return false;

            /** TODO : corriger la recherche */
            PlatAliment p = RechercherPlatAliment(platAliment.Aliment.Id);
            if (p != null)
                return false; // Le platAliment existe déjà

            /** TODO : Ajouter uniquement si la contrainte des bornes min, max sont respectées */
            // Si le lipide Max et le sel max sont respects on ajoute le platAliment
            if (((TotalLipides() + (platAliment.Aliment.Lipide * platAliment.Poids / 100)) < lipideMax) &&
                 (TotalSels() + (platAliment.Aliment.Sel * platAliment.Poids / 100)) < selMax)
            {
                aliments.Add(platAliment);
                return true;
            }

            return false;
        }

        // Supprimer un platAliment : le D dans CRUD
        public bool SupprimerPlatAliment(PlatAliment platAliment)
        {
            /** TODO : corriger la suppression 
            return SupprimerPlatAliment(platAliment.Id);
            */
            return SupprimerPlatAliment(platAliment.Aliment.Id);
        }
        public bool SupprimerPlatAliment(int id)
        {
            PlatAliment p = RechercherPlatAliment(id);
            if (p == null)
                return false; // Le platAliment n'existe pas

            aliments.Remove(p);
            return true;
        }

        // Modifier un platAliment : le U dans CRUD
        public bool ModifierPlatAliment(PlatAliment platAliment)
        {
            if (platAliment == null)
                return false;

            /** TODO : corriger la recherche */
            PlatAliment platAlimentAModifier = RechercherPlatAliment(platAliment.Aliment.Id);
            if (platAlimentAModifier == null)
                return false; // Le platAliment n'existe pas

            // On fait des modification

            /** TODO : Faire la modification de la quantité */
            platAlimentAModifier.Poids = platAliment.Poids;

            return true;
        }
        #endregion

        #region Méthodes de recherche
        public PlatAliment RechercherPlatAliment(PlatAliment platAliment)
        {
            if (platAliment == null || platAliment.Aliment == null)
                return null;

            return RechercherPlatAliment(platAliment.Aliment.Id);
        }

        public PlatAliment RechercherPlatAliment(int id)
        {
            /** TODO : corriger la recherche */

            return aliments.Find(delegate (PlatAliment PlatAliment)
            {
                /** TODO : Faire la recherche de l'aliment */
                return PlatAliment.Aliment.Id == id;
            });
        }
        #endregion

        /** TODO : faire toutes les méthodes suivantes : */

        public double TotalLipides()
        {
            double total = 0;
            foreach(PlatAliment platAliment in aliments)
            {
                // Total = qté de lipide de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Lipide * platAliment.Poids) / 100;
            }
            return total;
        }
        public double TotalGlucides()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de Glucide de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Glucide * platAliment.Poids) / 100;
            }
            return total;
        }
        public double TotalProteines()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de Proteine de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Proteine * platAliment.Poids) / 100;
            }
            return total;
        }
        public double TotalFibres()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de Fibre de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Fibre * platAliment.Poids) / 100;
            }
            return total;
        }
        public double TotalSels()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de Sel de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Sel * platAliment.Poids) / 100;
            }
            return total;
        }
        public double TotalCalorie()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de Calorie de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += (platAliment.Aliment.Calorie * platAliment.Poids) / 100;
            }
            return total;
        }
        // AUTRE EXEMPLE POUR TotalCalorie
        public double TotalCalorieLinq()
        {
            double total = 0;
            aliments.ForEach(plat => total += (plat.Aliment.Calorie * plat.Poids / 100));
            return total;
        }

        public double Poids()
        {
            double total = 0;
            foreach (PlatAliment platAliment in aliments)
            {
                // Total = qté de lipide de ce plat * poids du plat / 100 (pour avoir un % la qté étant exprimée pour 100g
                total += platAliment.Poids;
            }
            return total;
        }
    }
}
