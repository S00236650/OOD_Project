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

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData db = new GameData("DarkSoulsGames");

        public MainWindow()
        {
            InitializeComponent();
            Create();
        }

        void Create()
        {
            var ds1Bosses = from boss in db.Bosses
                            where boss.BossID >= 1 && boss.BossID <= 27
                            select boss.BossName;

            lbxDs1Bosses.ItemsSource = ds1Bosses.ToList();

            var ds3Bosses = from boss in db.Bosses
                            where boss.BossID > 27
                            select boss.BossName;

            lbxDs3Bosses.ItemsSource = ds3Bosses.ToList();

            lbxDs1Bosses.SelectedIndex = 0;
            lbxDs3Bosses.SelectedIndex = 0;
        }

        public ImageSource ConvertStringToImageSource(string imagePath)
        {
            try
            {
                // Create a new BitmapImage
                BitmapImage imageSource = new BitmapImage();

                // Set the image source URI
                imageSource.BeginInit();
                imageSource.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                imageSource.EndInit();

                // Return the created BitmapImage as ImageSource
                return imageSource;
            }
            catch
            {
                // Handle any exceptions that may occur during conversion
                return null;
            }
        }

        public string ConvertStatsToString(Boss b)
        {
            string weaknesses = b.Weakness1;
            string drops = b.Drop1;

            if (b.Weakness2 != null)
                weaknesses += ("\n" + b.Weakness2);
            if (b.Weakness3 != null)
                weaknesses += ("\n" + b.Weakness3);
            if (b.Weakness4 != null)
                weaknesses += ("\n" + b.Weakness4);
            if (b.Weakness5 != null)
                weaknesses += ("\n" + b.Weakness5);
            if (b.Weakness6 != null)
                weaknesses += ("\n" + b.Weakness6);

            if (b.Drop2 != null)
                drops += ("\n" + b.Drop2);
            if (b.Drop3 != null)
                drops += ("\n" + b.Drop3);
            if (b.Drop4 != null)
                drops += ("\n" + b.Drop4);
            if (b.Drop5 != null)
                drops += ("\n" + b.Drop5);

            return "Location: " + b.Location + "\n\n" +
                "Health: " + b.Health.ToString() + "\n\n" +
                "Souls: " + b.Souls + "\n\n" +
                "Drops: " + drops + "\n\n" +
                "Weaknesses: " + weaknesses;
        }

        private void lbxDs1Bosses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Boss selected = null;

            foreach (Boss b in db.Bosses)
            {
                if (lbxDs1Bosses.SelectedItem.ToString() == b.BossName)
                {
                    selected = b;
                    break;
                }
            }

            if (selected != null)
            {
                imgDs1BossImage.Source = ConvertStringToImageSource(selected.ImageSource);
                tblkDs1BossName.Text = selected.BossName;
                tblkDs1Stats.Text = ConvertStatsToString(selected);
            }
        }

        private void lbxDs3Bosses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Boss selected = null;

            foreach (Boss b in db.Bosses)
            {
                if (lbxDs3Bosses.SelectedItem.ToString() == b.BossName)
                {
                    selected = b;
                    break;
                }
            }

            if (selected != null)
            {
                imgDs3BossImage.Source = ConvertStringToImageSource(selected.ImageSource);
                tblkDs3BossName.Text = selected.BossName;
                tblkDs3Stats.Text = ConvertStatsToString(selected);
            }
        }
    }
}
