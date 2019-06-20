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

namespace _11_WPF_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void PreviewKeyDownBttn(object sender, KeyEventArgs e)
        {
            Button bt;
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                foreach (UIElement item in grid1.Children)
                {
                    if (item is Button)
                    {
                        bt = (Button)item;
                        switch (bt.Tag)
                        {
                            case "letter": { bt.Content = bt.Content.ToString().ToUpper(); } break;
                            case "num":
                                {
                                    switch (bt.Content)
                                    {
                                        case "1": { bt.Content = "!"; } break;
                                        case "2": { bt.Content = "@"; } break;
                                        case "3": { bt.Content = "#"; } break;
                                        case "4": { bt.Content = "$"; } break;
                                        case "5": { bt.Content = "%"; } break;
                                        case "6": { bt.Content = "^"; } break;
                                        case "7": { bt.Content = "&"; } break;
                                        case "8": { bt.Content = "*"; } break;
                                        case "9": { bt.Content = "("; } break;
                                        case "0": { bt.Content = ")"; } break;
                                    }
                                }
                                break;
                            case "simb":
                                {
                                    switch (bt.Content)
                                    {
                                        case "`": { bt.Content = "~"; } break;
                                        case "[": { bt.Content = "{"; } break;
                                        case "]": { bt.Content = "}"; } break;
                                        case ";": { bt.Content = ":"; } break;
                                        case "'": { bt.Content = "\""; } break;
                                        case "\\": { bt.Content = "|"; } break;
                                        case ",": { bt.Content = "<"; } break;
                                        case ".": { bt.Content = ">"; } break;
                                        case "/": { bt.Content = "?"; } break;

                                    }
                                }
                                break;
                        }
                    }
                }
            }
        }

        public void PreviewKeyUpBttn(object sender, KeyEventArgs e)
        {
            Button bt;
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                foreach (UIElement item in grid1.Children)
                {
                    if (item is Button)
                    {
                        bt = (Button)item;
                        switch (bt.Tag)
                        {
                            case "letter": { bt.Content = bt.Content.ToString().ToLower(); } break;
                            case "num":
                                {
                                    switch (bt.Content)
                                    {
                                        case "!": { bt.Content = "1"; } break;
                                        case "@": { bt.Content = "2"; } break;
                                        case "#": { bt.Content = "3"; } break;
                                        case "$": { bt.Content = "4"; } break;
                                        case "%": { bt.Content = "5"; } break;
                                        case "^": { bt.Content = "6"; } break;
                                        case "&": { bt.Content = "7"; } break;
                                        case "*": { bt.Content = "8"; } break;
                                        case "(": { bt.Content = "9"; } break;
                                        case ")": { bt.Content = "0"; } break;
                                    }
                                }
                                break;
                            case "simb":
                                {
                                    switch (bt.Content)
                                    {
                                        case "~": { bt.Content = "`"; } break;
                                        case "{": { bt.Content = "["; } break;
                                        case "}": { bt.Content = "]"; } break;
                                        case ":": { bt.Content = ";"; } break;
                                        case "\"": { bt.Content = "'"; } break;
                                        case "|": { bt.Content = "\\"; } break;
                                        case "<": { bt.Content = ","; } break;
                                        case ">": { bt.Content = "."; } break;
                                        case "?": { bt.Content = "/"; } break;

                                    }
                                }
                                break;
                        }
                    }
                }
            }
        }
        }
}
