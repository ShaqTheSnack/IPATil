using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IPATil
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region CheckBox
        public void KlasseABox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void KlasseBBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void KlasseCBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        #endregion
         
        #region Uddeler nøgler og værdier 
        //Nøglen er /20++   //Værdien er Textboxen som er i KlasseA().klasseA20(textBox)
        private Dictionary<string, Action<TextBox>> KlasserneIA = new Dictionary<string, Action<TextBox>>
        {
            { "/20", (textBox) => new KlasseA().klasseA20(textBox) },
            { "/21", (textBox) => new KlasseA().klasseA21(textBox) },
            { "/22", (textBox) => new KlasseA().klasseA22(textBox) },
            { "/23", (textBox) => new KlasseA().klasseA23(textBox) },
            { "/24", (textBox) => new KlasseA().klasseA24(textBox) },
            { "/25", (textBox) => new KlasseA().klasseA25(textBox) },
            { "/26", (textBox) => new KlasseA().klasseA26(textBox) },
            { "/27", (textBox) => new KlasseA().klasseA27(textBox) },
            { "/28", (textBox) => new KlasseA().klasseA28(textBox) },
            { "/29", (textBox) => new KlasseA().klasseA29(textBox) },
            { "/30", (textBox) => new KlasseA().klasseA30(textBox) },
            { "/31", (textBox) => new KlasseA().klasseA31(textBox) },

    };

        private Dictionary<string, Action<TextBox>> KlasserneIB = new Dictionary<string, Action<TextBox>>
        {
            { "/20", (textBox) => new KlasseB().klasseB20(textBox) },
            { "/21", (textBox) => new KlasseB().klasseB21(textBox) },
            { "/22", (textBox) => new KlasseB().klasseB22(textBox) },
            { "/23", (textBox) => new KlasseB().klasseB23(textBox) },
            { "/24", (textBox) => new KlasseB().klasseB24(textBox) },
            { "/25", (textBox) => new KlasseB().klasseB25(textBox) },
            { "/26", (textBox) => new KlasseB().klasseB26(textBox) },
            { "/27", (textBox) => new KlasseB().klasseB27(textBox) },
            { "/28", (textBox) => new KlasseB().klasseB28(textBox) },
            { "/29", (textBox) => new KlasseB().klasseB29(textBox) },
            { "/30", (textBox) => new KlasseB().klasseB30(textBox) },
            { "/31", (textBox) => new KlasseB().klasseB31(textBox) },
        };

        private Dictionary<string, Action<TextBox>> KlasserneIC = new Dictionary<string, Action<TextBox>>
        {
            { "/20", (textBox) => new KlasseC().klasseC20(textBox) },
            { "/21", (textBox) => new KlasseC().klasseC21(textBox) },
            { "/22", (textBox) => new KlasseC().klasseC22(textBox) },
            { "/23", (textBox) => new KlasseC().klasseC23(textBox) },
            { "/24", (textBox) => new KlasseC().klasseC24(textBox) },
            { "/25", (textBox) => new KlasseC().klasseC25(textBox) },
            { "/26", (textBox) => new KlasseC().klasseC26(textBox) },
            { "/27", (textBox) => new KlasseC().klasseC27(textBox) },
            { "/28", (textBox) => new KlasseC().klasseC28(textBox) },
            { "/29", (textBox) => new KlasseC().klasseC29(textBox) },
            { "/30", (textBox) => new KlasseC().klasseC30(textBox) },
            { "/31", (textBox) => new KlasseC().klasseC31(textBox) },
        };
        #endregion

        #region Checker om Mine Checkbox er cheked og hvis den er så udfører den koden til min combo box
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Betyder hvis den ikke er null er der valgt noget
            if (ComboBox1.SelectedItem != null)
            {
                string ValgteTing = ((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString();

                if (KlasseBBox.IsChecked == true)
                {
                    if (KlasserneIB.ContainsKey(ValgteTing))
                    {
                        KlasserneIB[ValgteTing].Invoke(OutputTextBox);
                    }
                }
                else if (KlasseCBox.IsChecked == true)
                {
                    if (KlasserneIC.ContainsKey(ValgteTing))
                    {
                        KlasserneIC[ValgteTing].Invoke(OutputTextBox);
                    }
                }
                else
                {   //Hvis KlasseCBox er markeret, og ValgteTing
                    //findes som en nøgle i KlasserneIC, udføres
                    //den tilknyttede handling ved hjælp af Invoke-metoden.
                    if (KlasserneIA.ContainsKey(ValgteTing))
                    {
                        KlasserneIA[ValgteTing].Invoke(OutputTextBox);
                    }
                }
            }
        }


        #endregion
    }
}
