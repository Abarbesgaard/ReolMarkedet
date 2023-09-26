using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class SalgsLinje
    {


        VareRepository vareRepo = new VareRepository();
        ReolRepository reolRepo = new ReolRepository();

        private List<Object> indkøbsListe = new List<Object>();
        private List<string> indkøbsListeLinjer = new List<string>();

        private decimal salgsSum = 0;

        public SalgsLinje() { }




        public void SætObjectPåIndkøbsListe(string stregKodeEllerId)
        {

            if (reolRepo.HentReol(stregKodeEllerId) != null)
            {
                Reol reol = reolRepo.HentReol(stregKodeEllerId);
                indkøbsListe.Add(reol);
            }
            if (vareRepo.HentVare(stregKodeEllerId) != null)
            {
                Vare vare = vareRepo.HentVare(stregKodeEllerId);
                indkøbsListe.Add((vare));
            }
            else { throw new Exception(); }

        }

        public void GenererSalgsLinje()
        {
            foreach (Object o in indkøbsListe)
            {
                if (o is Vare)
                {
                    Vare vare = (Vare)o;
                    decimal pris = vare.VareBeskrivelse.Pris;
                    decimal rabat = vare.VareRabat.BeregnVærdiAfVareRabat();
                    decimal samlet = pris - rabat;
                    string vareLinjeTekst = $" Vare: {vare.VareBeskrivelse.Navn}, pris: {pris}, evt. rabat: {rabat}, ialt: {samlet} \n";
                    indkøbsListeLinjer.Add(vareLinjeTekst);
                }
                if (o is Reol)
                {
                    Reol reol = (Reol)o;
                    decimal lejepris = reol.ReolBeskrivelse.AntalUdlejningsUger * 100.00m;
                    int antalUger = reol.ReolBeskrivelse.AntalUdlejningsUger;
                    decimal rabat = reol.UdlejningsRabat.BeregnVærdiAfReolRabat();
                    decimal samlet = antalUger * lejepris - rabat;
                    string vareLinjeTekst = $"Reol: {reol.ReolId}, antal uger: {reol.ReolBeskrivelse.AntalUdlejningsUger}, lejepris: {lejepris}, evt. rabat: {rabat}, ialt: {samlet} ";
                    indkøbsListeLinjer.Add((vareLinjeTekst));

                }
                else
                {
                    throw new Exception();
                }
            }
        }

     
        public decimal BeregnSalgsSum()
        {
            foreach (Object o in indkøbsListe)
            {
                if (o is Vare)
                {
                    Vare vare = (Vare)o;
                    decimal pris = vare.VareBeskrivelse.Pris;
                    decimal rabat = vare.VareRabat.BeregnVærdiAfVareRabat();
                    decimal samlet = pris - rabat;
                    salgsSum += samlet;

                }
                if (o is Reol)
                {
                    Reol reol = (Reol)o;
                    decimal lejepris = reol.ReolBeskrivelse.AntalUdlejningsUger * 100.00m;
                    int antalUger = reol.ReolBeskrivelse.AntalUdlejningsUger;
                    decimal rabat = reol.UdlejningsRabat.BeregnVærdiAfReolRabat();
                    decimal samlet = antalUger * lejepris - rabat;
                    salgsSum += samlet;


                }
                else
                {
                    throw new Exception();
                }
            }
            return salgsSum;
        }

        public void HentIndkøbsListeLinjer() 
        {
            foreach(string l in indkøbsListeLinjer) 
            {
                Console.WriteLine(l);
            }
        }
    }
}

