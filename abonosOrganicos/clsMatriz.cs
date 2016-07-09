using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace abonosOrganicos
{
    class clsMatriz
    {
        private string material;
        private double mo;
        private double c;
        private double n;
        private double cn;
        private double po;
        private double ko;
        
        public clsMatriz()
        {
            material = "";
            mo = 0.0;
            c = 0.0;
            n = 0.0;
            cn = 0.0;
            po = 0.0;
            ko = 0.0;
        }
        public clsMatriz(string Material, double MO, double C, double N, double CN, double PO, double KO)
        {
            material = Material;
            mo = MO;
            c = C;
            n = N;
            cn = CN;
            po = PO;
            ko = KO;
        }
        #region material
        public void setMaterial(string mat)
        {
            this.material = mat;
        }
        public string getMaterial()
        {
            return material;
        }
        #endregion
        #region mo
        public void setMO(double MO)
        {
            this.mo = MO;
        }
        public double getMO()
        {
            return mo;
        }
        #endregion
        #region c
        public void setC(double C)
        {
            this.c = C;
        }
        public double getC()
        {
            return c;
        }
        #endregion
        #region n
        public void setN(double N)
        {
            this.n = N;
        }
        public double getN()
        {
            return n;
        }
        #endregion
        #region cn
        public void setCN(double CN)
        {
            this.cn = CN;
        }
        public double getCN()
        {
            return cn;
        }
        #endregion
        #region po
        public void setPO(double PO)
        {
            this.po = PO;
        }
        public double getPO()
        {
            return po;
        }
        #endregion
        #region ko
        public void setKO(double KO)
        {
            this.ko = KO;
        }
        public double getKO()
        {
            return ko;
        }
        #endregion
    }
}
