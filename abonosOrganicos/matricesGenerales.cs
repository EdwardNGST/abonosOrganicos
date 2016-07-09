using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace abonosOrganicos
{
    class matricesGenerales
    {
        #region solo_LetrasyNumeros
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsNumber(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsPunctuation(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        #endregion

        public static clsMatriz[] matrizNitrogeno = new clsMatriz[50];
        public static clsMatriz[] matrizCarbono = new clsMatriz[50];
        public void insertarMatrizNitrogeno()
        {
            #region Lista de Materiales Ricos en Nitrogeno
            matrizNitrogeno[0] = new clsMatriz("Algodon:Semillas",95.62,54.96,4.58,12,1.42,2.37);
            matrizNitrogeno[1] = new clsMatriz("Acerrin Verde", 30.68, 16.32, 0.96, 17, 0.08, 0.19);
            matrizNitrogeno[2] = new clsMatriz("Amora Hojas", 86.08, 45.24, 3.77, 12, 1.07, 0);
            matrizNitrogeno[3] = new clsMatriz("Banano Hojas",88.89,49.02,2.58,19,0.19,0);
            matrizNitrogeno[4] = new clsMatriz("Café Afrecho",90.46,50.60,2.30,22,0.42,1.26);
            matrizNitrogeno[5] = new clsMatriz("Cacao : Capsula",91.10,51.84,3.24,16,1.45,3.74);
            matrizNitrogeno[6] = new clsMatriz("Café: Semillas",92.83,52.32,3.27,16,0.39,1.69);
            matrizNitrogeno[7] = new clsMatriz("Acasia: Ramos",93.61,52.35,3.40,15,1.08,2.98);
            matrizNitrogeno[8] = new clsMatriz("Juncea",91.42,50.70,1.95,26,0.40,1.81);
            matrizNitrogeno[9] = new clsMatriz("Cebada: Bagazo",95.07,51.30,5.13,10,1.30,0.15);
            matrizNitrogeno[10] = new clsMatriz("Cuero en Polvo",92.02,43.75,8.74,5,0.22,0.44);
            matrizNitrogeno[11] = new clsMatriz("Estiercol de Cerdos",53.10,29.50,1.86,16,1.06,2.23);
            matrizNitrogeno[12] = new clsMatriz("Estiercol de Aves",52.21,29.01,2.76,11,2.07,1.67);
            matrizNitrogeno[13] = new clsMatriz("Estiercol de Equinos",96.19, 25.50, 1.67, 18, 1.00, 1.19);
            matrizNitrogeno[14] = new clsMatriz("Frijol Canabalia",88.54, 48.45, 2.55, 19, 0.50, 2.41);
            matrizNitrogeno[15] = new clsMatriz("Guandul: Pajas", 55.90, 52.49,1.81,29,0.59,1.14);
            matrizNitrogeno[16] = new clsMatriz("Guandul: Semilla",96.72,54.60,3.64,15,0.82,1.89);
            matrizNitrogeno[17] = new clsMatriz("Guamos Hojas",90.69,50.64,2.11,24,0.19,0.33);
            matrizNitrogeno[18] = new clsMatriz("Lab Lab",88.46,50.16,4.56,11,2.08,0);
            matrizNitrogeno[19] = new clsMatriz("Mucuna Negra: Ramas",90.68,49.28,2.24,22,0.58,2.79);
            matrizNitrogeno[20] = new clsMatriz("Naranja Bagazo",22.58,12.78,0.71,18,0.12,0.41);
            matrizNitrogeno[21] = new clsMatriz("Plumas",88.20,54.20,13.55,4,0.50,0.30);
            matrizNitrogeno[22] = new clsMatriz("Ramio: Residuos",60.64,35.26,3.20,11,3.68,4.02);
            matrizNitrogeno[23] = new clsMatriz("Residuos de Cerveza",95.80,53.04,4.42,12,0.57,0.10);
            matrizNitrogeno[24] = new clsMatriz("Sangre Seca",84.96,47.20,11.80,4,1.20,0.70);
            matrizNitrogeno[25] = new clsMatriz("Tabaco: Residuos",70.92,39.06,2.17,18,0.51,2.78);
            matrizNitrogeno[26] = new clsMatriz("Torta de Algodon",92.40,51.12,5.68,9,2.11,1.33);
            matrizNitrogeno[27] = new clsMatriz("Torta de Maní",95.24,53.55,7.65,7,1.71,1.21);
            matrizNitrogeno[28] = new clsMatriz("Torta de Linaza",94.85,50.94,5.66,9,1.72,1.38);
            matrizNitrogeno[29] = new clsMatriz("Torta de Higuerilla",92.20,54.40,5.44,10,1.91,1.54);
            matrizNitrogeno[30] = new clsMatriz("Torta de Soya",78.40,45.92,6.56,7,0.54,1.54);
            matrizNitrogeno[31] = new clsMatriz("Yuca: Ramas y Hojas",91.64,52.20,4.35,12,0.72,0);
            #endregion
        }
        public void insertarCarbonos()
        {
            #region Lista de Materiales Ricos en Carbono
            matricesGenerales.matrizCarbono[0] = new clsMatriz("Acacia Negra",86.99,53.20,1.40,38,0.10,0);
            matricesGenerales.matrizCarbono[1] = new clsMatriz("Aserrín de Madera",93.45,51.90,0.06,865,0.01,0.01);
            matricesGenerales.matrizCarbono[2] = new clsMatriz("Arroz: Cascarilla",54.55,30.42,0.78,39,0.58,0.49);
            matricesGenerales.matrizCarbono[3] = new clsMatriz("Arroz: Pajas",54.34,30.42,0.78,39,0.58,0.41);
            matricesGenerales.matrizCarbono[4] = new clsMatriz("Avena: Cascarilla",85.00,47.25,0.75,63,0.15,0.53);
            matricesGenerales.matrizCarbono[5] = new clsMatriz("Avena: Pajas", 85.00,47.52,0.66,72,0.33,0.91);
            matricesGenerales.matrizCarbono[6] = new clsMatriz("Algodón: Cascarilla",96.14,53.00,1.06,50,0.23,0.83);
            matricesGenerales.matrizCarbono[7] = new clsMatriz("Banano: Tallos",85.28,46.97,0.77,61,0.15,7.36);
            matricesGenerales.matrizCarbono[8] = new clsMatriz("Bagazo de Caña",96.14,39.59,1.07,37,0.25,0.94);
            matricesGenerales.matrizCarbono[9] = new clsMatriz("Cacao: Cápsula",85.28,48.64,1.28,38,0.41,2.54);
            matricesGenerales.matrizCarbono[10] = new clsMatriz("Café: Pulpa",71.44,30.04,0.86,53,0.17,2.07);
            matricesGenerales.matrizCarbono[11] = new clsMatriz("Cisco de Café",88.68,51.73,0.62,83,0.26,1.96);
            matricesGenerales.matrizCarbono[12] = new clsMatriz("Castaña: Cáscara",89.48,54.76,0.74,74,0.24,0.64);
            matricesGenerales.matrizCarbono[13] = new clsMatriz("Centeno: Cascarilla",96.24,46.92,0.68,69,0.66,0.61);
            matricesGenerales.matrizCarbono[14] = new clsMatriz("Centeno: Pajas",98.04,47.00,0.47,100,0.29,1.01);
            matricesGenerales.matrizCarbono[15] = new clsMatriz("Cebada: Cascarilla",85.00,47.60,0.56,85,0.28,1.09);
            matricesGenerales.matrizCarbono[16] = new clsMatriz("Cebada: Pajas",85.00,47.25,0.75,63,0.22,1.26);
            matricesGenerales.matrizCarbono[17] = new clsMatriz("Estiercol de Ovinos",82.94,46.08,1.44,32,0.74,1.65);
            matricesGenerales.matrizCarbono[18] = new clsMatriz("Estiercol de Bobinos",96.19,53.44,1.67,32,0.68,2.11);
            matricesGenerales.matrizCarbono[19] = new clsMatriz("Frijol: Pajas",94.68,52.16,1.63,32,0.29,1.94);
            matricesGenerales.matrizCarbono[20] = new clsMatriz("Helecho Marranero",95.90,53.41,0.49,109,0.04,0.19);
            matricesGenerales.matrizCarbono[21] = new clsMatriz("Higuerilla: Cápsulas",94.60,62.64,1.18,53,0.30,1.81);
            matricesGenerales.matrizCarbono[22] = new clsMatriz("Maíz: Pajas",96.75,53.76,0.48,112,0.38,1.64);
            matricesGenerales.matrizCarbono[23] = new clsMatriz("Maíz: Olotes",45.20,52.52,0.52,101,0.19,0.90);
            matricesGenerales.matrizCarbono[24] = new clsMatriz("Pasto Gordura",82.20,51.03,0.63,81,0.17,0);
            matricesGenerales.matrizCarbono[25] = new clsMatriz("Pasto Guinea",93.13,49.17,1.49,33,0.34,0);
            matricesGenerales.matrizCarbono[26] = new clsMatriz("Pasto Jaragua",92.38,50.56,0.79,64,0.27,0);
            matricesGenerales.matrizCarbono[27] = new clsMatriz("Pasto Cidrón",88.75,58.84,0.82,62,0.27,0);
            matricesGenerales.matrizCarbono[28] = new clsMatriz("Pasto Millon",90.51,50.40,1.40,36,0.32,0);
            matricesGenerales.matrizCarbono[29] = new clsMatriz("Pasto Mimoso",91.52,52.14,0.66,79,0.26,0);
            matricesGenerales.matrizCarbono[30] = new clsMatriz("Pasto Paspalun",91.60,47.97,1.17,41,0.51,0);
            matricesGenerales.matrizCarbono[31] = new clsMatriz("Piña: Fibras",71.41,39.60,0.90,44,0,0.46);
            matricesGenerales.matrizCarbono[32] = new clsMatriz("Trigo: Cascarilla",85.00,47.60,0.85,56,0.47,0.99);
            matricesGenerales.matrizCarbono[33] = new clsMatriz("Trigo: Pajas",92.40,51.10,0.73,70,0.07,1.28);
            matricesGenerales.matrizCarbono[34] = new clsMatriz("Yuca: Raíces",58.94,32.64,0.34,96,0.30,0.44);
            matricesGenerales.matrizCarbono[35] = new clsMatriz("Yuca: Ramas",95.26,52.40,1.31,40,0.35,0);
            matricesGenerales.matrizCarbono[36] = new clsMatriz("Yuca: Cáscaras",96.07,53.50,0.50,107,0.26,1.27);
            #endregion
        }
    }
}
