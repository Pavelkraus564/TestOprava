using System.Security.Cryptography.X509Certificates;

namespace TestOprava1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {



        }
    }
     public class Trek 
    {
        public int length;
        public string Difficulty;
        public string BogFactor {  get; set; } 

        public Trek(int length, string difficulty)  
        {  
         this.length = length;
         this.Difficulty = difficulty;
         
        
        
        }
         
        //vrátí čas na trati pokud avgSpeed je 50km za hodinu
        public void GetTime(int AvgSpeed=5)   // vrat čas ztávený na trati 
        {

            int length = 200;
            int CasNatreku = 200 / 5;
            Console.WriteLine(CasNatreku);





            /* int čas = 40; // 40 hodin   
            int length = 200; // 200 hodin 
            int avgSpeed = length / čas ;  
             */
            //average speed je z delky děleno casem  delka / čas 




        }
        public void PrintInfo()  
        {
           
            
            
            string delka ="délka je 200km" ;
            string obtížnost = "medium"; // neboli Difficulty 
            string bazinatost = " bažinatost je velice vysoká"; 
        }
    
    
    }
     // 5km za hodinu
     // 10 km za hodinu 

   
    
     
    


}