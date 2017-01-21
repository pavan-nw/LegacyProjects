using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace anthemsuite
{
    public partial class Page1 : PhoneApplicationPage
    {
        string india = "Jana-gana-mana-adhinayaka, jaya he\nBharata-bhagya-vidhata\nPunjab-Sindhu-Gujarata-Maratha-\nDravida-Utkala-Banga\nVindhya-Himachala-Yamuna-Ganga\nUchchala-Jaladhi-taranga\nTava shubha name jage\nTava shubha ashish maange\nGahe tava jaya-gatha\nJana-gana-mangala-dayaka jaya he\nBharata-bhagya-vidhata\nJaya he, jaya he, jaya he \nJaya jaya jaya, jaya he !";

        string srilanka = "Sri Lanka Matha,\napa Sri Lanka, Namo Namo Namo Namo Matha\nSundara siri barini,Surendi athi Sobamana Lanka\nDhanya dhanaya neka mal palathuru piri, Jaya bhoomiya ramya.\nApa hata sapa siri setha sadana, jeewanaye Matha!\nPiliganu mena apa bhakthi pooja,\nNamo Namo Matha.\nApa Sri Lanka,\nNamo Namo Namo Namo Matha\napa Sri.... Lanka, Namo Namo Namo Namo Matha\nObawe apa widya,\nObamaya apa sathya\nObawe apa shakti,\nApa hada thula bhakthi\nOba apa aloke, Aapage anuprane\noba apa jeewana we, Apa muktiya obawe\nNawa jeewana demine\nNnithina apa Pubudu karan matha\nGnana weerya wadawamina ragena yanu\nmena jaya bhoomi kara\nEka mawekuge daru kala bawina\nyamu yamu wee nopama\nPrema wada sama bheda durara da\nNamo Namo Matha\nApa Sri Lanka, Namo Namo Namo Namo Matha.";

        string aus = "Australians all let us rejoice,\nFor we are young and free; \nWe've golden soil and wealth for toil; \nOur home is girt by sea; \nOur land abounds in nature's gifts\nOf beauty rich and rare; \nIn history's page, let every stage\nAdvance Australia Fair. \nIn joyful strains then let us sing, \nAdvance Australia Fair. \n\nBeneath our radiant Southern Cross\nWe'll toil with hearts and hands; \nTo make his Commonwealth of ours\nRenowned of all the lands; \nFor those who've come across the seas\nWe've boundless plains to share; \nWith courage let us all combine\nTo Advance Australia Fair. \nIn joyful strains then let us sing, \nAdvance Australia Fair. \n";

        string uae = "May you live for a people,\nWhose religion is Islam, and whose guide is the Quran, \nMay I strengthen you in the name of God, O homeland, \nMy country, My country, My country, My country. \n";
        string canada = "O Canada!\nOur home and native land! \nTrue patriot love in all thy sons command. \n\nWith glowing hearts we see thee rise, \nThe True North strong and free! \n\nFrom far and wide, \nO Canada, we stand on guard for thee. \n\nGod keep our land glorious and free! \nO Canada, we stand on guard for thee. \n\nO Canada, we stand on guard for thee. \n";
        string japana = "Thousands of years of happy reign be thine; \nRule on, my lord, till what are pebbles now \nBy age united to mighty rocks shall grow \nWho's venerable sides the moss doth line. \n";
        string sa = "Lord, bless Africa\nMay her spirit rise high up\nHear thou our prayers\nLord bless us. \n\nLord, bless Africa\nBanish wars and strife\nLord, bless our nation\nOf South Africa. \n\nRinging out from our blue heavens\nFrom our deep seas breaking round\nOver everlasting mountains\nWhere the echoing crags resound";
        string nepal = "Woven from hundreds of flowers, we are one garland that's Nepali\nSpread sovereign from Mechi to Mahakali\nA playground for nature's wealth unending\nOut of the sacrifice of our braves, a nation free and unyielding\nA land of knowledge, of peace, the plains, hills and mountains tall\nIndivisible, this beloved land of ours, our motherland Nepal\nOf many races, languages, religions, and cultures of incredible sprawl\nThis progressive nation of ours, all hail Nepal";
        string wes = "Forged from the love of liberty\nIn the fires of hope and prayer\nWith boundless faith in our destiny\nWe solemnly declare: \nSide by side we stand\nIslands of the blue Caribbean sea, \nThis our native land\nWe pledge our lives to thee. \nHere every creed and race finds an equal place, \nAnd may God bless our nation\nHere every creed and race find an equal place, \nAnd may God bless our nation.";
        string pak = "Blessed be the sacred land, \nHappy be the bounteous realm, \nSymbol of high resolve, Land of Pakistan. \nBlessed be thou citadel of faith. \nThe Order of this Sacred Land \nIs the might of the brotherhood of the people. \nMay the nation, the country, and the State \nShine in glory everlasting. \nBlessed be the goal of our ambition. \nThis flag of the Crescent and the Star \nLeads the way to progress and perfection, \nInterpreter of our past, glory of our present, \nInspiration of our future, \nSymbol of Almighty's protection. ";
        string eng = "According to Wikipedia, England Do not have official national anthem ";
        public Page1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string country = "";
            if (NavigationContext.QueryString.TryGetValue("msg", out country))
            {
                string c = country;
                if(c.Equals("India"))
                 textBlock1.Text = india;
                else if(c.Equals("Shrilanka"))
                    textBlock1.Text = srilanka;
                else if(c.Equals("Australia"))
                    textBlock1.Text = aus;
                else if(c.Equals("UAE"))
                    textBlock1.Text = uae;
                else if(c.Equals("Canada"))
                    textBlock1.Text = canada;
                else if(c.Equals("Japan"))
                    textBlock1.Text = japana;
                else if(c.Equals("South Africa"))
                    textBlock1.Text = sa;
                else if(c.Equals("Nepal"))
                    textBlock1.Text = nepal;
                else if(c.Equals("England"))
                    textBlock1.Text = eng;
                else if(c.Equals("Pakistan"))
                    textBlock1.Text = pak;
                else if (c.Equals("West Indies"))
                    textBlock1.Text = wes;


                //ApplicationTitle.Text = site1;
            }
        }
    }
}