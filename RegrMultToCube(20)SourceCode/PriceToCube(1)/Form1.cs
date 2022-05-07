using AnimatedGif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPlot.Plotly;

namespace PriceToCube_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GerarImagem_Click(object sender, EventArgs e)
        {

        }

        int PeriodosPraTraz = 10;
        int PeriodosPraTraz2 = 10;
        int PeriodosPraFrente = 5;

        List<string> listHorario = new List<string>();


        List<double> listDOL = new List<double>();
        List<double> listDOL0 = new List<double>();
        List<double> listMIX = new List<double>();

        List<double> listNewPond = new List<double>();
        List<double> listNewPond0 = new List<double>();


        List<double> listMXN = new List<double>();
        List<double> listES = new List<double>();
        List<double> list6E = new List<double>();
        List<double> listCL = new List<double>();
        List<double> listAUD = new List<double>();
        List<double> listWIN = new List<double>();

        List<List<double>> listCorretoras = new List<List<double>>();

        //listCorretoras.ad = new List<double>();
        List<double> listCorretora1 = new List<double>();
        List<double> listCorretora2 = new List<double>();
        List<double> listCorretora3 = new List<double>();
        List<double> listCorretora4 = new List<double>();
        List<double> listCorretora5 = new List<double>();
        List<double> listCorretora6 = new List<double>();
        List<double> listCorretora7 = new List<double>();
        List<double> listCorretora8 = new List<double>();
        List<double> listCorretora9 = new List<double>();
        List<double> listCorretora10 = new List<double>();
        List<double> listCorretora11 = new List<double>();
        List<double> listCorretora12 = new List<double>();




        double qtdTradesTotalMes = 0;
        double somaPtsTotalMes = 0;

        int row0 = -20;
        int col0 = -20;
        int rowsCount = 40;
        int colsCount = 40;

        List<string> tradesInputsRegistrados = new List<string>();


        private void PriceToCube_Click(object sender, EventArgs e)
        {
            listCorretoras.Add(listCorretora1);
            listCorretoras.Add(listCorretora2);
            listCorretoras.Add(listCorretora3);
            listCorretoras.Add(listCorretora4);
            listCorretoras.Add(listCorretora5);
            listCorretoras.Add(listCorretora6);
            listCorretoras.Add(listCorretora7);
            listCorretoras.Add(listCorretora8);
            listCorretoras.Add(listCorretora9);
            listCorretoras.Add(listCorretora10);
            listCorretoras.Add(listCorretora11);
            listCorretoras.Add(listCorretora12);


            PeriodosPraTraz = Convert.ToInt32(textBoxPerTraz.Text);
            PeriodosPraTraz2 = Convert.ToInt32(textBoxPerTraz2.Text);
            PeriodosPraFrente = Convert.ToInt32(textBox2.Text);
            double varTemp = Convert.ToDouble(textBoxVarTemp.Text);
            double varTemp2 = Convert.ToDouble(textBoxVarTemp2.Text);
            double txtBxES = Convert.ToDouble(textBoxES.Text);
            double txtBxCL = Convert.ToDouble(textBoxCL.Text);
            double txtBx6E = Convert.ToDouble(textBox6E.Text);
            double txtBxMXN = Convert.ToDouble(textBoxMXN.Text);
            double txtBxAUD = Convert.ToDouble(textBoxAUD.Text);
            double txtBxWIN = Convert.ToDouble(textBoxWIN.Text);
            double ptsStopLoss = Convert.ToDouble(textBoxPtsStopLoss.Text);
            double ptsStopGain = Convert.ToDouble(textBoxPtsStopGain.Text);
            double spreadMaldito = Convert.ToDouble(textBoxSpread.Text);

            double[,] matrixSomaPtsTrade = new double[rowsCount, colsCount];
            double[,] matrixQtdTrades = new double[rowsCount, colsCount];
            double[,] matrixMedia = new double[rowsCount, colsCount];
            double[,] matrixMediaQtdTrades = new double[rowsCount, colsCount];


            double[] xArray = new double[matrixSomaPtsTrade.GetLength(0) * matrixSomaPtsTrade.GetLength(1)*30];
            double[] yArray = new double[matrixSomaPtsTrade.GetLength(0) * matrixSomaPtsTrade.GetLength(1)*30];
            double[] zArray = new double[matrixSomaPtsTrade.GetLength(0) * matrixSomaPtsTrade.GetLength(1)*30];
            List<string> clrs1 = new List<string>();
            List<double> sizes1 = new List<double>();
            List<double> listPtsTrade = new List<double>();


            int z = 0;
            int numDiasExecutados = 0;

            string mes = textBoxMes.Text  ;

            tradesInputsRegistrados.Clear();

            for (int iDia = Convert.ToInt32( numericDiaInicial.Value)  ; iDia < Convert.ToInt32(numericDiaFinal.Value) ; iDia++)
            {
                numDiasExecutados++;

                for (int r = 0; r < rowsCount; r++)
                {
                    for (int c = 0; c < colsCount; c++)
                    {
                        matrixSomaPtsTrade[r, c] = 0;
                        matrixQtdTrades[r, c] = 0;
                    }
                }

                listHorario.Clear();

                listDOL.Clear();
                listDOL0.Clear();
                listMIX.Clear();

                listNewPond.Clear();
                listNewPond0.Clear();

                listES.Clear();
                listMXN.Clear();
                list6E.Clear();
                listAUD.Clear();
                listCL.Clear();
                listWIN.Clear();


                for (int i = 0; i < 12; i++)
                {
                    
                    listCorretoras[i].Clear();
                }

                //for (int iClean = 0; iClean < matrixSomaPtsTrade.GetLength(0) * matrixSomaPtsTrade.GetLength(1) * 5; iClean++)
                //{
                //    xArray[iClean] = 0;
                //    yArray[iClean] = 0;
                //    zArray[iClean] = 0;
                //}
                while (!File.Exists(mes + iDia.ToString("D2") + ".csv"))
                {
                    iDia++;

                    if(iDia > 35)
                    {
                        break;
                    }
                }




                using (var reader = new StreamReader(mes + iDia.ToString("D2") + ".csv"))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listHorario.Add(values[0]);

                        //listDOL.Add(Convert.ToDouble(values[6]));
                        listDOL0.Add(Convert.ToDouble(values[6]));
                        //listMIX.Add(Convert.ToDouble(values[120]));

                        listES.Add(Convert.ToDouble(values[4]     ) );
                        listMXN.Add(Convert.ToDouble(values[5]    )   );
                        list6E.Add(Convert.ToDouble(values[2]     )   );
                        listAUD.Add(Convert.ToDouble(values[1]    )  );
                        listCL.Add(Convert.ToDouble(values[3]     )   );
                        listWIN.Add(Convert.ToDouble(values[7]    )   );

                        for (int i = 0; i < 12; i++)
                        {
                            listCorretoras[i].Add(Convert.ToDouble(values[8+i])  );
                        }

                    }
                }



                for (int i = 1; i < listES.Count; i++)
                {
                    listNewPond0.Add(
                       ( listES[i]  -  listES[i - 1 ]   ) * txtBxES +
                       ( listMXN[i] - listMXN[i - 1 ]   ) * txtBxMXN +
                       ( list6E[i]  -  list6E[i - 1 ]   ) * txtBx6E +
                       ( listAUD[i] - listAUD[i - 1 ]   ) * txtBxAUD +
                       ( listCL[i]  -  listCL[i - 1 ]   ) * txtBxCL +
                       ( listWIN[i] - listWIN[i - 1 ]   ) * txtBxWIN
                        );

                    listDOL.Add(
                       ( listDOL0[i] - listDOL0[i - 1] ) * 1000
                        );
                }

                listHorario.RemoveAt(0);

                for (int i = 0; i < 12; i++)
                {
                    listCorretoras[i].RemoveAt(0);
                }
                //List<double> listAgr = Agr1_Click(iDia + mes.Split('.')[0] + "Agr.csv");

                //List<double> listAgr = new List<double>();
                //using (var reader = new StreamReader(iDia + mes.Split('.')[0] + "AgrSaved.csv"))
                //{

                //    while (!reader.EndOfStream)
                //    {
                //        var line = reader.ReadLine();
                //        var values = line.Split(',');

                //        listAgr.Add(Convert.ToDouble(values[0]));


                //    }
                //}

                int autoVar = Convert.ToInt32(textBoxAddAutoVar.Text);

                if (autoVar > 0)
                {

                    for (int i = 0; i < listNewPond0.Count; i++)
                    {
                        if (i > autoVar)
                        {
                            double somaAutoVar = 0;
                            for (int iAutoVar = 0; iAutoVar < autoVar; iAutoVar++)
                            {
                                somaAutoVar += listNewPond0[i - iAutoVar ] ;

                            }
                            listNewPond.Add(somaAutoVar/autoVar);
                        }
                        else
                        {
                            listNewPond.Add(listNewPond0[i]);
                        }
                        //listNewPond[i] = listNewPond[i] / Convert.ToDouble(autoVar);
                    }
                }
                else
                {
                    listNewPond = listNewPond0.ToList();
                }




                for (int r = 0; r < rowsCount ; r++)
                {
                        double somaPts = 0;
                        double somaPtsTrade = 0;
                        double qtdTrades = 0;
                        //double qtdAcertos = 0;

                    for (int c = 0; c < colsCount ; c++)
                    {
                            somaPts = 0;
                            somaPtsTrade = 0;
                            qtdTrades = 0;

                        for (int i = PeriodosPraTraz; i < listDOL.Count - PeriodosPraFrente - 1; i++)
                        {
                            double passadoMix = 0;
                            double passadoDol = 0;
                            for (int iPassado = 0; iPassado < PeriodosPraTraz; iPassado++)
                            {
                                passadoMix += listNewPond[i - iPassado ];
                                passadoDol += listDOL[i - iPassado ];
                            }

                            //double passadoAgr = 0;
                            //for (int iPassado = 0; iPassado < PeriodosPraTraz; iPassado++)
                            //{
                            //    passadoAgr += listAgr[i - iPassado];

                            //}


                            double passadoMix2 = 0;
                            double passadoDol2 = 0;
                            if (PeriodosPraTraz2 > 0 )
                            {
                                for (int iPassado = 0; iPassado < PeriodosPraTraz2; iPassado++)
                                {
                                    passadoMix2 += listNewPond[i - iPassado];
                                    passadoDol2 += listDOL[i - iPassado];
                                }
                            }






                            //double futuroDol = listDOL[i + 1 + PeriodosPraFrente] - listDOL[i + 1];

                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol < r + row0;

                            bool condicaoCompra = passadoMix  > c + col0 && passadoDol < r + row0;

                            // Funcionando na nova ponderacao:
                            //bool condicaoCompra = passadoMix - passadoDol > c + col0 && passadoDol < r + row0;

                            //double dvdir = 6.0;
                            //bool condicaoCompra = passadoMix > Convert.ToDouble(Convert.ToDouble(c) / dvdir) + Convert.ToDouble( Convert.ToDouble(col0)/ dvdir) && passadoDol < Convert.ToDouble(Convert.ToDouble(r) / dvdir) + Convert.ToDouble(Convert.ToDouble(row0) / dvdir);


                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol < r + row0;


                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol < r + row0 && passadoAgr > 300;


                            //Console.WriteLine(passadoAgr);


                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol < r + row0 && passadoAgr > 100;

                            //Console.WriteLine("passadoAgr: " + passadoAgr);

                            //bool condicaoCompra = passadoMix > 5 && passadoDol > c + col0 && passadoAgr < (r + row0) * 10;


                            //bool condicaoCompra = passadoMix < -14 && passadoDol < -10 && passadoMix2 < c + col0 && passadoDol2 < r + row0;
                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol < r + row0 && passadoMix2 > c + col0 && passadoDol2 > r + row0;
                            //bool condicaoCompra = passadoMix > 5 && passadoDol > 12 && passadoMix2 > c + col0 && passadoDol2 < r + row0;


                            //bool condicaoCompra = passadoMix < -14 && passadoDol < -10 && passadoDol - passadoMix < c + col0 && passadoDol - passadoMix > r + row0;
                            //bool condicaoCompra = passadoMix < -14 && passadoDol < -10 && passadoDol - passadoMix > c + col0 && passadoDol - passadoMix > r + row0;

                            //bool condicaoCompra = passadoMix < -5 && passadoDol < -9 && passadoDol - passadoMix > c + col0 && passadoDol - passadoMix > r + row0;
                            //bool condicaoCompra = passadoMix < -5 && passadoDol < -9 && passadoDol - passadoMix < c + col0 && passadoDol - passadoMix > r + row0;

                            //bool condicaoCompra = passadoMix < -5 && passadoDol < -9 && passadoMix > c + col0 && passadoDol < r + row0;
                            //bool condicaoCompra = passadoMix < 6 && passadoDol < -11 && passadoMix > c + col0 && passadoDol > r + row0;

                            //bool condicaoCompra = passadoMix > c + col0 && passadoDol > r + row0;


                            //bool condicaoCompra = passadoMix < c + col0 && passadoDol > r + row0;

                            //bool condicaoCompra = passadoMix > varTemp && passadoDol < r + row0 && passadoDol - passadoMix > c + col0 && passadoDol - passadoMix < c + col0 + 2;

                            double futuroDol = 0;
                            double[] arrayInputLSTM = new double[14*PeriodosPraTraz];


                            for (int iFuturo = 0; iFuturo < PeriodosPraFrente; iFuturo++)
                            {
                                futuroDol += listDOL[i + iFuturo + 1];

                            }
                            futuroDol = futuroDol - spreadMaldito;


                            //////for (int iFuturo = 0; (futuroDol > -ptsStopLoss && i + iFuturo + 2 < listDOL.Count) || (futuroDol < ptsStopGain && i + iFuturo + 2 < listDOL.Count); iFuturo++)
                            //////{
                            //////    futuroDol += listDOL[i + iFuturo + 1];

                            //////}



                            //////for (int iFuturo = 0; Math.Abs(futuroDol) < ptsStopGain && i + iFuturo + 2 < listDOL.Count; iFuturo++)
                            //////{
                            //////    futuroDol += listDOL[i + iFuturo + 1];
                            //////}

                            if (condicaoCompra)
                            {
                                ////for (int iFuturo = 0; (futuroDol > -ptsStopLoss+1.5 && futuroDol < ptsStopGain+1.5) && i + iFuturo + 2 < listDOL.Count; iFuturo++)
                                ////{
                                ////    futuroDol += listDOL[i + iFuturo + 1];
                                ////}


                                ////for (int iFuturo = 0;  i + iFuturo + 2 < listDOL.Count; iFuturo++)
                                //for (int iFuturo = 0; true; iFuturo++)
                                //{
                                //    //(futuroDol > -ptsStopLoss + 1.5 && futuroDol < ptsStopGain + 1.5) &&
                                //    futuroDol += listDOL[i + iFuturo + 1];

                                //    if (!(i + iFuturo + 2 < listDOL.Count))
                                //    {
                                //        futuroDol = futuroDol - spreadMaldito;
                                //        break;
                                //    }

                                //    if (!(futuroDol > -ptsStopLoss + spreadMaldito))
                                //    {
                                //        futuroDol = -10;
                                //        break;
                                //    }
                                //    if (!(futuroDol < ptsStopGain + spreadMaldito))
                                //    {
                                //        futuroDol = 10;
                                //        break;
                                //    }

                                //}
                                if (futuroDol> 100)
                                {
                                    Console.WriteLine("stop");
                                }


                                for (int iPasado = 0; iPasado < PeriodosPraTraz; iPasado++)
                                {
                                    arrayInputLSTM[PeriodosPraTraz - iPasado - 1] = listDOL[i - iPasado];
                                    arrayInputLSTM[2 * PeriodosPraTraz - iPasado - 1] = listNewPond[i - iPasado];

                                    for (int iCorr = 0; iCorr < 12; iCorr++)
                                    {
                                        arrayInputLSTM[(3+iCorr) * PeriodosPraTraz - iPasado - 1] = listCorretoras[iCorr][i - iPasado];

                                    }
                                }
                            }





                            somaPts += condicaoCompra ? futuroDol : 0;
                            qtdTrades += condicaoCompra ? 1 : 0;

                            // iDia + mes == "20jan.csv" &&
                            //if ( -6 <= c + col0 && c + col0 <= -2 && -15 <= r + row0 && r + row0 <= -10)

                            //if (c + col0 == -3 && r + row0 == -3)
                            if (c + col0 == -5 && r + row0 == -10)
                            {
                                if (condicaoCompra)
                                {

                                    string arrayInputStg = "";

                                    foreach (double retorno in arrayInputLSTM)
                                    {
                                        arrayInputStg += "; " + retorno.ToString("F");
                                    }


                                    tradesInputsRegistrados.Add(    ( futuroDol ).ToString("F") +    arrayInputStg  + ";" + listHorario[i]  );


                                    //if (futuroDol>9 || futuroDol < -9)
                                    //{

                                    //tradesInputsRegistrados.Add( 
                                    //    (futuroDol > 9 ? 1 : futuroDol < -9 ? 0 : -99).ToString("F") +
                                    //    arrayInputStg
                                    //    );
                                    //}

                                }
                            }
                        }

                        if (qtdTrades > 0)
                        {
                            somaPtsTrade = somaPts / qtdTrades;
                        }
                        else
                        {
                            somaPtsTrade = 0;
                        }

                        matrixSomaPtsTrade[r, c] = somaPtsTrade;
                        matrixQtdTrades[r, c] = qtdTrades;
                        matrixMedia[r, c] += somaPts;
                        matrixMediaQtdTrades[r, c] += qtdTrades;


                        //matrixSomaPtsTrade[r,c] =  CalculaPtsTradeOperacional(r + row0 ,c + col0);
                    }
                }





            //clrs1.Add("red");
            //clrs1.Add("blue");
            //clrs1.Add("green");
            //clrs1.Add("red");
            //clrs1.Add("red");
            //clrs1.Add("red");



            //Dictionary<string, List<string>> mk1 = new Dictionary<string, List<string>>();
            //mk1.Add("color", clrs1);






                for (int r = 0; r < matrixSomaPtsTrade.GetLength(0); r++)
                {

                    for (int c = 0; c < matrixSomaPtsTrade.GetLength(1); c++)
                    {

                        xArray[z] = c + col0;
                        yArray[z] = iDia - Convert.ToDouble(numericDiaInicial.Value) + 1 ;
                        zArray[z] = r + row0;

                        double escalaMax = 0.7;

                        listPtsTrade.Add(Math.Round(matrixSomaPtsTrade[r, c] , 2));
                        if (matrixSomaPtsTrade[r, c] > 0)
                        {
                            //clrs1.Add("green");

                            //rgb(31, 119, 180)
                            double dado = matrixSomaPtsTrade[r, c];
                            dado = dado > escalaMax ? escalaMax : dado;
                            string rgbStg = "rgb(" +
                            Convert.ToInt32((1 - dado / escalaMax) * 255) +
                            ", 255, " +
                            Convert.ToInt32((1 - dado / escalaMax) * 255) +
                            ")";

                            clrs1.Add(rgbStg);


                            //sizes1.Add(Math.Round(  (matrixSomaPtsTrade[r, c] > 1.5 ? 1.5 :  matrixSomaPtsTrade[r, c]  ) * 10  , 1));

                            //double sizeToAdd = matrixQtdTrades[r, c] / 100;
                            //sizeToAdd = sizeToAdd > 10 ? 10 : Math.Round(sizeToAdd, 1);
                            //sizeToAdd += 5;
                            //sizeToAdd = matrixQtdTrades[r, c] > 3 ? sizeToAdd : 0;

                            //sizes1.Add(sizeToAdd);

                            //Console.WriteLine("green: " + r + " | " + c + " | " + z + " | " + matrixSomaPtsTrade[r, c]);
                        }
                        else
                        {
                            //clrs1.Add("red");

                            double dado = matrixSomaPtsTrade[r, c];
                            dado = dado < -escalaMax ? -escalaMax : dado;
                            string rgbStg = "rgb(255, " +
                            Convert.ToInt32(( dado / escalaMax + 1) * 255) +
                            ", " +
                            Convert.ToInt32(( dado / escalaMax + 1) * 255) +
                            ")";


                            clrs1.Add(rgbStg);

                            //sizes1.Add(Math.Round(  (matrixSomaPtsTrade[r, c] < -1.5 ? 1.5 :Math.Abs( matrixSomaPtsTrade[r, c]))*10 , 1 ));


                            //Console.WriteLine("red: " + r + " | " + c + " | " + z + " | " + matrixSomaPtsTrade[r, c]);


                        }

                        double sizeToAdd = matrixQtdTrades[r, c] / 20;
                        sizeToAdd = sizeToAdd > 10 ? 10 : Math.Round(sizeToAdd, 1);
                        sizeToAdd += 5;
                        sizeToAdd = matrixQtdTrades[r, c] > 3  ? sizeToAdd : 1;
                        sizeToAdd = matrixQtdTrades[r, c] == 0 ? 0 : sizeToAdd;

                        sizes1.Add(sizeToAdd);

                        z++;


                    }
                }
            }

            for (int r = 0; r < matrixSomaPtsTrade.GetLength(0); r++)
            {
                for (int c = 0; c < matrixSomaPtsTrade.GetLength(1); c++)
                {

                    matrixMedia[r, c] = matrixMediaQtdTrades[r, c]==0?0: matrixMedia[r, c] / matrixMediaQtdTrades[r, c];
                    matrixMediaQtdTrades[r, c] = matrixMediaQtdTrades[r, c] / numDiasExecutados;


                }
            }


            for (int r = 0; r < matrixMedia.GetLength(0); r++)
            {
                for (int c = 0; c < matrixMedia.GetLength(1); c++)
                {
                    Console.Write(matrixMedia[r, c]); Console.Write(";");


                    xArray[z] = c + col0;
                    yArray[z] = -10;
                    zArray[z] = r + row0;

                    double escalaMax = 0.7;

                    listPtsTrade.Add(Math.Round(matrixMedia[r, c],2));

                    if (matrixMedia[r, c] > 0)
                    {
                        //clrs1.Add("green");

                        //rgb(31, 119, 180)
                        double dado = matrixMedia[r, c];
                        dado = dado > escalaMax ? escalaMax : dado;
                        string rgbStg = "rgb(" +
                        Convert.ToInt32((1 - dado / escalaMax) * 255) +
                        ", 255, " +
                        Convert.ToInt32((1 - dado / escalaMax) * 255) +
                        ")";

                        //rgbStg = matrixMedia[r, c] > 0.9 ? "magenta" : rgbStg;

                        clrs1.Add(rgbStg);


                        //sizes1.Add(Math.Round(  (matrixMedia[r, c] > 1.5 ? 1.5 :  matrixMedia[r, c]  ) * 10  , 1));

                        //double sizeToAdd = matrixMediaQtdTrades[r, c] / 100;
                        //sizeToAdd = sizeToAdd > 10 ? 10 : Math.Round(sizeToAdd, 1);
                        //sizeToAdd += 5;
                        //sizeToAdd = matrixMediaQtdTrades[r, c] > 3 ? sizeToAdd : 0;

                        //sizes1.Add(sizeToAdd);

                        //Console.WriteLine("green: " + r + " | " + c + " | " + z + " | " + matrixMedia[r, c]);
                    }
                    else
                    {
                        //clrs1.Add("red");

                        double dado = matrixMedia[r, c];
                        dado = dado < -escalaMax ? -escalaMax : dado;
                        string rgbStg = "rgb(255, " +
                        Convert.ToInt32((dado / escalaMax + 1) * 255) +
                        ", " +
                        Convert.ToInt32((dado / escalaMax + 1) * 255) +
                        ")";
                        //rgbStg = matrixMedia[r, c] < -0.9 ? "magenta" : rgbStg;


                        clrs1.Add(rgbStg);

                        //sizes1.Add(Math.Round(  (matrixMedia[r, c] < -1.5 ? 1.5 :Math.Abs( matrixMedia[r, c]))*10 , 1 ));


                        //Console.WriteLine("red: " + r + " | " + c + " | " + z + " | " + matrixMedia[r, c]);


                    }

                    double sizeToAdd = matrixMediaQtdTrades[r, c] / 20;
                    sizeToAdd = sizeToAdd > 10 ? 10 : Math.Round(sizeToAdd, 1);
                    sizeToAdd += 5;
                    sizeToAdd = matrixMediaQtdTrades[r, c] > 3 ? sizeToAdd : 1;
                    sizeToAdd = matrixMediaQtdTrades[r, c] == 0 ? 0 : sizeToAdd;

                    sizes1.Add(sizeToAdd);

                    z++;


                }
                Console.WriteLine(r + ":;");

            }



            XPlot.Plotly.Marker mk2 = new Marker();

            mk2.size = sizes1;
            mk2.color = clrs1;
            mk2.colorscale = "Viridis";
            mk2.opacity = 0.0;
            //XPlot.Plotly.Scatter3d()


            XPlot.Plotly.Scene scne1 = new Scene();
            //Dictionary <string,string> dictAxies = new Dictionary<string,string>();
            //dictAxies.Add();
            

            Camera cmra1 = new Camera();

            Up up1 = new Up();
            up1.x = 0;
            up1.y = 0;
            up1.z = 1;

            Center cntr1 = new Center();
            cntr1.x = 0;
            cntr1.y = 0;
            cntr1.z = 0;

            Eye ey1 = new Eye();
            ey1.x = 1.25;
            ey1.y = -1.25;
            ey1.z = 1.25;

            cmra1.up = up1;
            cmra1.center = cntr1;
            cmra1.eye = ey1;


            XPlot.Plotly.Scatter3d sct3d = new Scatter3d()
            {
                x = xArray
    ,
                y = yArray
    ,
                z = zArray
    ,
                mode = "markers"
    ,
                marker = mk2
    ,
                hoverinfo = "x+y+z+text"
    ,
                text = listPtsTrade
                //text= sizes1
                ,scene="stringSCCEENE"
                
                
                
            };

     

            var faresHist = XPlot.Plotly.Chart.Plot(
                sct3d
                
                //new Scatter3d()
                //{
                //    x = xArray
                //    ,
                //    y = yArray
                //    ,
                //    z = zArray
                //    ,
                    
                //    mode = "markers"
                //    ,
                //    marker = mk2
                //    ,
                //    hoverinfo="x+y+z+text"
                //    ,
                //    text=mk2.size
                //    //text= sizes1
                //}
                
                );
            //faresHist.Plot();

            XPlot.Plotly.Layout.Layout lyt1 = new XPlot.Plotly.Layout.Layout();
            lyt1.paper_bgcolor = "WhiteSmoke";
            lyt1.width = 1200;
            lyt1.height = 1000;
            lyt1.title = "passadoMix > c + col0 && passadoDol <   r + row0";
            

            Xaxis xAx1 = new Xaxis();
            xAx1.title = "X(col):VaricaoMIX";
            Yaxis yAx1 = new Yaxis();
            yAx1.title = "Y: Dia-" + textBoxMes.Text;
            Zaxis zAx1 = new Zaxis();
            zAx1.title = "Z(row):VariacaoDOL";


            

            scne1.xaxis = xAx1;
            scne1.yaxis = yAx1;
            scne1.zaxis = zAx1;
            scne1.camera = cmra1;

            lyt1.scene = scne1;
            //lyt1.scene.xaxis.title = "Titulo eixo X";



            //scne1.xaxis.ShouldSerializetitle();

            //scne1.xaxis.title = "Eixo X";

            //scne1.yaxis.title = "Eixo Y";
            //scne1.zaxis.title = "Eixo Z";

            //lyt1.scene.xaxis.title = "Eixo X";
            //lyt1.scene.yaxis.title = "Eixo Y";
            //lyt1.scene.zaxis.title = "Eixo Z";
            //lyt1.scene.xaxis = eixoX;
            //faresHist.wit
            faresHist.WithLayout(lyt1);
            faresHist.Show();

            List<string> ienum1 = new List<string>();
            ienum1.Add("aa");

            List<XPlot.Plotly.Chart> ienum0 = new List<XPlot.Plotly.Chart>();

            //faresHist.

            Trace trc1 = new Trace();

           

            XPlot.Plotly.Chart.Plot(trc1,lyt1);

            //faresHist.Plot(trc1);
            using (TextWriter tw = new StreamWriter( "Inputs-" + mes + ".csv"))
            {
                foreach (String s in tradesInputsRegistrados)
                    tw.WriteLine(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMXN.Text = "500";
            textBoxES.Text = "-0.5";
            textBox6E.Text = "-5000";
            textBoxAUD.Text = "-10000";
            textBoxCL.Text = "-5";
            textBoxWIN.Text = "-0.01428571";

        }

        private void buttonGerarGif_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            //Image img1 = null;
            //Image img2 = null;


            using (var gif = AnimatedGif.AnimatedGif.Create("GIF-" + date1 + ".gif", 1500))
            {

                //for (int i = 1; i < 10; i++)
                //{
                //    try
                //    {
                //        string date3 = DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd");
                //        var img1 = Image.FromFile(date3 + ".jpg");
                //        //gif.AddFrame(img1, delay: 1500, quality: GifQuality.Bit8);

                //        for (int i2 = i + 1; i2 < 10; i2++)
                //        {

                //            try
                //            {
                //                string date2 = DateTime.Now.AddDays(-i2).ToString("yyyy-MM-dd");
                //                Console.WriteLine(date2);
                //                var img2 = Image.FromFile(date2 + ".jpg");
                //                //gif.AddFrame(img2, delay: 1500, quality: GifQuality.Bit8);

                //                var img3 = Image.FromFile(date1 + ".jpg");
                //                gif.AddFrame(img2, delay: 1500, quality: GifQuality.Bit8);

                //                gif.AddFrame(img1, delay: 1500, quality: GifQuality.Bit8);

                //                gif.AddFrame(img3, delay: 1500, quality: GifQuality.Bit8);



                //                i2 = 11;
                //            }
                //            catch { }
                //        }



                //        i = 11;


                //    }
                //    catch { }



                //}

                //string date3 = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

                //string date2 = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                //gif.AddFrame(img2, delay: 1500, quality: GifQuality.Bit8);

                var img1 = Image.FromFile("img1.png");

                var img2 = Image.FromFile("img2.png");

                var img3 = Image.FromFile("img3.png");

                gif.AddFrame(img1, delay: 1500, quality: GifQuality.Bit8);

                gif.AddFrame(img2, delay: 1500, quality: GifQuality.Bit8);

                gif.AddFrame(img3, delay: 1500, quality: GifQuality.Bit8);


                //var img4 = Image.FromFile("img4.png");
                //gif.AddFrame(img4, delay: -1, quality: GifQuality.Bit8);
                //var img5 = Image.FromFile("img5.png");
                //gif.AddFrame(img5, delay: -1, quality: GifQuality.Bit8);
            }

        }

        //List<double> listAgr = new List<double>();

        //private Dictionary<DateTime, double> Agr1_Click(string filename)
        //{
        //    Dictionary<DateTime, double> dictAgr = new Dictionary<DateTime, double>();

        //    using (var reader = new StreamReader( filename ))
        //    {

        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var values = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);

        //            if (values[6] == "Comprador\"")
        //            {
        //                DateTime horarioAgr = DateTime.ParseExact(values[0].Substring(1), "HH:mm:ss", CultureInfo.InvariantCulture );

        //                double oldValue = 0;
        //                double newValue = 0;
        //                if (dictAgr.ContainsKey(horarioAgr))
        //                {
        //                    oldValue = dictAgr[horarioAgr];
        //                    dictAgr.Remove(horarioAgr);

        //                }

        //                newValue = oldValue + Convert.ToDouble(values[1]);
        //                dictAgr.Add(horarioAgr,  newValue);
        //            }

        //            if (values[6] == "Vendedor\"")
        //            {
        //                DateTime horarioAgr = DateTime.ParseExact(values[0].Substring(1), "HH:mm:ss", CultureInfo.InvariantCulture);

        //                double oldValue = 0;
        //                double newValue = 0;
        //                if (dictAgr.ContainsKey(horarioAgr))
        //                {
        //                    oldValue = dictAgr[horarioAgr];
        //                    dictAgr.Remove(horarioAgr);

        //                }

        //                newValue = oldValue - Convert.ToDouble(values[1]);
        //                dictAgr.Add(horarioAgr,  newValue);
        //            }




        //        }

        //        Console.WriteLine("stop");
        //    }

        //    //injection da Agr no dataset:





        //    return dictAgr;

        //}

        private List<double> Agr1_Click(string filename)
        {
            Dictionary<DateTime, double> dictAgr = new Dictionary<DateTime, double>();

            using (var reader = new StreamReader(filename))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);

                    if (values[6] == "Comprador\"")
                    {
                        DateTime horarioAgr = DateTime.ParseExact(values[0].Substring(1), "HH:mm:ss", CultureInfo.InvariantCulture);

                        double oldValue = 0;
                        double newValue = 0;
                        if (dictAgr.ContainsKey(horarioAgr))
                        {
                            oldValue = dictAgr[horarioAgr];
                            dictAgr.Remove(horarioAgr);

                        }

                        newValue = oldValue + Convert.ToDouble(values[1]);
                        dictAgr.Add(horarioAgr, newValue);
                    }

                    if (values[6] == "Vendedor\"")
                    {
                        DateTime horarioAgr = DateTime.ParseExact(values[0].Substring(1), "HH:mm:ss", CultureInfo.InvariantCulture);

                        double oldValue = 0;
                        double newValue = 0;
                        if (dictAgr.ContainsKey(horarioAgr))
                        {
                            oldValue = dictAgr[horarioAgr];
                            dictAgr.Remove(horarioAgr);

                        }

                        newValue = oldValue - Convert.ToDouble(values[1]);
                        dictAgr.Add(horarioAgr, newValue);
                    }




                }

            }

            Console.WriteLine("stop");

            string filename0 = filename.Substring(0, filename.Length -  7) + ".csv";

            List<double> listSync = new List<double>();
            listSync.Add(0);
            //injection da Agr no dataset:
            using (var reader = new StreamReader(filename0))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if(values[0].Contains(" "))
                    {
                        DateTime horarioDataset = DateTime.ParseExact(values[0].Substring(values[0].IndexOf(" ")), " HH:mm:ss", CultureInfo.InvariantCulture); ;

                        double agrAcum = 0;
                        if (dictAgr.ContainsKey(horarioDataset.AddSeconds(42)))
                        {
                            agrAcum += dictAgr[horarioDataset.AddSeconds(42)];
                        }
                        if (dictAgr.ContainsKey(horarioDataset.AddSeconds(41)))
                        {
                            agrAcum += dictAgr[horarioDataset.AddSeconds(41)];
                        }
                        if (dictAgr.ContainsKey(horarioDataset.AddSeconds(40)))
                        {
                            agrAcum += dictAgr[horarioDataset.AddSeconds(40)];
                        }

                        listSync.Add(agrAcum);
                    }


                }


            }
            Console.WriteLine("stop");

            File.WriteAllLines(filename.Split('.')[0] + "Saved.csv", listSync.Select(x => string.Join(",", x)));

            return listSync;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            textBoxMes.Text = "2020-08-";
            numericDiaFinal.Value = 31;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2020-09-";
            numericDiaFinal.Value = 30;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2020-10-";
            numericDiaFinal.Value = 30;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2020-11-";
            numericDiaFinal.Value = 27;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2020-12-";
            numericDiaFinal.Value = 23;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-01-";
            numericDiaFinal.Value = 29;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-02-";
            numericDiaFinal.Value = 26;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-03-";
            numericDiaFinal.Value = 31;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-04-";
            numericDiaFinal.Value = 30;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-05-";
            numericDiaFinal.Value = 31;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-06-";
            numericDiaFinal.Value = 30;
            PriceToCube_Click(button1, new EventArgs());

            textBoxMes.Text = "2021-07-";
            numericDiaFinal.Value = 30;
            PriceToCube_Click(button1, new EventArgs());

        }
    }
}
