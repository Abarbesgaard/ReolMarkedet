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

        public SalgsLinje() {}
    



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
                    decimal rabat = vare.Rabat.VærdiAfRabat();
                    decimal samlet = pris - rabat;
                    string vareLinjeTekst = $" {vare.VareBeskrivelse.Navn}, pris: {pris}, evt. rabat: {rabat}, ialt: {samlet} \n";
                    indkøbsListeLinjer.Add(vareLinjeTekst);
                }
                if (o is Reol)
                {
                    Reol reol = (Reol)o;
                    decimal pris = reol.ReolBeskrivelse.Pris;
                    decimal rabat = reol.Rabat.VærdiAfRabat();
                    decimal samlet = pris - rabat;
                    string vareLinjeTekst = $"Reol: {reol.Id}, pris: {pris}, evt. rabat: {rabat}, ialt: {samlet} ";
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
                    decimal rabat = vare.Rabat.VærdiAfRabat();
                    decimal samlet = pris - rabat;
                    salgsSum += samlet;
                    
                }
                if (o is Reol)
                {
                    Reol reol = (Reol)o;
                    decimal pris = reol.ReolBeskrivelse.Pris;
                    decimal rabat = reol.Rabat.VærdiAfRabat();
                    decimal samlet = pris - rabat;
                    salgsSum += samlet;
                    

                }
                else
                {
                    throw new Exception();
                }
            }
            return salgsSum;
        }

        //public decimal BeregnLejerFortjeneste(decimal salgsSum)
        //{
        //    decimal lejerFortjeneste = salgsSum * 0.85m;
        //    return lejerFortjeneste;
        //}

        //public decimal BeregnKommisionAfSalg(decimal salgsSum) 
        //{
        //    decimal kommisionAfSalg = salgsSum * 0.15m;
        //    return kommisionAfSalg;
        //}







        //public SalgsLinje(Vare vare) 
        //{
        //    Vare = vare;

        //}

        //public SalgsLinje(Reol reol) 
        //{
        //    Reol = reol;
        //}

        //public SalgsLinje(ServiceYdelse serviceYdelse) 
        //{
        //    ServiceYdelse=serviceYdelse;
        //}

        //public Vare HentVare(string stregkode) 
        //{

        //}
    }
}
