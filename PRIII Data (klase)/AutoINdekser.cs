namespace PRIII_Data__klase_
{
    public class AutoINdekser
    {
        public int[] brojDijelova;

        public AutoINdekser()
        {
            brojDijelova=new int[5];
            for(int i=0; i<5; i++)
            {
                brojDijelova[i]=i;
            }
        }

        //indekser
        public int this[int lokacija] {
            get { return brojDijelova[lokacija]; }
        }
        
    }
}
