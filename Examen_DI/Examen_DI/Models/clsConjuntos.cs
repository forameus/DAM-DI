using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DI.Models
{    

    public class clsConjuntos
    {
        public ObservableCollection<clsFoto> conjunto { get; set; }
        private Random ran = new Random();

        public clsConjuntos()
        {
            ObservableCollection < clsFoto > fotos = new ObservableCollection<clsFoto>();
           

            fotos.Add(new clsFoto("AR-15", "ms-appx:///Assets/logo.jpg", "Sasha"));
            fotos.Add(new clsFoto("Ballesta", "ms-appx:///Assets/logo.jpg", "Daryl"));
            fotos.Add(new clsFoto("Colt", "ms-appx:///Assets/logo.jpg", "Rick"));
            fotos.Add(new clsFoto("Daryl", "ms-appx:///Assets/logo.jpg", "Ballesta"));
            fotos.Add(new clsFoto("Katana", "ms-appx:///Assets/logo.jpg", "Michonne"));
            fotos.Add(new clsFoto("Lucille", "ms-appx:///Assets/logo.jpg", "Negan"));
            fotos.Add(new clsFoto("Martillo", "ms-appx:///Assets/logo.jpg", "Tyreese"));
            fotos.Add(new clsFoto("Michonne", "ms-appx:///Assets/logo.jpg", "Katana"));
            fotos.Add(new clsFoto("Negan", "ms-appx:///Assets/logo.jpg", "Lucille"));
            fotos.Add(new clsFoto("Rick", "ms-appx:///Assets/logo.jpg","Colt"));
            fotos.Add(new clsFoto("Sasha", "ms-appx:///Assets/logo.jpg", "AR-15"));
            fotos.Add(new clsFoto("Tyreese", "ms-appx:///Assets/logo.jpg", "Martillo"));

            conjunto = new ObservableCollection<clsFoto>();
            int tam= fotos.Count, num, j = tam;
            for (int i = 0; i < j; i++)
            {
                num = ran.Next(0, tam);
                conjunto.Add(fotos.ElementAt(num));
                fotos.RemoveAt(num);
                tam--;
            }

        }

    }
}


/*conjunto.Add(new clsFoto("AR-15", "ms-appx:///Assets/AR-15.jpg", "Sasha"));
           conjunto.Add(new clsFoto("Ballesta", "Daryl"));
           conjunto.Add(new clsFoto("Colt", "Rick"));
           conjunto.Add(new clsFoto("Daryl", "Ballesta"));
           conjunto.Add(new clsFoto("Katana", "Michonne"));
           conjunto.Add(new clsFoto("Lucille", "Negan"));
           conjunto.Add(new clsFoto("Martillo", "Tyreese"));
           conjunto.Add(new clsFoto("Michonne", "Katana"));
           conjunto.Add(new clsFoto("Negan", "Lucille"));
           conjunto.Add(new clsFoto("Rick", "Colt"));
           conjunto.Add(new clsFoto("Sasha", "AR-15"));
           conjunto.Add(new clsFoto("Tyreese", "Martillo"));*/
