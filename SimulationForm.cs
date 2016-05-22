using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPN1LW_v1._2
{
    public partial class SimulationForm : Form
    {

        List<Protein> proteins { get; set; }
        Timer timer;
        Timer timer1; 
        Graphics graphics;
        Bitmap doubleBuffer;
        int step1 = 1;


        Boolean canClickProteins = true;
     
        Boolean userIsGuessing = false;

        Boolean guessingSequence = false;

        // 0 = nema dvizenje; 1 = dvizenje kon sekvencata; 2 = dvizenje nazad na pochetna polozba

    

        public SimulationForm()
        {
            InitializeComponent();
            
            doubleBuffer = new Bitmap(Width, Height);
            graphics = CreateGraphics();
            proteins = new List<Protein>();
            addProteins();
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 5;
            timer.Start();

            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 5;
        }

        

        void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Protein protein in proteins)
            {
                if (protein.isSelected)
                {
                    if (protein.direction == 1)
                    {
                        if (step1 != 60)
                        {
                            protein.MoveForward(step1);
                            step1++;
                            BindProteinButton.Enabled = false; // proveri
                            UnbindProteinButton.Enabled = false; // proveri
                            
                        }
                        else
                        {
                            step1 = 1;
                            protein.isBound = true;
                            if (protein.hasSecondaryProtein)
                            {
                                userIsGuessing = true;
                                canClickProteins = false;
                                BindProteinButton.Enabled = false;
                            }
                            else
                            {
                                userIsGuessing = false;
                                canClickProteins = true;
                                BindProteinButton.Enabled = true;
                            }
                            protein.direction = 0;
                            
                            UnbindProteinButton.Enabled = true;
                            timer1.Stop();
                        }
                    }
                    else if (protein.direction == 2)
                    {
                        if (step1 != 60)
                        {
                            protein.MoveBackward(step1);
                            step1++;
                        }
                        else
                        {   
                            step1 = 1;
                            userIsGuessing = false;
                            protein.isBound = false;
                            canClickProteins = true;
                            protein.direction = 0;
                            BindProteinButton.Enabled = true;
                            UnbindProteinButton.Enabled = false;
                            timer1.Stop();
                        }
                    }
                }
            }
           
        }

        String complement(String str)
        {
            String newstr = "";
            foreach (Char c in str)
            {
                if (c == 'A')
                    newstr += "T";
                else if (c == 'T')
                    newstr += "A";
                else if (c == 'C')
                    newstr += "G";
                else if (c == 'G')
                    newstr += 'C';
                else
                    newstr += "$"; // kontrola na greshka
            }

            return newstr;
        }

        void addProteins()
        {
            String p300_description = "p300 протеинот, исто така познат под имињата E1A сврзувачки протеин или EP300, е протеин кој игра огромна улога во регулирањето на растот и делбата на клетките, односно во нивното созревање и диференцијација. Како таков, тој е еден од најрелевантните транскрипциски фактори на генот OPN1LW. Неговите мутации може да го нарушат нормалниот раст на клетките и да придонесат до појава на рак. Генот за производство на овој протеин се наоѓа на 22-риот човеков хромозом.";
            String Arnt_description = "ARNT генот го енкодира протеинот наречен Aryl hydrocarbon receptor nuclear translocator кој е потребен за нормална работа на арил-хидројаглеродните рецептори наклетките, односно, во нашиот случај, игра огромна улога во овозможувањето на фотопигментите да апсорбираат црвена светлина.";
            String FOX04_description = "FOX01 генот е еден од најважните транскрипциски фактори (општо) во човековиот геном. Освен неговата улога како транс. фактор на OPN1LW генот, тој има и голема улога во регулирање на глукогеогенезата, односно креирањето на глукоген во телото.";
            String STAT1_description = "STAT1 генот припаѓа на фамилијата гени STAT. На него најчесто се врзуваат интерферони кои се всушност сигнални протеини кои клетките ги произведуваат како одговор на присуството на патогени: вируси, бактерии или паразити. Овие сигнални протеини на околните клетки им посочуваат да ги зацврстат своите анти-вирални одбранбени механизми.";
            Protein p300 = new Protein("p300", p300_description, 40, 80, 585, 275, 10, Color.SandyBrown, true);
            Protein Arnt = new Protein("Arnt", Arnt_description, 40, 110, 775, 275, 10, Color.Silver, false);
            Protein FOX04 = new Protein("FOX04", FOX04_description, 40, 140, 445, 275, 10, Color.DarkSalmon, true);
            Protein STAT1 = new Protein("STAT1", STAT1_description, 40, 170, 515, 275, 10, Color.Wheat, true);
            p300.setSecondaryProteinInfo(760, 250); // gi davame koordinatite na pravoagolnikot
            FOX04.setSecondaryProteinInfo(900, 250);
            STAT1.setSecondaryProteinInfo(1110, 250);
            p300.instructionText = "За успешно сврзување на p300, потребни се две локации: едната на 11398 базни парови по почетокот на дадената секвенца, а другата на 17203 базни парови. Првата е претставена на цртежот. Прво внесете ја комплементарната сврзувачка секвенца, па потоа кликнете на соодветниот регион каде се наоѓа втората локација, имајќи предвид дека секој регион означува 2000 базни парови, за да продолжите со анимацијата.";
            Arnt.instructionText = "За успешно сврзување на Arnt, потребна е само една локација: 16403 базни парови по почетокот на дадената секвенца. Овој протеин се врзува во 9-тиот регион.";
            FOX04.instructionText = "За успешно сврзување на FOX04, потребни се две локации: едната на 7516 базни парови по почетокот на дадената секвенца, а другата на 21289 базни парови. Првата е претставена на цртежот. Прво внесете ја комплементарната сврзувачка секвенца, па потоа кликнете на соодветниот регион каде се наоѓа втората локација, имајќи предвид дека секој регион означува 2000 базни парови, за да продолжите со анимацијата.";
            STAT1.instructionText = "За успешно сврзување на STAT1, потребни се две локации: едната на 9424 базни парови по почетокот на дадената секвенца, а другата на 27094 базни парови. Првата е претставена на цртежот. Прво внесете ја комплементарната сврзувачка секвенца, па потоа кликнете на соодветниот регион каде се наоѓа втората локација, имајќи предвид дека секој регион означува 2000 базни парови, за да продолжите со анимацијата.";
            p300.additionalInfo = "Прва локација: 11398 bp" + "\r\n" + "секвенца: GCAGGGAATGTGAC" + "\r\n" + "Втора локација: 17203 bp" + "\r\n" + "секвенца: CCAAGGAGTGCGGG";
            p300.sequence = complement("CCAAGGAGTGCGGG");
            Arnt.additionalInfo = "Локација: 16403 bp" + "\r\n" + "секвенца: TGGGGACACACGTGCCCCCAC";
            Arnt.sequence = complement("TGGGGACACACGTGCCCCCAC");
            FOX04.additionalInfo = "Прва локација:  7516 bp" + "\r\n" + "секвенца: TATGTTTACAT" + "\r\n" + "Втора локација: 21289 bp" + "\r\n" + "секвенца: ATAAACATCCC";
            FOX04.sequence = complement("ATAAACATCCC");
            STAT1.additionalInfo = "Прва локација:  7516 bp" + "\r\n" + "секвенца: 	GATTTCCA" + "\r\n" + "Втора локација: 21289 bp" + "\r\n" + "секвенца: TTCCCGGAGGAGAC";
            STAT1.sequence = complement("TTCCCGGAGGAGAC");
            proteins.Add(p300);
            proteins.Add(Arnt);
            proteins.Add(FOX04);
            proteins.Add(STAT1);
        }

        void drawSequence(Graphics g)
        {
            for (int i = 0; i < 15; i++)
            {
                if(i%2 == 0)
                    g.FillRectangle(Brushes.Red, 200 + 70*i, 250, 70, 50);
                else
                    g.FillRectangle(Brushes.Green, 200 + 70*i, 250, 70, 50);
            }
        }

        void drawOutlines(Graphics g)
        {

            Pen pen = new Pen(Color.RoyalBlue, 5);
            g.DrawRectangle(pen, 20, 20, 100, 300);

            pen.Dispose();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
         
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.AliceBlue);

            drawSequence(g);
            drawOutlines(g);

            int count = 0;
          

            foreach (Protein p in proteins)
            {
                p.Draw(g);
                if (p.isSelected)
                {
                    count++;
                    if (canClickProteins)
                    {
                        if (!p.isBound)
                        {
                            BindProteinButton.Enabled = true;
                            BindProteinButton.Text = "Сврзи го протеинот " + p.name;
                        }
                        else
                            UnbindProteinButton.Enabled = true;

                    }
                    ProteinInformationLabel.Text = p.description;
                    ProteinInformationLabel.Font = new Font("Calibri", 15, FontStyle.Regular);
                    AdditionalInfoLabel.Text = p.additionalInfo;
                    AdditionalInfoLabel.Font = new Font("Calibri", 15, FontStyle.Regular);
                }
            }

            if (count == 0)
            {
                BindProteinButton.Enabled = false;
                BindProteinButton.Text = "Сврзи го протеинот ";
                ProteinInformationLabel.Text = "Селектирајте некој протеин";
                ProteinInformationLabel.Font = new Font("Calibri", 27.75f, FontStyle.Regular);
            }

            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);

        }

       

        private void SimulationForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && canClickProteins)
            {
                
                foreach (Protein protein in proteins)
                {
                    if (protein.lastSelected && protein.isSelected && protein.isClickable)
                    {
                        protein.Select(e.Location);
                        protein.isSelected = false;
                    }
                }

                foreach (Protein protein in proteins) // DOVRSHI SO SITE GUESSES
                {
                    protein.Select(e.Location);
               
                }

                foreach (Protein protein in proteins)
                {
                    if (protein.isSelected) 
                    {
                        if (protein.isClickable)
                        {
                            if (protein.isBound)
                                UnbindProteinButton.Enabled = true;
                            else
                                BindProteinButton.Enabled = true;

                        }
                    
                    }
                    
                }
            }
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timer1.Stop();
        }

        private void BindProteinButton_Click(object sender, EventArgs e)
        {
     
            canClickProteins = false;
            SequenceTextBox.Enabled = true;
            for (int i = 0; i < proteins.Count; i++)
            {
                if (proteins[i].isSelected)
                {

                    proteins[i].direction = 1;
                    InstructionsLabel.Text = proteins[i].instructionText;
                    InstructionsLabel.Font = new Font("Calibri", 12.75f, FontStyle.Regular);
                    AdditionalInfoLabel.Text = proteins[i].additionalInfo;
                    guessingSequence = true; // PROMENA 2
                    timer1.Start();
                }
            }

  
        }

        private void UnbindProteinButton_Click(object sender, EventArgs e)
        {

            Boolean startTimer = false;
            String prtnName = "";
            SequenceTextBox.Enabled = false;
            for (int i = 0; i < proteins.Count; i++)
            {
                if (proteins[i].isSelected)
                {
                    proteins[i].direction = 2;
                    prtnName = proteins[i].name;
                    startTimer = true;
                }
            }

            for (int i=0; i < proteins.Count; i++)
            {
                if (proteins[i].name.Equals(prtnName) && !proteins[i].isClickable)
                    proteins.Remove(proteins[i]);
                
            }

            

            if (startTimer)
                timer1.Start();
        }

        private void SimulationForm_MouseDoubleClick(object sender, MouseEventArgs e) // DVOEN KLIK !!!!!!!!!!!!!!!!!!!!
        {
            Boolean addProtein = false;
            Protein tmp = new Protein();
            Point point = e.Location;
            if (userIsGuessing && !guessingSequence) // PROMENA 
            {
              
                foreach (Protein protein in proteins)
                {
                    if (protein.isSelected)
                    {
                        if (point.X >= protein.secondaryProteinX && point.X <= protein.secondaryProteinX + 70 &&
                            point.Y >= protein.secondaryProteinY && point.Y <= protein.secondaryProteinY + 50)
                        {
                            canClickProteins = true;
                            InstructionsLabel.Text = protein.correctText;
                            tmp = protein;
                            addProtein = true;
                        }
                        else
                        {
                            canClickProteins = false;
                            InstructionsLabel.Text = protein.incorrectText;
                        }
                    }
                }

                if (addProtein)
                {
                    if (tmp.name.Equals("p300"))
                    {
                        Protein secondaryProtein = new Protein(tmp.name, tmp.description, tmp.secondaryProteinX + 55, tmp.secondaryProteinY + 23, 0, 0, 10, tmp.color, false);
                        secondaryProtein.isClickable = false;
                        secondaryProtein.sequence = complement("CCAAGGAGTGCGGG");
                        proteins.Add(secondaryProtein);
                    }
                    else if (tmp.name.Equals("FOX04"))
                    {
                        Protein secondaryProtein = new Protein(tmp.name, tmp.description, tmp.secondaryProteinX + 35, tmp.secondaryProteinY + 23, 0, 0, 10, tmp.color, false);
                        secondaryProtein.isClickable = false;
                        secondaryProtein.sequence = complement("ATAAACATCCC");
                        proteins.Add(secondaryProtein);
                    }
                    else if (tmp.name.Equals("STAT1"))
                    {
                        Protein secondaryProtein = new Protein(tmp.name, tmp.description, tmp.secondaryProteinX + 35, tmp.secondaryProteinY + 23, 0, 0, 10, tmp.color, false);
                        secondaryProtein.isClickable = false;
                        secondaryProtein.sequence = complement("TTCCCGGAGGAGAC");
                        proteins.Add(secondaryProtein);
                    }

                }
            }
        }

        private void SequenceGuessButton_Click(object sender, EventArgs e)
        {
            Protein protein = new Protein();
            foreach (Protein p in proteins)
            {
                if (p.isSelected)
                    protein = p;
            }
            // if (SequenceTextBox.Text.Equals("") || SequenceTextBox.Text == null) error provider ako ima vreme
            if (SequenceTextBox.Text.ToUpper().Equals(protein.sequence))
            {
                guessingSequence = false;
                InstructionsLabel.Text = "Одлично! Сега со двоен клик изберете го регионот на цртежот.";
            }
            else
                InstructionsLabel.Text = "Обидете се повторно.";
            
        }

        private void StartTranscriptionButton_Click(object sender, EventArgs e)
        {

            int count = 0;

            foreach (Protein protein in proteins)
            {
                if (protein.isBound && protein.isClickable)
                    count++;
            }

            if (count == 4)
            {
                // ovde rabotAj


            }
            else
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи не се сите транскрипциски фактори сврзани на соодветните места во геномот. Вратете се назад и следете ги инструкциите.", "Транскрипција на OPN1LW");
            }
            
        }

       
    }
}
