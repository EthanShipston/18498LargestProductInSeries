/* Ethan Shipston
 * ICS4U
 * June 17, 2019
 * Finds the thirteen adjacent digits in a 1000-digit number that have the greatest product.
 */
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

namespace _184988LargestProductInSeries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string bigNum = "73167176531330624919225119674426574742355349194934" +
                            "96983520312774506326239578318016984801869478851843" +
                            "85861560789112949495459501737958331952853208805511" +
                            "12540698747158523863050715693290963295227443043557" +
                            "66896648950445244523161731856403098711121722383113" +
                            "62229893423380308135336276614282806444486645238749" +
                            "30358907296290491560440772390713810515859307960866" +
                            "70172427121883998797908792274921901699720888093776" +
                            "65727333001053367881220235421809751254540594752243" +
                            "52584907711670556013604839586446706324415722155397" +
                            "53697817977846174064955149290862569321978468622482" +
                            "83972241375657056057490261407972968652414535100474" +
                            "82166370484403199890008895243450658541227588666881" +
                            "16427171479924442928230863465674813919123162824586" +
                            "17866458359124566529476545682848912883142607690042" +
                            "24219022671055626321111109370544217506941658960408" +
                            "07198403850962455444362981230987879927244284909188" +
                            "84580156166097919133875499200524063689912560717606" +
                            "05886116467109405077541002256983155200055935729725" +
                            "71636269561882670428252483600823257530420752963450";
            int[] products = new int[13];
            int[] biggestProd = new int[13];
            int sum;
            int biggest = 0;
            int count = 0;
            bool done = false;
            while (done == false)
            {
                if (count + 12 == bigNum.Length)
                {
                    done = true;
                }
                else
                {
                    for (int i = 0; i < 13; i++)
                    {
                        int.TryParse(bigNum.Substring(count + i, 1), out products[i]);
                    }

                    sum = products[0]
                        * products[1]
                        * products[2]
                        * products[3]
                        * products[4]
                        * products[5]
                        * products[6]
                        * products[7]
                        * products[8]
                        * products[9]
                        * products[10]
                        * products[11]
                        * products[12];

                    if (biggest < sum)
                    {
                        biggest = sum;
                        for (int i = 0; i < 13; i++)
                        {
                            biggestProd[i] = products[i];
                        }

                    }
                }
                
                count++;
            }
            MessageBox.Show("Biggest sum: " + biggest.ToString() + "\nProducts: " + biggestProd[0] + " x " +
                biggestProd[1] + " x " +
                biggestProd[2] + " x " +
                biggestProd[3] + " x " +
                biggestProd[4] + " x " +
                biggestProd[5] + " x " +
                biggestProd[6] + " x " +
                biggestProd[7] + " x " +
                biggestProd[8] + " x " +
                biggestProd[9] + " x " +
                biggestProd[10] + " x " +
                biggestProd[11] + " x " +
                biggestProd[12]);
        }
    }
}
