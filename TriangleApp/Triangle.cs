using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle()
        {

        }

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        private bool checkTriangle()
        {
            double AB = A.Distance(B);
            double AC = A.Distance(C);
            double BC = B.Distance(C);

            if ((AB + AC > BC) && (AB + BC > AC) && (AC + BC > AB))
            {
                return true;
            }
            return false;
        }

        public double Perimeter()
        {
            double AB = A.Distance(B);
            double AC = A.Distance(C);
            double BC = B.Distance(C);

            if (checkTriangle())
            {
                return AB + AC + BC;
            }

            return 0.0;
        }

        public string Type()
        {
            double AB = A.Distance(B);
            double AC = A.Distance(C);
            double BC = B.Distance(C);

            if (checkTriangle())
            {
                if (AB == AC && AB == BC && AC == BC)
                {
                    return "Tam giac deu!";
                }
                else if (AB == BC || AC == BC || AB == AC)
                {
                    if ((Math.Pow(AB, 2) + Math.Pow(AC, 2) == Math.Pow(BC, 2)) ||
                        (Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2)) ||
                        (Math.Pow(AC, 2) + Math.Pow(BC, 2) == Math.Pow(AB, 2)))
                    {
                        return "Tam giac vuong can!";
                    }
                    else
                    {
                        return "Tam giac can!";
                    }
                }
                else
                {
                    if ((Math.Pow(AB, 2) + Math.Pow(AC, 2) == Math.Pow(BC, 2)) ||
                        (Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2)) ||
                        (Math.Pow(AC, 2) + Math.Pow(BC, 2) == Math.Pow(AB, 2)))
                    {
                        return "Tam giac vuong!";
                    }
                    else
                    {
                        return "Tam giac thuong!";
                    }
                }
            }
            return "Tam gia khong hop le!";
        }

        public Tuple<double, string> Check()
        {
            double AB = Math.Round(A.Distance(B), 2);
            double AC = Math.Round(A.Distance(C), 2);
            double BC = Math.Round(B.Distance(C), 2);

            if ((AB + AC > BC) && (AB + BC > AC) && (AC + BC > AB))
            {
                double perimeter = AB + BC + AC;

                if (AB == AC && AB == BC && AC == BC)
                {
                    return Tuple.Create(perimeter, "Tam giac deu!");
                }
                else if (AB == BC || AC == BC || AB == AC)
                {
                    if (Math.Round(Math.Pow(A.Distance(B), 2) + Math.Pow(A.Distance(C), 2), 2) == Math.Round((Math.Pow(B.Distance(C), 2)), 2) ||
                        Math.Round(Math.Pow(A.Distance(B), 2) + Math.Pow(B.Distance(C), 2), 2) == Math.Round(Math.Pow(A.Distance(C), 2), 2) ||
                        Math.Round(Math.Pow(A.Distance(C), 2) + Math.Pow(B.Distance(C), 2), 2) == Math.Round(Math.Pow(A.Distance(B), 2), 2))
                    {
                        return Tuple.Create(perimeter, "Tam giac vuong can!");
                    }
                    else
                    {
                        return Tuple.Create(perimeter, "Tam giac can!");
                    }
                }
                else
                {
                    if (Math.Round(Math.Pow(A.Distance(B), 2) + Math.Pow(A.Distance(C), 2), 2) == Math.Round((Math.Pow(B.Distance(C), 2)), 2) ||
                        Math.Round(Math.Pow(A.Distance(B), 2) + Math.Pow(B.Distance(C), 2), 2) == Math.Round(Math.Pow(A.Distance(C), 2), 2) ||
                        Math.Round(Math.Pow(A.Distance(C), 2) + Math.Pow(B.Distance(C), 2), 2) == Math.Round(Math.Pow(A.Distance(B), 2), 2))
                    {
                        return Tuple.Create(perimeter, "Tam giac vuong!");
                    }
                    else
                    {
                        return Tuple.Create(perimeter, "Tam giac thuong!");
                    }
                }
            }
            return Tuple.Create(0.0, "Tam giac khong hop le!");
        }
    }
}
