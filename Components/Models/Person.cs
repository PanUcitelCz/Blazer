namespace Blazer.Models{
    public class Person{
        
        public List<(string Jmeno, string Prijmeni, int Vek, string Narozeni, string Bydliste, string Pohlavi)> list { get; set; }

        //Construktor
        public Person(string jmeno, string prijmeni, int vek, string narozeni, string bydliste, string pohlavi){
            list = new List<(string, string, int, string, string, string)>{
                    (jmeno, prijmeni, vek, narozeni,  bydliste, pohlavi)
            }; 
        }
    }
}