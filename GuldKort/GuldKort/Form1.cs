using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace GuldKort
{
    public partial class Form1 : Form
    {
        List<string> Itemsaver = new List<string>();  // varje rad i textfilen kundlista.txt sparas i den här listan för vidraeberabening.
        List<string> itemSaver = new List<string>();  // varje rad i textfilen kortlista.txt sparas i den här listan för vidraeberabening.


        Konto<string> konto = new Konto<string>("", "");   // En objekt för klassen Konto för att kunna nå fram medlemer som finns i klassen 
        Kort<string> kort = new Kort<string>("","");   // En objekt för klassen kort för att kunna nå fram medlemer som finns i klassen 

        List<Kort<string>> AllKorten = new List<Kort<string>>();  // Alla information som finns i textfilen kortlista.txt sparas i den här listan
        List<Konto<string>> AllKonto = new List<Konto<string>>(); // Alla information som finns i textfilen kundlista.txt sparas i den här listan

        TcpListener Server;   // Med hjälp av den här metoden öppnar jag en server för andra program som vill ansluta till server
        TcpClient Klient;     // Med hjälp av den här metoden kan kommunikationen mellan två progrm äga rum
        int port = 12345;     // portnummer som når servern.


        public Form1()
        {
      
            InitializeComponent();
            txtsmeddlande.ForeColor = SystemColors.GrayText;  // För att ändra färgen på texten som står redan i rutan när man öppnar programmet
            txtsmeddlande.Text = "Skicka ett meddelande till klienten!";  // Meddlenade som står i rutan.

            txtLoggaIn.ForeColor = SystemColors.GrayText;  // samma gäller här men för en annan metod
            txtLoggaIn.Text = "Ange inloggnings 8 tecken!";

            txtskod.ForeColor = SystemColors.GrayText;  // samma gäller här men för en annan metod
            txtskod.Text = "Ange kodens 10 tecken!";

            btnKollaKod.Enabled = false; // inaktivera kolla kod knappen tills först man loggar in
            txtskod.Enabled = false; // inaktivera kolla kod rutan tills man först loggar in

            FileLoader();  // Jag deklarera importingsklass här för att den ska användas hela tiden
          




        }

        public void FileLoader()
        {
            try    // Try-Metod för att hantera oväntade krasch.
            {
                if (File.Exists("kundlista.txt"))    // IF-stasten för att hantera filens existens i datoren innan vi gör något vidare.
                {
                    StreamReader Reader = new StreamReader("kundlista.txt", Encoding.Default, true);  // Stramreader är den metoden som används för att läsa textfilen som finns på datoren.
                    string Rad = "";
                    while ((Rad = Reader.ReadLine()) != null)     // While-Lopp finns här för att gå igenom alla rader som finns i min textfil.
                    {
                        Itemsaver.Add(Rad);   // Varje rad i textfilen sparas i en lista som ska behandlas efteråt.
                    }
                    Reader.Close();  // För att stänga av Streamreader metoden.

                    foreach (string Separera in Itemsaver) // Med foreach metoden går jag igenom alla rader som finns i Itemsaver-lista.
                    {

                        string[] Vektor = Separera.Split(new string[] { "###" }, StringSplitOptions.None); // En lista som separera ut varja rad i listan till strängvektor. 
                        konto = new Konto<string>(Vektor[1], Vektor[2]); // En objekt som får den första och andra strängen i vektor-lista.
                        konto.användareID[konto.Buffert] = Vektor[0];  // Den sista värdet som objekten tar emot

                        AllKonto.Add(konto);  // Alla värden som jag samlade sättas i en Konto-lista
                    }
                }
                else  // Ifall filen inte hittas skrivs det här meddelandet 
                {
                    MessageBox.Show("Filen med kundars lista hittas inte. Försök igen!");
                }
              
                    
                if (File.Exists("kortlista.txt"))   // samma regler ovanför gäller här
                {
                    StreamReader reader = new StreamReader("kortlista.txt", Encoding.Default, true);   
                    string rad = "";
                    while ((rad = reader.ReadLine()) != null)  
                    {
                        itemSaver.Add(rad);  
                    }
                    reader.Close();

                    foreach (string separera in itemSaver)  
                    {
                  
                        string[] vektor = separera.Split(new string[] { "###" }, StringSplitOptions.None);  
                        if (vektor[1] == "Dunderkatt") // Nu börjar jag dela varje vektor till olika värden för att få att samla allt som finns i kortlistan.txt i kort-lista.
                        {                           
                                Dunderkatt<string> Dunder = new Dunderkatt<string>(konto.namn, konto.omdårde); // En objekt av belöning Dunderkatt som får två värden som förändars vid användning.
                                Dunder.kortetsID[kort.buffert] = vektor[0]; // Ojekten får den första strången i vektor listan 
                                Dunder.belöning = vektor[1];  // Ojekten får den andra strången i vektor listan 

                                AllKorten.Add(Dunder);   // Nu sätter jag alla värden som jag samlade i en kort-lista
                        }

                        if (vektor[1] == "Kristallhast")  // samma gäller här 
                        {
                                Kristallhäst<string> Häst = new Kristallhäst<string>(konto.namn, konto.omdårde);
                                Häst.kortetsID[kort.buffert] = vektor[0];
                                Häst.belöning = vektor[1];

                                AllKorten.Add(Häst);
                            
                        }

                        if (vektor[1] == "Overpanda")   // samma gäller här
                        {
                                Överpanda<string> Panda = new Överpanda<string>(konto.namn, konto.omdårde);
                                Panda.kortetsID[kort.buffert] = vektor[0];
                                Panda.belöning = vektor[1];

                                AllKorten.Add(Panda);
                        }
                        if (vektor[1] == "Eldtomat")   // samma gäller här
                        {
                                    Eldtomat<string> Tomat = new Eldtomat<string>(konto.namn, konto.omdårde);
                                    Tomat.kortetsID[kort.buffert] = vektor[0];
                                    Tomat.belöning = vektor[1];

                                    AllKorten.Add(Tomat);
                              }
                    }
                }
                
            }
            catch (Exception ex)   // catch metod med min egen meddelande och system meddlenade
            {
                MessageBox.Show("Ett oväntat fel inträffade. Försök igen!\n" + ex.Message);
                return;
            }
        }
        private void txtsmeddlande_Enter(object sender, EventArgs e)
        {
            if
            (txtsmeddlande.Text == "Skicka ett meddelande till klienten!")
            {
                txtsmeddlande.Text = "";
                txtsmeddlande.ForeColor = Color.Black;
            }
        }  // när man gå in i eller ut från någons ruta i windows from försvinner det meddlande som fanns där och samma gäller för de andra nere
                                                                            // Och enligt mig det är ett bra sätt att visa användaren vilka information som behövs vid varje process

        private void txtsmeddlande_Leave(object sender, EventArgs e)
        {
            if
               (txtsmeddlande.Text == "")
            {
                txtsmeddlande.Text = "Skicka ett meddelande till klienten!";
                txtsmeddlande.ForeColor = Color.Gray;

            }
        }

        private void txtLoggaIn_Enter(object sender, EventArgs e)
        {
            if
             (txtLoggaIn.Text == "Ange inloggnings 8 tecken!")
            {
                txtLoggaIn.Text = "";
                txtLoggaIn.ForeColor = Color.Black;
            }
        }

        private void txtLoggaIn_Leave(object sender, EventArgs e)
        {
            if
               (txtLoggaIn.Text == "")
            {
                txtLoggaIn.Text = "Ange inloggnings 8 tecken!";
                txtLoggaIn.ForeColor = Color.Gray;

            }
        }

        private void txtskod_Enter(object sender, EventArgs e)
        {
            if
           (txtskod.Text == "Ange kodens 10 tecken!")
            {
                txtskod.Text = "";
                txtskod.ForeColor = Color.Black;
            }
        }

        private void txtskod_Leave(object sender, EventArgs e)
        {
            if
                 (txtskod.Text == "")
            {
                txtskod.Text = "Ange kodens 10 tecken!";
                txtskod.ForeColor = Color.Gray;

            }

        }




        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool sant = false;  // En falsk bool som blir sant när inloggnings upggifter hittas
                for (int i = 0; i < AllKonto.Count; i++)  // for lopp som går igenom alla elemnter som finns i allkonto.listan
                {
                    if (txtLoggaIn.Text == AllKonto[i].användareID[konto.Buffert] && sant == false)  // Om dessa två vilkor stämmer görs nedanför:
                    {
                        btnLoggaIn.Text = "Inloggad";  // byta knappens text med detta meddelande
                        btnLoggaIn.BackColor = Color.LawnGreen; // byta knappens text med denna färg när man loggar in
                        MessageBox.Show("Välkommen " + AllKonto[i].namn + "\nAnge kortets kod i den särskilda rutan!");  // för att välkomnna användare och visa vilket är det andra steget
                        kort.namn = AllKonto[i].namn;  // ta emot namne på den som har AnvändareID 
                        kort.omdårde = AllKonto[i].omdårde;  // ta emot vilket område kommer den som har AnvändareID 
                        btnKollaKod.Enabled = true; // Nu kan man kolla sitt kod efter att man har loggat in och det är ett bra sätt som släpper mycket kod gällande felhantering
                        txtskod.Enabled = true;

                        btnLoggaIn.Enabled = false; // inaktivera kanppen logga in om man är inloggad
                        sant = true; // När inloggningsuppgifter hittas blir bool sant för att avsluta inloggnings process
                       
                    }

                }
                if (sant == false)  // Om boolen fortsätter vara falskt då betyder det att inloggnings uppgifter hittades inte och då vi skriver till användare:
                {
                    MessageBox.Show("Tyvärr, du är inte regerterad än. Försök efter att du har skapat ett konto!");
                    txtLoggaIn.ForeColor = SystemColors.GrayText;  // samma gäller här men för en annan metod
                    txtLoggaIn.Text = "Ange inloggnings 8 tecken!";
                }
               

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ett oväntat fel inträffade. Försök igen!\n" + ex.Message);
                return;
            }

        }

        private async void btnServer_Click(object sender, EventArgs e)  // async metod är för att processorn skulle jobba med andra saker tills användare kommer till det här kods området
        {
            try
            {          
                IPAddress adress = IPAddress.Parse("127.0.0.1");  // min server ip-address som klienten kan ansluta till.
                Server = new TcpListener(adress, port);      // Den här är för att deklarar till servern den specifika ip adressen och portnummret          
                Server.Start();  // server startas med den här metoden
                
                btnServer.BackColor = Color.Green;   // ändra färgen på knappen till grön när den är startas
                btnServer.Text = "Server igång";   // informera om den
                btnServer.Enabled = false; // inaktivera knappen efter att den är igång

                Klient = Server.AcceptTcpClient(); // programmet stannar tills klienten anslutar till servern
                

                while (Klient.Connected)  // När klienten ansluter till servern görs:
                {
                    bool gå = false; // Denna bool förändras vid varje kodblock körs nedanför för att bestämma vilka kodar behöver köras 
                    bool gå2 = false;// Den här boolen används bara när inget som tas emot stämmer med information i filerna
                    byte[] buffer2 = new byte[1024]; // byte storlek

                    int an = await Klient.GetStream().ReadAsync(buffer2, 0, buffer2.Length);  // // Den här metoden är för deklarera vilket Meddelande vill jag få från klienten och omvandla meddelande till bytes
                    txtRecieve.ForeColor = Color.Red;  // jag vill att meddelnde ska visas i röd färgen
                    txtRecieve.Text = Encoding.Unicode.GetString(buffer2, 0, an); // Här får jag mitt meddeleande 

                    string[] vektor = txtRecieve.Text.Split(new string[] { "-" }, StringSplitOptions.None);  // Den här listan är för att dela meddelande som användaren skickar över nätverk
                    // vektor-lista har två strängar så mitt jobb är att ta emot dem båda värderna och kolla om de stämmer med information som finns textfilerna
                    for (int i = 0; i < AllKonto.Count; i++)
                    {
                        if (AllKonto[i].användareID[konto.Buffert].Contains(vektor[0]) && gå == false)  // om inloggningsuppgifter är registrerad och boolen tillåterkörning görs så:
                        {
                            buffer2 = Encoding.Unicode.GetBytes("Välkommen " + AllKonto[i].namn + "!");  // välkomna den som har användareId genom att skriva hans eller hennes namn och skickar den till klient
                            kort.namn = AllKonto[i].namn;  // ta emot värderna för vidare användning
                            kort.omdårde = AllKonto[i].omdårde;
                            await Klient.GetStream().WriteAsync(buffer2, 0, buffer2.Length);  
                            gå = true;  // om den här koden körs så förändras boolen för att inte köra några andra kodar som inte behövs 
                            gå2 = true;  // Om en enda information stämmer så jag behöver inte att köra den sista kodblocket i while loop
                        }
                    }

                    for (int A = 0; A < AllKorten.Count; A++)  // Om användare har en kod som ger ett guldkort men har inte ett kontot görs nedanför:
                    {
                        if (AllKorten[A].kortetsID[kort.buffert].Contains(vektor[1]) && gå == false)  // Här gäller om kortents Id som användare har, stämmer med vad står i kortfilen men själva användaren är inte registrerad
                        {
                            buffer2 = Encoding.Unicode.GetBytes("Ditt kort ger ett Guldkort men du behöver att först skappa ett konta för att kunna se vilket Guldkort du vinner");

                            await Klient.GetStream().WriteAsync(buffer2, 0, buffer2.Length);
                            gå = false; 
                            gå2 = true;  
                        }
                    }
                   
                   

                    for (int A = 0; A < AllKorten.Count; A++)  
                    {
                        if (AllKorten[A].kortetsID[kort.buffert].Contains(vektor[1]) && gå == true)// Om användaren är registread och korten är giltig guldkort gör nedanför:
                        {
                            AllKorten[A].namn = kort.namn;  // samma som tidigare
                            AllKorten[A].omdårde = kort.omdårde;
                            buffer2 = Encoding.Unicode.GetBytes(AllKorten[A].ToString()); // Jag returnerar ToString överride för att gratulera användaren över nätverk

                            await Klient.GetStream().WriteAsync(buffer2, 0, buffer2.Length);
                            gå = false;// om den här koden körs så förändras boolen för att inte köra några andra kodar som behövs inte
                            gå2 = true;  // Eftersom denna koden kördes så vi behöver inte att köra koden som rör sig på boolen gå2
                        }
                    }

                    if (gå == true) // om användare är registrerad men har inte ett guldkort skrivs följande
                    {
                        buffer2 = Encoding.Unicode.GetBytes("Tyvärr, ditt kort ger inte ett Guldkort");
                        await Klient.GetStream().WriteAsync(buffer2, 0, buffer2.Length);
                        
                        
                    }
                    if (gå2 == false)  // om användaren har inte ett konto och har ett kort som inte ett guldkort görs följande
                    {
                        buffer2 = Encoding.Unicode.GetBytes("Tyvärr, du är inte registrerad än. Du kan kolla din kod efter att du har skapat ett konto!");
                        // Jag informaerar inte användare om att hans kort ger inte ett guldkort annars behöver användaren inte skapa kontot och det vill jag inte
                        await Klient.GetStream().WriteAsync(buffer2, 0, buffer2.Length);
                    }

                }

            }
            catch (Exception)  // ifall det finns inga anlutna klienter till servern skrivs följande:
            {
                MessageBox.Show("Det finns inga anslutna klienter till server\n" );
                return;
            }
          
        }

        private async void btnMeddelande_Click(object sender, EventArgs e)
        {
            try
            {
                if (Klient.Connected) // Om koppling med klient har lyckats, görs nedanför:
                {
                    Klient.NoDelay = true; // För att skicka information över nätverk

                    byte[] buffer = new byte[2000 * 2000];  // bytes storlek
                    
                    buffer = Encoding.Unicode.GetBytes(txtsmeddlande.Text); // Den här metoden är för deklarera vilket Meddelande vill jag skicka till servern och omvandla meddelande till bytes

                    await Klient.GetStream().WriteAsync(buffer, 0, buffer.Length);  // Här skickar jag mitt meddelande till klient
                }
            }
            catch (Exception)  // mitt egen meddelande som hanterar oväntat fel
            {
                MessageBox.Show("Klient måste ansluta till servern först för att kunna skicka ett meddelande\n");
                return;
            }
            
        }

        private void btnKollaKod_Click(object sender, EventArgs e)
        {
            try
            {

                bool kör = false;  
                for (int i = 0; i < AllKorten.Count; i++)
                {
                    if (AllKorten[i].kortetsID[kort.buffert].Contains(txtskod.Text) && kör == false)  // om kortsid hittas i kortslista och om boolen stämmer göra nedanför
                    {
                        AllKorten[i].namn = kort.namn;  // dela information som jag fick vid inloggnings process till Allkorten-lista
                        AllKorten[i].omdårde = kort.omdårde;
                        MessageBox.Show(AllKorten[i].ToString());  // Kalla toString metod som är redan fixat för att visa särskilda information
                        kör = true; // ändra värdet på boolen 
                        break;
                    }
                }
                if (kör == false)  // skriva ett meddelande om kortsid hittades inte i kortlista
                {
                    MessageBox.Show("Tyvärr, din kort ger inte ett Guldkort");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
                return;
            }
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            if (btnLoggaIn.Text == "Inloggad")
            {
                btnLoggaIn.Enabled = true;  // För att aktivera loggain knappen igen
                btnLoggaIn.BackColor = SystemColors.Control;// För att ta tillbaka den orginala färger till knappen
                txtLoggaIn.ForeColor = SystemColors.GrayText;  // samma gäller här men för en annan metod
                txtLoggaIn.Text = "Ange inloggnings 8 tecken!";
                btnLoggaIn.Text = "logga in"; // För att ta tillbaka de orden som fanns tidigare 
                txtskod.ForeColor = SystemColors.GrayText;  // samma gäller här men för en annan metod
                txtskod.Text = "Ange kodens 10 tecken!";
                btnKollaKod.Enabled = false; // För att inaktivera kolla kod rutan tills man loggar igen in
                txtskod.Enabled = false;
            }
            else
            {
                MessageBox.Show("Du är inte ens inloggad för att kunna logga ut!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }  // något extra vilket är att visa tiden för användare

        private void skapa_Click(object sender, EventArgs e)
        {
            skapaEttKonto skapa = new skapaEttKonto();
            skapa.Show();
        }


    }
}
