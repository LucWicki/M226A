using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226A_B01_1b
{
  class Rechteck
  {
    //static private double M_seiteA;
    //static private double M_seiteB;
    private double m_SeiteA;
    private double m_SeiteB;


    //Standard Konstruktor
    public Rechteck()
    {
      setSeiteA(1);
      setSeiteB(1);
    }

    //Erweiterter Konstruktor
    public Rechteck(double a, double b)
    {
      setSeiteA(a);
      setSeiteB(b);
    }
    public void setSeiteA(double valueA)
    {
      m_SeiteA = valueA;
    }
    public void setSeiteB(double valueB)
    {
      m_SeiteB = valueB;
    }
    public double getFlaeche()
    {
      return m_SeiteA * m_SeiteB;
    }
    //static public void setSeiten(double a, double b)
    //{
    //  M_seiteA = a;
    //  M_seiteB = b;
    //}

    public static double getFlaeche(double a, double b)
    {
      return a * b;
    }
  }
}
