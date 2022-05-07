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



namespace TickOrganizer_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            corretorasSelecionadas.Add("008-UBS");
            corretorasSelecionadas.Add("1618-Ideal");
            corretorasSelecionadas.Add("085-BTG");
            corretorasSelecionadas.Add("112-BGC");
            corretorasSelecionadas.Add("072-Bradesco");
            corretorasSelecionadas.Add("003-XP");
            corretorasSelecionadas.Add("120-Genial");
            corretorasSelecionadas.Add("016-JP Morgan");
            corretorasSelecionadas.Add("127-Tullet");
            corretorasSelecionadas.Add("114-Itau");
            corretorasSelecionadas.Add("040-Morgan");
            corretorasSelecionadas.Add("088-Capital");
        }

        List<Dictionary<DateTime, TickLine>> listDict0 = new List<Dictionary<DateTime, TickLine>>();
        List<Dictionary<DateTime, TickLine>> listDict1 = new List<Dictionary<DateTime, TickLine>>();

        List<string> corretorasSelecionadas = new List<string>();
        string[] ordemAtivosNinja = new string[5];
        string[] ordemAtivosTryd = new string[2];

        string[] pathsOrdenadosNinja = new string[5];
        string[] pathsOrdenadosTryd = new string[2];


        private void OrganizeTick_Click(object sender, EventArgs e)
        {
            ordemAtivosNinja[0] = "6E";
            ordemAtivosNinja[1] = "AUDUSD";
            ordemAtivosNinja[2] = "CL";
            ordemAtivosNinja[3] = "ES";
            ordemAtivosNinja[4] = "USDMXN";

            ordemAtivosTryd[0] = "DOLFUT";
            ordemAtivosTryd[1] = "WINFUT";





            string diaStg = "";

            for (int i = 0; i < Convert.ToInt32(textBoxQtdDiasSeguidos.Text); i++)
            {
                string diaMomento = DateTime.ParseExact(textBoxDiaInicial.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyy-MM-dd");
                horarioInicial = DateTime.ParseExact(textBoxDiaInicial.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(i);
                horarioInicial = horarioInicial.AddHours(9);
                horarioInicial = horarioInicial.AddMinutes(10);

                horarioFinal = DateTime.ParseExact(textBoxDiaInicial.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(i);
                horarioFinal = horarioFinal.AddHours(10);
                horarioFinal = horarioFinal.AddMinutes(30);

                listDict0.Clear();

                //foreach (var file in Directory.EnumerateFiles(@"C:\Users\world\Documents\AmostragemDolar\TickOrganizerDados\" + textBoxSemana.Text + @"\", "*.txt"))
                //{
                //    listDict0.Add(TickOrganizer(file));
                //}

                foreach (string file in Directory.EnumerateFiles(@"C:\Users\world\Documents\AmostragemDolar\TickOrganizerDados\" + textBoxSemana.Text + @"\", "*.txt"))
                {
                    for (int iAtivo = 0; iAtivo <= 4; iAtivo++)
                    {
                        if (file.Substring(file.LastIndexOf(@"\")).Contains(ordemAtivosNinja[iAtivo]))
                        {
                            pathsOrdenadosNinja[iAtivo] = file;
                        }
                    }

                }


                for (int iAtivo = 0; iAtivo <= 4; iAtivo++)
                {
                    listDict0.Add(TickOrganizer(pathsOrdenadosNinja[iAtivo]));
                }



                listDict1.Clear();

                //foreach (string file in Directory.EnumerateFiles(@"C:\Users\world\Documents\AmostragemDolar\TickOrganizerDadosTryd\" + textBoxSemana.Text + @"\" + diaMomento, "*.csv"))
                //{
                //    listDict1.Add(TickOrganizerTryd(file));
                //    diaStg = file.Substring(file.LastIndexOf(@"\"));
                //    diaStg = diaStg.Substring(1, 10);

                //}
                foreach (string file in Directory.EnumerateFiles(@"C:\Users\world\Documents\AmostragemDolar\TickOrganizerDadosTryd\" + textBoxSemana.Text + @"\" + diaMomento, "*.csv"))
                {
                    for (int iAtivo = 0; iAtivo <= 1; iAtivo++)
                    {
                        if (file.Substring(file.LastIndexOf(@"\")).Contains(ordemAtivosTryd[iAtivo]))
                        {
                            pathsOrdenadosTryd[iAtivo] = file;
                        }
                    }

                }


                for (int iAtivo = 0; iAtivo <= 1; iAtivo++)
                {
                    listDict1.Add(TickOrganizerTryd(pathsOrdenadosTryd[iAtivo]));
                    diaStg = pathsOrdenadosTryd[iAtivo].Substring(pathsOrdenadosTryd[iAtivo].LastIndexOf(@"\"));
                    diaStg = diaStg.Substring(1, 10);
                }




                Console.WriteLine("stop");

                List<string> listLinhas = new List<string>();



                foreach (KeyValuePair<DateTime,TickLine> keyPair in listDict0[0])
                {
                    string linhasAlinhadas = "";

                    linhasAlinhadas += keyPair.Key.ToString("yyyy-MM-dd-HH:mm:ss") + ";" ;

                    foreach (Dictionary<DateTime,TickLine> dictNow in listDict0)
                    {
                        linhasAlinhadas += dictNow[keyPair.Key].LastPrice.ToString() + ";";
                    }

                    foreach (Dictionary<DateTime, TickLine> dictNow in listDict1)
                    {
                        linhasAlinhadas += dictNow[keyPair.Key].LastPrice.ToString() + ";";
                    }

                    //foreach (Dictionary<DateTime, TickLine> dictNow in listDict1)
                    //{
                    foreach (string corretoraX in corretorasSelecionadas)
                    {
                        linhasAlinhadas += listDict1[0][keyPair.Key].dictCorretoras.ContainsKey(corretoraX) ? listDict1[0][keyPair.Key].dictCorretoras[corretoraX].ToString() + ";" : "0;";

                    }
                    //}

                    listLinhas.Add(linhasAlinhadas);
                }

                //for (int i = 0; i < listDict0[0].Count; i++)
                //{
                //    linhasAlinhadas += listDict0[0][i]. 
                //}

                //System.IO.File.WriteAllText( Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd-HH")) + "--" + diaStg + ".csv", String.Join("\n", listLinhas.ToArray()));
           
                System.IO.File.WriteAllText(  diaStg + ".csv", String.Join("\n", listLinhas.ToArray()));

            }


            Console.WriteLine("stop");

        }

        //private void button1_click(object obj, EventArgs e )
        //{

        //}

        //DateTime horarioInicial = new DateTime(2021, 01, 05, 09, 10, 00);
        //DateTime horarioFinal = new DateTime(2021, 01, 05, 10, 30, 00);
        DateTime horarioInicial = new DateTime(1900, 01, 01, 01, 01, 00);
        DateTime horarioFinal = new DateTime(1900, 01, 01, 01, 01, 00);

        private Dictionary<DateTime, TickLine> TickOrganizer(string filename)
        {
            //string filename = "USDMXN.Last.txt";
            Dictionary<DateTime, TickLine> dictTick = new Dictionary<DateTime, TickLine>();





            using (var reader = new StreamReader(filename))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    string horarioStg = values[0].Substring(0, values[0].LastIndexOf(" "));

                    DateTime horarioLine = DateTime.ParseExact(values[0], "yyyyMMdd HHmmss fffffff", CultureInfo.InvariantCulture);
                    horarioLine = horarioLine.AddHours(-3);

                    double lastPriceLine = Convert.ToDouble(values[1]);
                    double volumeLine = Convert.ToDouble(values[4]);

                    TickLine tickLine1 = new TickLine();
                    tickLine1.LastPrice = lastPriceLine;
                    tickLine1.Volume = volumeLine;

                    while (dictTick.ContainsKey(horarioLine))
                    {
                        horarioLine = horarioLine.AddMilliseconds(1);
                    }



                    dictTick.Add(horarioLine, tickLine1);

                    //Console.WriteLine("stop");
                }
            }





            Dictionary<DateTime, TickLine> dictPrecoInicio3Segundos = new Dictionary<DateTime, TickLine>();





            for (DateTime timeTemp = horarioInicial; timeTemp <= horarioFinal; timeTemp = timeTemp.AddSeconds(3))
            {
                TickLine lineSalva = new TickLine();

                lineSalva.LastPrice = dictTick[dictTick.Where(x => x.Key < timeTemp).Max(x => x.Key)].LastPrice;

                dictPrecoInicio3Segundos.Add(timeTemp, lineSalva);



            }


            Console.WriteLine("stop");



            return dictPrecoInicio3Segundos;



        }

        //private void button1_Click(object sender, EventArgs e)
        private Dictionary<DateTime, TickLine> TickOrganizerTryd(string filename)
        {

            //string filename = "2021-01-04DOLFUT.csv";
            Dictionary<DateTime, TickLine> dictTick = new Dictionary<DateTime, TickLine>();

            string diaStg = filename.Substring(filename.LastIndexOf(@"\"));
            diaStg = diaStg.Substring(1, 10);

            ////Console.WriteLine("stop");

            ////diaStg = filename.Substring(filename.LastIndexOf(@"\"));
            ////diaStg = diaStg.Substring(2, 10);


            ////Console.WriteLine("stop");


            ////diaStg = filename.Substring(filename.LastIndexOf(@"\"));
            ////diaStg = diaStg.Substring(1, 10);


            ////Console.WriteLine("stop");


            //diaStg = filename.Substring(filename.LastIndexOf(@"\"));
            //diaStg = diaStg.Substring(1, 10);

            //Console.WriteLine("stop");


            ////diaStg = filename.Substring(filename.LastIndexOf(@"\" + 2));


            ////diaStg = filename.Substring(0, 10);

            ////Console.WriteLine("stop");




            List<string> listaInicial = new List<string>();




            using (var reader = new StreamReader(filename))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = line.Replace("\",\"", ";");
                    line = line.Replace("\"", "");
                    line = line.Replace(",", "");


                    listaInicial.Add(line);

                }
            }

            listaInicial.Reverse();

            foreach (string line in listaInicial)
            {
                var values = line.Split(';');

                //string horarioStg = values[0].Substring(1);

                //DateTime horarioLine = DateTime.ParseExact(values[0], "yyyyMMdd HHmmss fffffff", CultureInfo.InvariantCulture);
                DateTime horarioLine = DateTime.ParseExact(diaStg + values[0], "yyyy-MM-ddHH:mm:ss", CultureInfo.InvariantCulture);

                //horarioLine = horarioLine.AddHours(3);

                double lastPriceLine = Convert.ToDouble(values[2]);
                double volumeLine = Convert.ToDouble(values[1]);

                TickLine tickLine1 = new TickLine();
                tickLine1.LastPrice = lastPriceLine;
                tickLine1.Volume = volumeLine;
                //tickLine1.dictCorretoras.

                if (filename.Contains("DOL"))
                {
                    //if (tickLine1.dictCorretoras.ContainsKey(values[4]))
                    //{
                    //    tickLine1.dictCorretoras[values[4]] += Convert.ToDouble(values[1]);
                    //}
                    //else
                    //{
                        tickLine1.dictCorretoras.Add(values[4], Convert.ToDouble(values[1]));
                    //}

                    if (tickLine1.dictCorretoras.ContainsKey(values[5]))
                    {
                        tickLine1.dictCorretoras[values[5]] -= Convert.ToDouble(values[1]);
                    }
                    else
                    {
                        tickLine1.dictCorretoras.Add(values[5], -Convert.ToDouble(values[1]));
                    }
                }



                //horarioLine = horarioLine.AddMilliseconds(500);

                while (dictTick.ContainsKey(horarioLine))
                {
                    horarioLine = horarioLine.AddMilliseconds(1);
                }

                dictTick.Add(horarioLine, tickLine1);

                //Console.WriteLine("stop");
            }


            //Dictionary<string, double> CorretorasNoDia = new Dictionary<string, double>();

            DateTime stopTime = new DateTime(2021, 01, 04, 09, 12, 20);



            Dictionary<DateTime, TickLine> dictPrecoInicio3Segundos = new Dictionary<DateTime, TickLine>();


            double valorToAdd = 0;




            for (DateTime timeTemp = horarioInicial; timeTemp <= horarioFinal; timeTemp = timeTemp.AddSeconds(3))
            {
                TickLine lineSalva = new TickLine();

                lineSalva.LastPrice = dictTick[dictTick.Where(x => x.Key < timeTemp).Max(x => x.Key)].LastPrice;

                dictPrecoInicio3Segundos.Add(timeTemp, lineSalva);
                if (filename.Contains("DOL"))
                {
                    foreach (string corretoraX in corretorasSelecionadas)
                    {
                        valorToAdd = dictTick.Where(x => timeTemp.AddSeconds(-3) <= x.Key && x.Key < timeTemp).Sum(x => x.Value.dictCorretoras.ContainsKey(corretoraX) ? x.Value.dictCorretoras[corretoraX] : 0);
                        dictPrecoInicio3Segundos[timeTemp].dictCorretoras.Remove(corretoraX);
                        dictPrecoInicio3Segundos[timeTemp].dictCorretoras.Add(corretoraX, valorToAdd);
                    }
                }

                //if (timeTemp > stopTime)
                //{
                //    Console.WriteLine("stop");
                //}
            }


            Console.WriteLine("stop");



            Console.WriteLine("stop");


            return dictPrecoInicio3Segundos;






        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
