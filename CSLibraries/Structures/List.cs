using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLibraries.Structures
{
    public class List<T>
    {
        private T[] content;

        /// <summary>
        /// Initialise une nouvelle instance de la classe List<T> qui est vide et possède la capacité initiale par défaut.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public List()
        {
            content = new T[20];
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe List<T> qui est vide et a la capacité initiale spécifiée.
        /// </summary>
        /// <param name="size">Size of the new list</param>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public List(int size)
        {
            content = new T[size];
        }

        /// <summary>
        /// Obtient ou définit le nombre total des éléments que la structure de données interne peut contenir sans redimensionnement.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public int Capacity
        {
            get => default(int);
            set
            {
            }
        }


        /// <summary>
        /// Obtient le nombre d'éléments contenus dans le List<T>.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public int Count
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Obtient ou définit l'élément au niveau de l'index spécifié.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public T this[Int32 index]
        {
            get => default(T);
            set
            {
            }
        }

        /// <summary>
        /// Ajoute un objet à la fin de la List<T>.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public void Add(T newItem)
        {
            throw new System.NotImplementedException();
        }


    }
}
