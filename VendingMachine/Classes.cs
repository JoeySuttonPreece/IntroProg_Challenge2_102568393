using System;
 
 namespace VendingMachine {
     public abstract class Item {
         public string Name;
         public float Price;
     }
 
     public class Food : Item {
         public int GrossWeight;
 
         public Food(string n, float p, int gw) {
             Name = n;
             Price = p;
             GrossWeight = gw;
         }

         public void Eat() {
             GrossWeight = 0;
         }
     }
 
     public class Perishable : Food {
         public int ExpiryMonth;
         public int ExpiryYear;
 
         public Perishable(string n, float p, int gw, int em, int ey) : base(n, p, gw) {
             ExpiryMonth = em;
             ExpiryYear = ey;
         }
     }
 
     public class NonPerishable : Food {
         public int NetWeight;
 
         public NonPerishable(string n, float p, int gw, int nw) : base(n, p, gw) {
             NetWeight = nw;
         }
     }
 
     //----------------------------------------------------------//
     // Use the Food classes as an example to complete Clothing,
     // Safety and Casual.  Hint:  Think about inheritence
     //----------------------------------------------------------//
     public abstract class Clothing {
         public String Size;
     }
 
     //------- These two are part of the optional task ---------//
     public class Safety { }
 
     public class Casual { }
     //----------------------------------------------------------//
 
 }