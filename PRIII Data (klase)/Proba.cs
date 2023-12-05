using System;

namespace PRIII_Data__klase_
{
    public class Proba
    {

        

        public static void Pokreni()
        {
            Student hamza = new Student("Hamza","Nesimovic","IB220070");
            int godina = 2023;

            Console.WriteLine(hamza);

            object oHamza = hamza;
            //object oGodina = godina;

            FromObjectToType(oHamza);
            //FromObjectToType(oGodina);

        }

        //test castanja da throwa exception
        private static void FromObjectToType(object x)
        {


            Console.WriteLine((AutoINdekser)x); 
                //(x as Student).PredstaviSe();
            
           
        }
    }





}