using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class Aliment
    {
        private int id;
        private string libelle;
        // Les quantité suivantes sont exprimées pour 100 g de produit
        // Exemple : lipide = 21 ==> 21g de lipide pour 100 g de cet aliment ou 21 % de lipide dans cet aliment
        private double lipide;
        private double glucide;
        private double proteine;
        private double fibre;
        private double sel;
        // Calorie pour 100 g d'aliment
        private double calorie;
        private int v1;
        private string v2;
        private int v3;
        private int v4;
        private int v5;
        private int v6;
        private double v7;
        private int v8;


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
        public double Lipide
        {
            get
            {
                return lipide;
            }
            set
            {
                lipide = value;
            }
        }
        public double Glucide
        {
            get
            {
                return glucide;
            }
            set
            {
                glucide = value;
            }
        }
        public double Proteine
        {
            get
            {
                return proteine;
            }
            set
            {
                proteine = value;
            }
        }
        public double Fibre
        {
            get
            {
                return fibre;
            }
            set
            {
                fibre = value;
            }
        }
        public double Sel
        {
            get
            {
                return sel;
            }
            set
            {
                sel = value;
            }
        }
        public double Calorie
        {
            get
            {
                return calorie;
            }
            set
            {
                calorie = value;
            }
        }

        #region Constructeur
        public Aliment(int id, string libelle, double lipide, double glucide, double proteine, double fibre, double sel, double calorie)
        {
            Id = id;
            Libelle = libelle;
            Lipide = lipide;
            Glucide = glucide;
            Proteine = proteine;
            Fibre = fibre;
            Sel = sel;
            Calorie = calorie;
        }
        #endregion
    }
}
