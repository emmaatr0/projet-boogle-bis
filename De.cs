using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_boogle
{
    public class De
    {
        private Stack<char> ensemble_lettres = new Stack<char>(6);
        private char face_visible;
        public De()
        {
            try
            {
                int compteur = 0;
                Stack<char> lettres_alphabet = new Stack<char>(26);

                string chemin_dossier_lettres = "C:\\Users\\olivi\\Desktop\\Projet Algortihme\\Lettres.txt";
                string[] lignes = File.ReadAllLines(chemin_dossier_lettres);
                foreach (string ligne in lignes)
                {

                    lettres_alphabet.Push(ligne[0]);
                }

                foreach (char lettre in ensemble_lettres)
                {

                    if (lettres_alphabet.Contains(lettre))
                    {
                        compteur++;

                    }
                }
                if (compteur == 6)
                {
                    this.ensemble_lettres = ensemble_lettres;
                }


            }
            catch
            {
                Console.WriteLine("une erreur s'est produite ! ");
            }


        }



    }
}

