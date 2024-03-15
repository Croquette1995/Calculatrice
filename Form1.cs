using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationCalculatricePOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1();
            //calculatricePoo1.Nombre1 = 20;

            double n1 = 10;
            double n2 = 20;
            CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1(n1, n2);
            MessageBox.Show("La valeur de nombre1 est de : " + calculatricePoo1.Nombre2.ToString());
        }

        private void btnSomme_Click(object sender, EventArgs e)
        {
            double nbre1;
            double nbre2;
            nbre1 = Convert.ToDouble(txtNombre1.Text);
            nbre2 = Convert.ToDouble(txtNombre2.Text);

            //Transférer nbr1 et nbr2 aux attributs de l'objet (nombre1 et nombre2 qui sont privés)
            //par le biais des SETTER.

            //Pour cela
            // 1) Instancier la classe par le biais du constructeur par défaut

            CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1();
            //CalculatricePoo1 = classe 
            //calculatricePoo1 = objet
            //new = appel au constructeur par défaut

            // Appel au SETTER par le biais de la propriété Nombre1
            // de l'objet calculatricePoo1

            calculatricePoo1.Nombre1 = nbre1;
            calculatricePoo1.Nombre2 = nbre2;

            //A ce stade, les 2 attributs (nombre1 et nombre2) sont nantis
            //des valeurs se trouvant dans les boites de texte (après transtypage).  

            //Appel de la méthode somme
            double resultat = calculatricePoo1.Somme();
            MessageBox.Show("La somme des 2 nombres est : " + resultat.ToString());
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            double nbre1;
            double nbre2;
            nbre1 = Convert.ToDouble(txtNombre1.Text);
            nbre2 = Convert.ToDouble(txtNombre2.Text);

            //Transférer nbr1 et nbr2 aux attributs de l'objet (nombre1 et nombre2 qui sont privés)
            //par le biais des SETTER.

            //Pour cela
            // 1) Instancier la classe par le biais du constructeur par défaut

            CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1();
            //CalculatricePoo1 = classe 
            //calculatricePoo1 = objet
            //new = appel au constructeur par défaut

            // Appel au SETTER par le biais de la propriété Nombre1
            // de l'objet calculatricePoo1

            calculatricePoo1.Nombre1 = nbre1;
            calculatricePoo1.Nombre2 = nbre2;

            //A ce stade, les 2 attributs (nombre1 et nombre2) sont nantis
            //des valeurs se trouvant dans les boites de texte (après transtypage).  

            //Appel de la méthode somme
            double resultat = calculatricePoo1.Soustraction();
            MessageBox.Show("La différence des 2 nombres est : " + resultat.ToString());
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            double nbre1;
            double nbre2;
            nbre1 = Convert.ToDouble(txtNombre1.Text);
            nbre2 = Convert.ToDouble(txtNombre2.Text);

            //Transférer nbr1 et nbr2 aux attributs de l'objet (nombre1 et nombre2 qui sont privés)
            //par le biais du constructeur parametré.

            //Pour cela
            // 1) Instancier la classe par le biais du constructeur par défaut

            CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1(nbre1, nbre2);
            //CalculatricePoo1 = classe 
            //calculatricePoo1 = objet
            //new = appel au constructeur par défaut

            // Appel au SETTER par le biais de la propriété Nombre1
            // de l'objet calculatricePoo1

            calculatricePoo1.Nombre1 = nbre1;
            calculatricePoo1.Nombre2 = nbre2;

            //A ce stade, les 2 attributs (nombre1 et nombre2) sont nantis
            //des valeurs se trouvant dans les boites de texte (après transtypage).  

            //Appel de la méthode produit
            double resultat = calculatricePoo1.Produit();
            MessageBox.Show("Le produit des 2 nombres est : " + resultat.ToString());
        }

        private void btnQuotient_Click(object sender, EventArgs e)
        {
            double nbre1;
            double nbre2;
            nbre1 = Convert.ToDouble(txtNombre1.Text);
            nbre2 = Convert.ToDouble(txtNombre2.Text);

            //Transférer nbr1 et nbr2 aux attributs de l'objet (nombre1 et nombre2 qui sont privés)
            //par le biais du constructeur parametré.

            //Pour cela
            // 1) Instancier la classe par le biais du constructeur par défaut

            CalculatricePoo1 calculatricePoo1 = new CalculatricePoo1(nbre1, nbre2);
            //CalculatricePoo1 = classe 
            //calculatricePoo1 = objet
            //new = appel au constructeur par défaut

            // Appel au SETTER par le biais de la propriété Nombre1
            // de l'objet calculatricePoo1

            calculatricePoo1.Nombre1 = nbre1;
            calculatricePoo1.Nombre2 = nbre2;

            //A ce stade, les 2 attributs (nombre1 et nombre2) sont nantis
            //des valeurs se trouvant dans les boites de texte (après transtypage).  

            //Appel de la méthode division()
            double resultat = calculatricePoo1.Division();
            MessageBox.Show("Le quotient des 2 nombres est : " + resultat.ToString());
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }
    }
}
