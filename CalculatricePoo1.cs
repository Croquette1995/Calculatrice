using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCalculatricePOO
{
    class CalculatricePoo1
    {
        // Données de la classe : Attributs ou Champs.
        // Pas d'accès à partir du client.  ---> privé.  

        // On va définir un accesseur du coup. (private ou public)
        // privé : la classe est accessible uniquement dans la classe.
        private double nombre1;
        private double nombre2;

        // Contructeur paramétré et constructeur par défaut.
        // Le constructeur a toujours le nom de la classe.
        //public CalculatricePoo1(double monNombre1, double monNombre2)
        //{
        //    nombre1 = monNombre1;
        //    nombre2 = monNombre2;
        //}

        public CalculatricePoo1(double nombre1, double nombre2)  //Constructeur paramétré meilleur que celui-ci fait avant.
        {
            this.nombre1 = nombre1;  // le nombre 1 qui est au dessus car fait partie de l'objet.
            this.nombre2 = nombre2;  // this = l'instance dans laquelle je me trouve.
        }

        // Recréer le constructeur par défaut car détruit
        // par le constructeur paramétré.  

        public CalculatricePoo1()
        {

        }

        // Pour pouvoir accéder aux attributs, on utilise un mécanisme
        // appelé 'GETTER' et 'SETTER'
        // Plus simplement appelés les propriétés.
        // GETTER = Lecture
        // SETTER = Ecriture

        //Déclaration de la propriété Nombre1
        // Pour une propriété, on reprend le nom de l'attribut mais on le commence avec une majuscule.  

        public double Nombre1
        {
            get
            {
                return nombre1;
            }
            set
            {
                nombre1 = value; //value = mot-clé
            }
        }
        //Déclaration de la propriété Nombre2
        public double Nombre2
        {
            get
            {
                return nombre2;
            }
            set
            {
                nombre2 = value;
            }
        }

        // si on ne se rappelle plus de la structure
        // il faut taper 'propfull' + tab, et la structure des propriétés s'affiche.
        
        // -------------------------------------------------------------------------

        //Maintenant on va créer les actions (méthodes)
        // Une méthode, normalement, est toujours public
        // Comme c'est une méthode c'est soit VOID ou rien (dépend du type) 
        public double Somme()
        {
            double resultat;
            resultat = nombre1 + nombre2;
            return resultat;
        }
        //-------------------------------------------------------------------------
        public double Soustraction()
        {
            double resultat;
            resultat = nombre1 - nombre2;
            return resultat;
        }

        //-------------------------------------------------------------------------
        public double Produit() 
        {
            double resultat;
            resultat = nombre1 * nombre2;
            return resultat;
        }
        //-------------------------------------------------------------------------
        public double Division()
        {
            double resultat;
            resultat = nombre1 / nombre2;
            return resultat;
        }
        //-------------------------------------------------------------------------
    }
}
