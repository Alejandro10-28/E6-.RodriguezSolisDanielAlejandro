using System;

namespace Practica_POOE6
{
  public class Operacion
  {
      //Utilize una sobrecarga ala que le agregue el metodo out y se realizaran cada operación
      public void GetDatos(double Cm, out double TR)
      {
        TR = Cm / 100;
      }
      public void GetDatos(double Me,out double MP ,out double IN)
      {
       IN = Me/1;
       MP = IN * 39.37;
      }
       public void GetDatos(double lt, out double MC, out double L,out double K)
      {
       K = 1 * 1000;
       L = lt * 1;
       MC = L / K;      
      }

    
  }
}
