using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioWpf
{
    public class Ristorante
    {
        private string _nome;
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; }
        }
        public int Tavoli;
        public int[] PersoneNeiTavoli;
        public Ristorante(string nome, int tavoli)
        {
            Nome = nome;
            if (tavoli < 0) throw new ArgumentOutOfRangeException();
            Tavoli = tavoli;
            PersoneNeiTavoli = new int[tavoli];
        }
        public bool Prenota(string nome, int persone)
        {
            if(persone < 0||persone>4) throw new ArgumentOutOfRangeException("troppe o troppo poche persone");
            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException("inserire un nome valido");
            for (int i = 0; i < PersoneNeiTavoli.Length; i++)
            {
                if (PersoneNeiTavoli[i] == 0) 
                {
                    PersoneNeiTavoli [i] = persone;
                    return true;
                }
            }
            return false;
        }
        /*
         * numero di tavoli prenotati
           numero di tavoli liberi
           numero di coperti ancora disponibili
         */
        public int TavoliPrenotati()
        {
            int counter = 0;
            for (int i = 0; i < PersoneNeiTavoli.Length; i++)
            {
                if (PersoneNeiTavoli[i] != 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public int TavoliLiberi
        {
            get
            {
                return(Tavoli-TavoliPrenotati());
            }
        }
        public int CopertiDisponibili()
        {
            int counter = 0;
            for (int i = 0; i < PersoneNeiTavoli.Length; i++)
            {
                counter += 4-PersoneNeiTavoli[i];
            }
            return counter;
        }
        public override string ToString()
        {
            return _nome.ToUpper() + " numero massimo coperti: " + Tavoli;
        }
    }
}
