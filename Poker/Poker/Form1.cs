using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Spil_karata spil;
        public Igra igra;
        public Vrednosti provera;
        public static string labela1;
        public static string labela2;
        public static string labela3;
        public static string labela4;
        public bool pvi_call = false;
        public bool prvi_fold = false;
        public bool prvi_bet = false;
        public bool prvi_rais = false;

        public bool drugi_call = false;
        public bool drugi_fold = false;
        public bool drugi_bet = false;
        public bool drugi_rais = false;

        public int brojac = 0;

        public Form1()
        {
            
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            spil = new Spil_karata();
            igra = new Igra();
            provera = new Vrednosti();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            button2.Hide();
            Call.Hide();
            button4.Hide();
            Bet.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            igra.Igraj();
            igra.prikazi_karte();
            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Under-h.png");
            pictureBox3.Image = slika;
            pictureBox4.Image = slika;
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            button1.Hide();
            brojac = 1;
            button2.Show();
            Call.Show();
            button4.Show();
            Bet.Show();
            /*label1.Text = "";
            label2.Text = "";
            label3.Text = "";*/
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //call
            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Under-h.png");
            brojac++;
            if (brojac % 2 != 0)
            {
                igra.prikazi_karte();
                pictureBox3.Image = slika;
                pictureBox4.Image = slika;
            }
            else
            {
                igra.prikazi_karte();
                pictureBox1.Image = slika;
                pictureBox2.Image = slika;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Under-h.png");
            //bet
            brojac++;
            if (brojac % 2 != 0)
            {
                igra.prikazi_karte();
                pictureBox3.Image = slika;
                pictureBox4.Image = slika;
            }
            else
            {
                igra.prikazi_karte();
                pictureBox1.Image = slika;
                pictureBox2.Image = slika;
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //fold
            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Under-h.png");
            brojac++;
            if (brojac % 2 != 0)
            {
                spil = new Spil_karata();
                igra = new Igra();
                provera = new Vrednosti();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                button2.Hide();
                Call.Hide();
                button4.Hide();
                Bet.Hide();

                igra.Igraj();
                igra.prikazi_karte();
                pictureBox3.Image = slika;
                pictureBox4.Image = slika;
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                button1.Hide();
                brojac = 1;
                button2.Show();
                Call.Show();
                button4.Show();
                Bet.Show();
            }
            else
            {
                spil = new Spil_karata();
                igra = new Igra();
                provera = new Vrednosti();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                button2.Hide();
                Call.Hide();
                button4.Hide();
                Bet.Hide();

                igra.Igraj();
                igra.prikazi_karte();
                pictureBox3.Image = slika;
                pictureBox4.Image = slika;
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                button1.Hide();
                brojac = 1;
                button2.Show();
                Call.Show();
                button4.Show();
                Bet.Show();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //rais
            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Under-h.png");
            brojac++;
            if (brojac % 2 != 0)
            {
                igra.prikazi_karte();
                pictureBox3.Image = slika;
                pictureBox4.Image = slika;
            }
            else
            {
                igra.prikazi_karte();
                pictureBox1.Image = slika;
                pictureBox2.Image = slika;
            }
        }
        
        public enum Ruke
        {
            High_card,
            Pair,
            Two_pair,
            Three_of_a_kind,
            Four_of_a_kind,
            Straight,
            Flush,
            Full_house,
            Straight_flush,
            Royal_flush
        }
        public enum Boja
        { 
            Karo,
            Herc,
            Tref,
            Pik
        }
        public enum Vrednost
        { 
            Dva,
            Tri,
            Cetiri,
            Pet,
            Sest,
            Sedam,
            Osam,
            Devet,
            Deset,
            Zandar,
            Kraljica,
            Kralj,
            As
        }
        public class Karta
        {
            public Boja Boja { get; set; }
            public Vrednost Vrednost { get; set; }

            public override string  ToString()
            {
                return Vrednost + " " + Boja;
            }
        }
        public class Spil_karata
        {
            private List<Karta> karte;

            public Spil_karata()
            {
                karte = new List<Karta>();
                popuni_spil();
            }
            
            public void popuni_spil()
            {
                foreach (Boja pom in Enum.GetValues(typeof(Boja)))
                {
                    foreach (Vrednost pom2 in Enum.GetValues(typeof(Vrednost)))
                    {
                        karte.Add(new Karta { Boja = pom, Vrednost = pom2 });
                    }
                }
            }

            public void promesaj_spil()
            {
                Random random = new Random();
                karte = karte.OrderBy(karta => random.Next()).ToList();
            }

            public Karta deli()
            {
                if (karte.Count > 0)
                {
                    Karta pom = karte[0];
                    karte.RemoveAt(0);
                    return pom;
                }
                else
                    return null;
            }

        }
        public class Vrednosti
        {
            Form1 form = (Form1)Application.OpenForms["Form1"];
            private int glavnapom;
            private int pom1;
            private int pom2;

            public string prava_ruka(List<Karta> ruka, List<Karta> ruka2)
            {
                int vrednost_prvog;
                int vrednost_drugog;
                
                if (je_Royal_flush(ruka))
                {
                    vrednost_prvog = 10;
                }
                else if (je_Straight_flush(ruka))
                {
                    vrednost_prvog = 9;
                }
                else if (je_Four_of_a_kind(ruka))
                {
                    vrednost_prvog = 8;
                }
                else if (je_Full_house(ruka))
                {
                    vrednost_prvog = 7;
                }
                else if (je_Flush(ruka))
                {
                    vrednost_prvog = 6;
                }
                else if (je_Straight(ruka))
                {
                    vrednost_prvog = 5;
                }
                else if (je_Three_of_a_kind(ruka))
                {
                    vrednost_prvog = 4;
                }
                else if (je_Two_pair(ruka))
                {
                    vrednost_prvog = 3;
                }
                else if (je_Pair(ruka))
                {
                    vrednost_prvog = 2;
                    pom1 = glavnapom;
                }
                else
                {
                    vrednost_prvog = 1;
                }
                if (je_Royal_flush(ruka2))
                {
                    vrednost_drugog = 10;
                }
                else if (je_Straight_flush(ruka2))
                {
                    vrednost_drugog = 9;
                }
                else if (je_Four_of_a_kind(ruka2))
                {
                    vrednost_drugog = 8;
                }
                else if (je_Full_house(ruka2))
                {
                    vrednost_drugog = 7;
                }
                else if (je_Flush(ruka2))
                {
                    vrednost_drugog = 6;
                }
                else if (je_Straight(ruka2))
                {
                    vrednost_drugog = 5;
                }
                else if (je_Three_of_a_kind(ruka2))
                {
                    vrednost_drugog = 4;
                }
                else if (je_Two_pair(ruka2))
                {
                    vrednost_drugog = 3;
                }
                else if (je_Pair(ruka2))
                {
                    vrednost_drugog = 2;
                    pom2 = glavnapom;
                }
                else
                {
                    vrednost_drugog = 1;
                }
                //form.label2.Text = vrednost_drugog.ToString() + " " + vrednost_prvog.ToString();
                
                if (vrednost_prvog>vrednost_drugog)
                {
                    return "prvi";
                }
                else if (vrednost_prvog<vrednost_drugog)
                {
                    return "drugi";
                }
                else if (vrednost_drugog == vrednost_prvog) 
                {
                    var prva = ruka.Take(2).ToList();
                    var druga = ruka2.Take(2).ToList();

                    var prva_ruka = prva.Select(karta => (int)karta.Vrednost).ToList();
                    var druga_ruka = druga.Select(karta => (int)karta.Vrednost).ToList();

                    prva_ruka.Sort();
                    druga_ruka.Sort();
                    //form.label4.Text = prva_ruka[0].ToString()+" "+prva_ruka[1].ToString()+" "+druga_ruka[0].ToString()+" "+druga_ruka[1].ToString();

                    if (prva_ruka[1]>druga_ruka[1])
                    {
                        return "prvi";
                    }
                    else if (prva_ruka[1] < druga_ruka[1])
                    {
                        return "drugi";
                    }
                    else if (prva_ruka[1]== druga_ruka[1])
                    {
                        if (prva_ruka[0] > druga_ruka[0])
                        {
                            return "prvi";
                        }
                        else if (prva_ruka[0] < druga_ruka[0])
                        {
                            return "drugi";
                        }
                    }
                    return "nereseno";
                    
                }
              /*  if (vrednost_prvog==2&&vrednost_drugog==2)
                {
                    if (vrednost_prvog>vrednost_drugog)
                    {
                        return "prvi";
                    }
                    if (vrednost_prvog<vrednost_drugog)
                    {
                        return "drugi";
                    }
                    if (vrednost_drugog == vrednost_prvog && pom1 > pom2) 
                    {
                        return "prvi";
                    }
                    if (vrednost_prvog == vrednost_drugog && pom1 < pom2)
                    {
                        return "drugi";
                    }
                    if (vrednost_prvog == vrednost_drugog &&pom1 == pom2)
                    {
                        var prva = ruka.Skip(Math.Max(0, ruka.Count() - 2)).Take(2).ToList();
                        var druga = ruka2.Skip(Math.Max(0, ruka2.Count() - 2)).Take(2).ToList();

                        var prva_ruka = prva.Select(karta => (int)karta.Vrednost).Distinct().ToList();
                        var druga_ruka = druga.Select(karta => (int)karta.Vrednost).Distinct().ToList();

                        prva_ruka.Sort();
                        druga_ruka.Sort();

                        if (prva_ruka.Max() > druga_ruka.Max())
                        {
                            return "prvi";
                        }
                        if (prva_ruka.Max() < druga_ruka.Max())
                        {
                            return "drugi";
                        }
                        else
                        {
                            return "nereseno";
                        }
                    }
                    else
                    {
                        return "ne znam";
                    }*/
                else
                {
                    return "ne znam";
                }
            }
            private bool je_Pair(List<Karta> ruka)
            {
                var grupa1 = ruka.GroupBy(karta => karta.Vrednost);
                
                foreach (var item in grupa1)
                {
                    if (item.Count()==2)
                    {
                        if (item.Key.ToString()=="As")
                        {
                            glavnapom = 14;
                        }
                        else if (item.Key.ToString() == "Dva")
                        {
                            glavnapom = 2;
                        }
                        else if (item.Key.ToString() == "Tri")
                        {
                            glavnapom = 3;
                        }
                        else if (item.Key.ToString() == "Cetiri")
                        {
                            glavnapom = 4;
                        }
                        else if (item.Key.ToString() == "Pet")
                        {
                            glavnapom = 5;
                        }
                        else if (item.Key.ToString() == "Sest")
                        {
                            glavnapom = 6;
                        }
                        else if (item.Key.ToString() == "Sedam")
                        {
                            glavnapom = 7;
                        }
                        else if (item.Key.ToString() == "Osam")
                        {
                            glavnapom = 8;
                        }
                        else if (item.Key.ToString() == "Devet")
                        {
                            glavnapom = 9;
                        }
                        else if (item.Key.ToString() == "Deset")
                        {
                            glavnapom = 10;
                        }
                        else if (item.Key.ToString() == "Zandar")
                        {
                            glavnapom = 11;
                        }
                        else if (item.Key.ToString() == "Kraljica")
                        {
                            glavnapom = 12;
                        }
                        else if (item.Key.ToString() == "Kralj")
                        {
                            glavnapom = 13;
                        }
                    }  
                }
                return grupa1.Any(grupa => grupa.Count() == 2);
            }
            private bool je_Two_pair(List<Karta> ruka)
            {
                var grupe = ruka.GroupBy(karta => karta.Vrednost);
                int parova = grupe.Count(grupa => grupa.Count() == 2);

                return parova >= 2;
                
            }
            private bool je_Three_of_a_kind(List<Karta> ruka)
            {
                return ruka.GroupBy(karta => karta.Vrednost).Any(grupa => grupa.Count() == 3);
            }
            private bool je_Four_of_a_kind(List<Karta> ruka)
            {
                return ruka.GroupBy(karta => karta.Vrednost).Any(grupa => grupa.Count() == 4);
            }
            private bool je_Straight(List<Karta> ruka)
            {
                
                var razlicite_vrednosti = ruka.Select(karta => (int)karta.Vrednost).Distinct().OrderBy(x => x).ToList();

                
                if (razlicite_vrednosti.Count == 5 && razlicite_vrednosti.Max() == (int)Vrednost.As && razlicite_vrednosti.Min() == (int)Vrednost.Dva)
                {
                    return true;
                }

                for (int i = 0; i < razlicite_vrednosti.Count ; i++)
                {
                    if (razlicite_vrednosti[i + 1] - razlicite_vrednosti[i] != 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            private bool je_Flush(List<Karta> ruka)
            {
                //grupisem sve karte po znaku tj boji
                var grupa_boja = ruka.GroupBy(karta => karta.Boja);

                //proveravam da li u svakoj grupi ima 5 ili vise istih znakova
                foreach (var item in grupa_boja)
                {
                    if (item.Count() >= 5)
                    {
                        return true;
                    }
                }
                return false;
            }
            private bool je_Full_house(List<Karta> ruka)
            {
                var grupe = ruka.GroupBy(karta => karta.Vrednost);
                int tri = grupe.Count(grupa => grupa.Count() == 3);
                int par = grupe.Count(grupa => grupa.Count() == 2);
                if (tri == 1 && par >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            private bool je_Straight_flush(List<Karta> ruka)
            {
                return je_Flush(ruka) && je_Straight(ruka);
            }
            private bool je_Royal_flush(List<Karta> ruka)
            {
                return je_Straight_flush(ruka) && ruka.Any(karta => karta.Vrednost == Vrednost.As) && ruka.Any(karta=>karta.Vrednost==Vrednost.Kralj);
            }
        }
        public class Igra
        {
            public int brojac = 0;
            public string[] prvi_igrac;
            public string[] drugi_igrac;
            public string[] diler_flop;
            public string[,] dilerove_karte=new string[5,2];
            List<Karta> ruka_prvog_i_diler;
            List<Karta> ruka_drugo_i_diler;
            Form1 form = (Form1)Application.OpenForms["Form1"];
            Spil_karata spil;
            Vrednosti provera;
            public void Igraj()
            {
                brojac = 0;
                ruka_prvog_i_diler = new List<Karta>();
                ruka_drugo_i_diler = new List<Karta>();
                provera = new Vrednosti();
                spil = new Spil_karata();
                spil.promesaj_spil();
                int broj_igraca = 2;
               
                List<List<Karta>> ruke = new List<List<Karta>>();
                //deljenje karti
                for (int i = 0; i < broj_igraca; i++)
                {
                    List<Karta> ruka = new List<Karta>();
                    for (int j = 0; j < 2; j++)
                    {
                        ruka.Add(spil.deli());
                        if (i==0)
                        {
                            ruka_prvog_i_diler.Add(ruka[j]);
                        }
                        if (i>0)
                        {
                            ruka_drugo_i_diler.Add(ruka[j]);
                        }
                    }
                    ruke.Add(ruka);
                }
                
                //prikazivanje karti
                string pom2 = "";
                string pom = "";
                string pom3 = "";
                for (int i = 0; i < broj_igraca; i++)
                {
                    foreach (var item in ruke[i])
                    {
                        if (i == 0)
                        {
                            pom += item.ToString() + "-";
                        }
                        if (i == 1)
                        {
                            pom2 += item.ToString() + "-";
                        }
                    }
                }
                prvi_igrac = pom.Split('-');
                drugi_igrac = pom2.Split('-');
                
                List<Karta> diler = new List<Karta>();
                
                for (int i = 0; i < 5; i++)
                {
                    diler.Add(spil.deli());
                    ruka_prvog_i_diler.Add(diler[i]);
                    ruka_drugo_i_diler.Add(diler[i]);
                }
             
                foreach (var item in diler)   
                {
                    pom3 += item.ToString() + "-";
                }
                
                diler_flop = pom3.Split('-');
            }
            public string provere()
            {

                return provera.prava_ruka(ruka_prvog_i_diler, ruka_drugo_i_diler).ToString();
                /*form.label2.Text = ruka_prvog_i_diler.Count().ToString();
                form.label1.Text = provera.prava_ruka(ruka_prvog_i_diler,ruka_drugo_i_diler).ToString();
                form.label3.Text = ruka_drugo_i_diler.Count().ToString();*/
            }
            public void prikaz_dilera()
            {
                brojac++;
                    for (int i = 0; i < 5; i++)
                    {
                        if (diler_flop[i]=="As Karo")
                        {
                            dilerove_karte[i, 0] = "As";
                            dilerove_karte[i, 1] = "Karo";

                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\A-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "As Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "As Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Dva Karo")
                        {
                            dilerove_karte[i, 0] = "Dva";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\2-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Dva Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Dva Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Tri Karo")
                        {
                            dilerove_karte[i, 0] = "Tri";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\3-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Tri Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Tri Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Cetiri Karo")
                        {
                            dilerove_karte[i, 0] = "Cetiri";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\4-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Cetiri Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Cetiri Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Pet Karo")
                        {
                            dilerove_karte[i, 0] = "Pet";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\5-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Pet Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Pet Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sest Karo")
                        {
                            dilerove_karte[i, 0] = "Sest";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\6-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sest Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sest Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sedam Karo")
                        {
                            dilerove_karte[i, 0] = "Sedam";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\7-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sedam Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sedam Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Osam Karo")
                        {
                            dilerove_karte[i, 0] = "Osam";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\8-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Osam Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Osam Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Devet Karo")
                        {
                            dilerove_karte[i, 0] = "Devet";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\9-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Devet Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Devet Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Deset Karo")
                        {
                            dilerove_karte[i, 0] = "Deset";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\10-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Deset Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Deset Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Zandar Karo")
                        {
                            dilerove_karte[i, 0] = "Zandar";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\J-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Zandar Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Zandar Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kraljica Karo")
                        {
                            dilerove_karte[i, 0] = "Kraljica";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\Q-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kraljica Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kraljica Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kralj Karo")
                        {
                            dilerove_karte[i, 0] = "Kralj";
                            dilerove_karte[i, 1] = "Karo";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\K-k.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kralj Karo")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kralj Karo")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "As Herc")
                        {
                            dilerove_karte[i, 0] = "As";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\A-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "As Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "As Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Dva Herc")
                        {
                            dilerove_karte[i, 0] = "Dva";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\2-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Dva Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Dva Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Tri Herc")
                        {
                            dilerove_karte[i, 0] = "Tri";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\3-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Tri Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Tri Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Cetiri Herc")
                        {
                            dilerove_karte[i, 0] = "Cetiri";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\4-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Cetiri Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Cetiri Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Pet Herc")
                        {
                            dilerove_karte[i, 0] = "Pet";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\5-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Pet Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Pet Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sest Herc")
                        {
                            dilerove_karte[i, 0] = "Sest";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\6-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sest Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sest Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sedam Herc")
                        {
                            dilerove_karte[i, 0] = "Sedam";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\7-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sedam Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sedam Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Osam Herc")
                        {
                            dilerove_karte[i, 0] = "Osam";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\8-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Osam Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Osam Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Devet Herc")
                        {
                            dilerove_karte[i, 0] = "Devet";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\9-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Devet Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Devet Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Deset Herc")
                        {
                            dilerove_karte[i, 0] = "Deset";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\10-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Deset Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Deset Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Zandar Herc")
                        {
                            dilerove_karte[i, 0] = "Zandar";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\J-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Zandar Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Zandar Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kraljica Herc")
                        {
                            dilerove_karte[i, 0] = "Kraljica";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Q-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kraljica Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kraljica Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kralj Herc")
                        {
                            dilerove_karte[i, 0] = "Kralj";
                            dilerove_karte[i, 1] = "Herc";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\K-h.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kralj Herc")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kralj Herc")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "As Pik")
                        {
                            dilerove_karte[i, 0] = "As";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\A-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "As Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "As Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Dva Pik")
                        {
                            dilerove_karte[i, 0] = "Dva";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\2-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Dva Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Dva Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Tri Pik")
                        {
                            dilerove_karte[i, 0] = "Tri";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\3-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Tri Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Tri Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Cetiri Pik")
                        {
                            dilerove_karte[i, 0] = "Cetiri";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\4-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Cetiri Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Cetiri Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Pet Pik")
                        {
                            dilerove_karte[i, 0] = "Pet";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\5-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Pet Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Pet Pik") 
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sest Pik")
                        {
                            dilerove_karte[i, 0] = "Sest";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\6-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sest Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sest Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sedam Pik")
                        {
                            dilerove_karte[i, 0] = "Sedam";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\7-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sedam Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sedam Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Osam Pik")
                        {
                            dilerove_karte[i, 0] = "Osam";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\8-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Osam Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Osam Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Devet Pik")
                        {
                            dilerove_karte[i, 0] = "Devet";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\9-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Devet Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Devet Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Deset Pik")
                        {
                            dilerove_karte[i, 0] = "Deset";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\10-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Deset Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Deset Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Zandar Pik")
                        {
                            dilerove_karte[i, 0] = "Zandar";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\J-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Zandar Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Zandar Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kraljica Pik")
                        {
                            dilerove_karte[i, 0] = "Kraljica";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\Q-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kraljica Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kraljica Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kralj Pik")
                        {
                            dilerove_karte[i, 0] = "Kralj";
                            dilerove_karte[i, 1] = "Pik";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\K-p.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kralj Pik")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kralj Pik")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "As Tref")
                        {
                            dilerove_karte[i, 0] = "As";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\A-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "As Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "As Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Dva Tref")
                        {
                            dilerove_karte[i, 0] = "Dva";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\2-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Dva Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Dva Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Tri Tref")
                        {
                            dilerove_karte[i, 0] = "Tri";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\3-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Tri Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Tri Tref") 
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Cetiri Tref")
                        {
                            dilerove_karte[i, 0] = "Cetiri";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\4-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Cetiri Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Cetiri Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Pet Tref")
                        {
                            dilerove_karte[i, 0] = "Pet";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\5-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Pet Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Pet Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sest Tref")
                        {
                            dilerove_karte[i, 0] = "Sest";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\6-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sest Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sest Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Sedam Tref")
                        {
                            dilerove_karte[i, 0] = "Sedam";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\7-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Sedam Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Sedam Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Osam Tref")
                        {
                            dilerove_karte[i, 0] = "Osam";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\8-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Osam Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Osam Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Devet Tref")
                        {
                            dilerove_karte[i, 0] = "Devet";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\9-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Devet Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Devet Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Deset Tref")
                        {
                            dilerove_karte[i, 0] = "Deset";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\10-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Deset Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Deset Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Zandar Tref")
                        {
                            dilerove_karte[i, 0] = "Zandar";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\J-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Zandar Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Zandar Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kraljica Tref")
                        {
                            dilerove_karte[i, 0] = "Kraljica";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\Q-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kraljica Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kraljica Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (diler_flop[i] == "Kralj Tref")
                        {
                            dilerove_karte[i, 0] = "Kralj2";
                            dilerove_karte[i, 1] = "Tref";
                            Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\K-t.png");
                            if (brojac == 1)
                            {
                                if (i == 0)
                                {
                                    form.pictureBox5.Image = slika;
                                }
                                if (i == 1)
                                {
                                    form.pictureBox6.Image = slika;
                                }
                                if (i == 2)
                                {
                                    form.pictureBox7.Image = slika;
                                }
                            }
                            if (brojac == 2 && diler_flop[3] == "Kralj Tref")
                            {
                                form.pictureBox8.Image = slika;
                            }
                            if (brojac == 3 && diler_flop[4] == "Kralj Tref")
                            {
                                form.pictureBox9.Image = slika;
                            }
                        }
                        if (brojac==1)
                        {
                            form.pictureBox5.Show();
                            form.pictureBox6.Show();
                            form.pictureBox7.Show(); 
                        }
                        if (brojac==2)
                        {
                            form.pictureBox8.Show();
                        }
                        if (brojac==3)
                        {
                            form.pictureBox9.Show();
                        }
                }
            }
            public void prikazi_karte()
            {
                for (int i = 0; i < 2; i++)
                {
                    //KARO//
                    if (prvi_igrac[i] == "As Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\A-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Dva Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\2-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Tri Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\3-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Cetiri Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\4-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Pet Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\5-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sest Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\6-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sedam Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\7-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Osam Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\8-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Devet Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\9-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Deset Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\10-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Zandar Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\J-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kraljica Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\Q-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kralj Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\K-k.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    //HERC//
                    if (prvi_igrac[i] == "As Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\A-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Dva Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\2-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Tri Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\3-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Cetiri Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\4-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Pet Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\5-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sest Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\6-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sedam Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\7-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Osam Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\8-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Devet Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\9-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Deset Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\10-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Zandar Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\J-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kraljica Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Q-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kralj Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\K-h.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    //TREF//
                    if (prvi_igrac[i] == "As Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\A-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Dva Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\2-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Tri Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\3-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Cetiri Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\4-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Pet Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\5-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sest Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\6-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sedam Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\7-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Osam Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\8-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Devet Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\9-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Deset Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\10-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Zandar Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\J-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kraljica Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\Q-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kralj Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\K-t.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    //PIK//
                    if (prvi_igrac[i] == "As Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\A-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Dva Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\2-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Tri Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\3-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Cetiri Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\4-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Pet Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\5-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sest Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\6-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Sedam Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\7-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Osam Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\8-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Devet Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\9-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Deset Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\10-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Zandar Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\J-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kraljica Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\Q-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                    if (prvi_igrac[i] == "Kralj Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\K-p.png");
                        if (i == 0)
                        {
                            form.pictureBox1.Image = slika;
                        }
                        else
                        {
                            form.pictureBox2.Image = slika;
                        }
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    //KARO//
                    if (drugi_igrac[i] == "As Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\A-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Dva Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\2-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Tri Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\3-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Cetiri Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\4-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Pet Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\5-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sest Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\6-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sedam Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\7-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Osam Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\8-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Devet Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\9-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Deset Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\10-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Zandar Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\J-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kraljica Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\Q-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kralj Karo")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_karo\\K-k.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    //HERC//
                    if (drugi_igrac[i] == "As Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\A-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Dva Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\2-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Tri Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\3-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Cetiri Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\4-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Pet Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\5-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sest Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\6-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sedam Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\7-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Osam Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\8-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Devet Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\9-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Deset Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\10-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Zandar Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\J-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kraljica Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\Q-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kralj Herc")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_herc\\K-h.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    //TREF//
                    if (drugi_igrac[i] == "As Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\A-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Dva Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\2-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Tri Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\3-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Cetiri Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\4-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Pet Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\5-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sest Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\6-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sedam Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\7-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Osam Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\8-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Devet Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\9-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Deset Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\10-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Zandar Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\J-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kraljica Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\Q-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kralj Tref")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_tref\\K-t.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    //PIK//
                    if (drugi_igrac[i] == "As Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\A-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Dva Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\2-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Tri Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\3-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Cetiri Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\4-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Pet Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\5-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sest Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\6-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Sedam Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\7-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Osam Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\8-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Devet Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\9-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Deset Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\10-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Zandar Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\J-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kraljica Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\Q-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                    if (drugi_igrac[i] == "Kralj Pik")
                    {
                        Bitmap slika = new Bitmap("C:\\C#\\Poker\\Karte_pik\\K-p.png");
                        if (i == 0)
                        {
                            form.pictureBox3.Image = slika;
                        }
                        else
                        {
                            form.pictureBox4.Image = slika;
                        }
                    }
                }
            }
        }
    }
}
