using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Build.Utilities;
using System.Threading;

namespace virtualKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool KeyPreview { get; }
        bool isRunning = true;

        public MainWindow()
        {
            InitializeComponent();
            this.KeyUp += new System.Windows.Input.KeyEventHandler(MainWindow_KeyDown);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //Defining the Color of a button:
            Brush keyDownFG = new SolidColorBrush(Color.FromRgb(44, 47, 51));       //Pressed Foreground
            Brush keyDownBG = new SolidColorBrush(Color.FromRgb(114, 137, 218));    //Pressed Background

            Brush keyUpFG = new SolidColorBrush(Color.FromRgb(114, 137, 218));      //Released Foreground
            Brush keyUpBG = new SolidColorBrush(Color.FromRgb(35, 39, 42));         //Released Background

            switch (e.Key)
            {
                //Number Row
                case Key.OemTilde:
                    {
                        if (Keyboard.IsKeyDown(Key.OemTilde))
                        {
                            Tilde_Button.Foreground = keyDownFG;
                            Tilde_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Tilde_Button.Foreground = keyUpFG;
                            Tilde_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D1:
                    {
                        if (Keyboard.IsKeyDown(Key.D1))
                        {
                            D1_Button.Foreground = keyDownFG;
                            D1_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D1_Button.Foreground = keyUpFG;
                            D1_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D2:
                    {
                        if (Keyboard.IsKeyDown(Key.D2))
                        {
                            D2_Button.Foreground = keyDownFG;
                            D2_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D2_Button.Foreground = keyUpFG;
                            D2_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D3:
                    {
                        if (Keyboard.IsKeyDown(Key.D3))
                        {
                            D3_Button.Foreground = keyDownFG;
                            D3_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D3_Button.Foreground = keyUpFG;
                            D3_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D4:
                    {
                        if (Keyboard.IsKeyDown(Key.D4))
                        {
                            D4_Button.Foreground = keyDownFG;
                            D4_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D4_Button.Foreground = keyUpFG;
                            D4_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D5:
                    {
                        if (Keyboard.IsKeyDown(Key.D5))
                        {
                            D5_Button.Foreground = keyDownFG;
                            D5_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D5_Button.Foreground = keyUpFG;
                            D5_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D6:
                    {
                        if (Keyboard.IsKeyDown(Key.D6))
                        {
                            D6_Button.Foreground = keyDownFG;
                            D6_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D6_Button.Foreground = keyUpFG;
                            D6_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D7:
                    {
                        if (Keyboard.IsKeyDown(Key.D7))
                        {
                            D7_Button.Foreground = keyDownFG;
                            D7_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D7_Button.Foreground = keyUpFG;
                            D7_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D8:
                    {
                        if (Keyboard.IsKeyDown(Key.D8))
                        {
                            D8_Button.Foreground = keyDownFG;
                            D8_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D8_Button.Foreground = keyUpFG;
                            D8_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D9:
                    {
                        if (Keyboard.IsKeyDown(Key.D9))
                        {
                            D9_Button.Foreground = keyDownFG;
                            D9_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D9_Button.Foreground = keyUpFG;
                            D9_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D0:
                    {
                        if (Keyboard.IsKeyDown(Key.D0))
                        {
                            D0_Button.Foreground = keyDownFG;
                            D0_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D0_Button.Foreground = keyUpFG;
                            D0_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemMinus:
                    {
                        if (Keyboard.IsKeyDown(Key.OemMinus))
                        {
                            Subtract_Button.Foreground = keyDownFG;
                            Subtract_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Subtract_Button.Foreground = keyUpFG;
                            Subtract_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemPlus:
                    {
                        if (Keyboard.IsKeyDown(Key.OemPlus))
                        {
                            Plus_Button.Foreground = keyDownFG;
                            Plus_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Plus_Button.Foreground = keyUpFG;
                            Plus_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.Back:
                    {
                        if (Keyboard.IsKeyDown(Key.Back))
                        {
                            Backspace_Button.Foreground = keyDownFG;
                            Backspace_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Backspace_Button.Foreground = keyUpFG;
                            Backspace_Button.Background = keyUpBG;
                        }
                        break;
                    }
                //Top Key Row
                case Key.Tab:
                    {
                        if (Keyboard.IsKeyDown(Key.Tab))
                        {
                            Tab_Button.Foreground = keyDownFG;
                            Tab_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Tab_Button.Foreground = keyUpFG;
                            Tab_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.Q:
                    {
                        if (Keyboard.IsKeyDown(Key.Q))
                        {
                            Q_Button.Foreground = keyDownFG;
                            Q_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Q_Button.Foreground = keyUpFG;
                            Q_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.W:
                    {
                        if (Keyboard.IsKeyDown(Key.W))
                        {
                            W_Button.Foreground = keyDownFG;
                            W_Button.Background = keyDownBG;
                        }
                        else
                        {
                            W_Button.Foreground = keyUpFG;
                            W_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.E:
                    {
                        if (Keyboard.IsKeyDown(Key.E))
                        {
                            E_Button.Foreground = keyDownFG;
                            E_Button.Background = keyDownBG;
                        }
                        else
                        {
                            E_Button.Foreground = keyUpFG;
                            E_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.R:
                    {
                        if (Keyboard.IsKeyDown(Key.R))
                        {
                            R_Button.Foreground = keyDownFG;
                            R_Button.Background = keyDownBG;
                        }
                        else
                        {
                            R_Button.Foreground = keyUpFG;
                            R_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.T:
                    {
                        if (Keyboard.IsKeyDown(Key.T))
                        {
                            T_Button.Foreground = keyDownFG;
                            T_Button.Background = keyDownBG;
                        }
                        else
                        {
                            T_Button.Foreground = keyUpFG;
                            T_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.Y:
                    {
                        if (Keyboard.IsKeyDown(Key.Y))
                        {
                            Y_Button.Foreground = keyDownFG;
                            Y_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Y_Button.Foreground = keyUpFG;
                            Y_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.U:
                    {
                        if (Keyboard.IsKeyDown(Key.U))
                        {
                            U_Button.Foreground = keyDownFG;
                            U_Button.Background = keyDownBG;
                        }
                        else
                        {
                            U_Button.Foreground = keyUpFG;
                            U_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.I:
                    {
                        if (Keyboard.IsKeyDown(Key.I))
                        {
                            I_Button.Foreground = keyDownFG;
                            I_Button.Background = keyDownBG;
                        }
                        else
                        {
                            I_Button.Foreground = keyUpFG;
                            I_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.O:
                    {
                        if (Keyboard.IsKeyDown(Key.O))
                        {
                            O_Button.Foreground = keyDownFG;
                            O_Button.Background = keyDownBG;
                        }
                        else
                        {
                            O_Button.Foreground = keyUpFG;
                            O_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.P:
                    {
                        if (Keyboard.IsKeyDown(Key.P))
                        {
                            P_Button.Foreground = keyDownFG;
                            P_Button.Background = keyDownBG;
                        }
                        else
                        {
                            P_Button.Foreground = keyUpFG;
                            P_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemOpenBrackets:
                    {
                        if (Keyboard.IsKeyDown(Key.OemOpenBrackets))
                        {
                            OpenBracket_Button.Foreground = keyDownFG;
                            OpenBracket_Button.Background = keyDownBG;
                        }
                        else
                        {
                            OpenBracket_Button.Foreground = keyUpFG;
                            OpenBracket_Button.Background = keyUpBG;
                        }
                        break;
                    }
                case Key.OemCloseBrackets:
                    {
                        if (Keyboard.IsKeyDown(Key.OemCloseBrackets))
                        {
                            CloseBracket_Button.Foreground = keyDownFG;
                            CloseBracket_Button.Background = keyDownBG;
                        }
                        else
                        {
                            CloseBracket_Button.Foreground = keyUpFG;
                            CloseBracket_Button.Background = keyUpBG;
                        }
                        break;
                    }


                case Key.OemBackslash:
                    {
                        if (Keyboard.IsKeyDown(Key.OemBackslash))
                        {
                            Backslash1_Button.Foreground = keyDownFG;
                            Backslash1_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Backslash1_Button.Foreground = keyUpFG;
                            Backslash1_Button.Background = keyUpBG;
                        }
                        break;
                    }

                // Home Row Keys
                case Key.A:
                    {
                        if (Keyboard.IsKeyDown(Key.A))
                        {
                            A_Button.Foreground = keyDownFG;
                            A_Button.Background = keyDownBG;
                        }
                        else
                        {
                            A_Button.Foreground = keyUpFG;
                            A_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.S:
                    {
                        if (Keyboard.IsKeyDown(Key.S))
                        {
                            S_Button.Foreground = keyDownFG;
                            S_Button.Background = keyDownBG;
                        }
                        else
                        {
                            S_Button.Foreground = keyUpFG;
                            S_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.D:
                    {
                        if (Keyboard.IsKeyDown(Key.D))
                        {
                            D_Button.Foreground = keyDownFG;
                            D_Button.Background = keyDownBG;
                        }
                        else
                        {
                            D_Button.Foreground = keyUpFG;
                            D_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.F:
                    {
                        if (Keyboard.IsKeyDown(Key.F))
                        {
                            F_Button.Foreground = keyDownFG;
                            F_Button.Background = keyDownBG;
                        }
                        else
                        {
                            F_Button.Foreground = keyUpFG;
                            F_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.G:
                    {
                        if (Keyboard.IsKeyDown(Key.G))
                        {
                            G_Button.Foreground = keyDownFG;
                            G_Button.Background = keyDownBG;
                        }
                        else
                        {
                            G_Button.Foreground = keyUpFG;
                            G_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.H:
                    {
                        if (Keyboard.IsKeyDown(Key.H))
                        {
                            H_Button.Foreground = keyDownFG;
                            H_Button.Background = keyDownBG;
                        }
                        else
                        {
                            H_Button.Foreground = keyUpFG;
                            H_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.J:
                    {
                        if (Keyboard.IsKeyDown(Key.J))
                        {
                            J_Button.Foreground = keyDownFG;
                            J_Button.Background = keyDownBG;
                        }
                        else
                        {
                            J_Button.Foreground = keyUpFG;
                            J_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.K:
                    {
                        if (Keyboard.IsKeyDown(Key.K))
                        {
                            K_Button.Foreground = keyDownFG;
                            K_Button.Background = keyDownBG;
                        }
                        else
                        {
                            K_Button.Foreground = keyUpFG;
                            K_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.L:
                    {
                        if (Keyboard.IsKeyDown(Key.L))
                        {
                            L_Button.Foreground = keyDownFG;
                            L_Button.Background = keyDownBG;
                        }
                        else
                        {
                            L_Button.Foreground = keyUpFG;
                            L_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemSemicolon:
                    {
                        if (Keyboard.IsKeyDown(Key.OemSemicolon))
                        {
                            SemiCol_Button.Foreground = keyDownFG;
                            SemiCol_Button.Background = keyDownBG;
                        }
                        else
                        {
                            SemiCol_Button.Foreground = keyUpFG;
                            SemiCol_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemQuotes:
                    {
                        if (Keyboard.IsKeyDown(Key.OemQuotes))
                        {
                            Quote_Button.Foreground = keyDownFG;
                            Quote_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Quote_Button.Foreground = keyUpFG;
                            Quote_Button.Background = keyUpBG;
                        }
                        break;
                    }

                // Bottom Row Keybed
                case Key.Z:
                    {
                        if (Keyboard.IsKeyDown(Key.Z))
                        {
                            Z_Button.Foreground = keyDownFG;
                            Z_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Z_Button.Foreground = keyUpFG;
                            Z_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.X:
                    {
                        if (Keyboard.IsKeyDown(Key.X))
                        {
                            X_Button.Foreground = keyDownFG;
                            X_Button.Background = keyDownBG;
                        }
                        else
                        {
                            X_Button.Foreground = keyUpFG;
                            X_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.C:
                    {
                        if (Keyboard.IsKeyDown(Key.C))
                        {
                            C_Button.Foreground = keyDownFG;
                            C_Button.Background = keyDownBG;
                        }
                        else
                        {
                            C_Button.Foreground = keyUpFG;
                            C_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.V:
                    {
                        if (Keyboard.IsKeyDown(Key.V))
                        {
                            V_Button.Foreground = keyDownFG;
                            V_Button.Background = keyDownBG;
                        }
                        else
                        {
                            V_Button.Foreground = keyUpFG;
                            V_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.B:
                    {
                        if (Keyboard.IsKeyDown(Key.B))
                        {
                            B_Button.Foreground = keyDownFG;
                            B_Button.Background = keyDownBG;
                        }
                        else
                        {
                            B_Button.Foreground = keyUpFG;
                            B_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.N:
                    {
                        if (Keyboard.IsKeyDown(Key.N))
                        {
                            N_Button.Foreground = keyDownFG;
                            N_Button.Background = keyDownBG;
                        }
                        else
                        {
                            N_Button.Foreground = keyUpFG;
                            N_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.M:
                    {
                        if (Keyboard.IsKeyDown(Key.M))
                        {
                            M_Button.Foreground = keyDownFG;
                            M_Button.Background = keyDownBG;
                        }
                        else
                        {
                            M_Button.Foreground = keyUpFG;
                            M_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemComma:
                    {
                        if (Keyboard.IsKeyDown(Key.OemComma))
                        {
                            Comma_Button.Foreground = keyDownFG;
                            Comma_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Comma_Button.Foreground = keyUpFG;
                            Comma_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemPeriod:
                    {
                        if (Keyboard.IsKeyDown(Key.OemPeriod))
                        {
                            Period_Button.Foreground = keyDownFG;
                            Period_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Period_Button.Foreground = keyUpFG;
                            Period_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.OemQuestion:
                    {
                        if (Keyboard.IsKeyDown(Key.OemQuestion))
                        {
                            Question_Button.Foreground = keyDownFG;
                            Question_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Question_Button.Foreground = keyUpFG;
                            Question_Button.Background = keyUpBG;
                        }
                        break;
                    }
                //Function Keys

                // Enter Key
                case Key.Enter:
                    {
                        if (Keyboard.IsKeyDown(Key.Enter))
                        {
                            Enter_Button.Foreground = keyDownFG;
                            Enter_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Enter_Button.Foreground = keyUpFG;
                            Enter_Button.Background = keyUpBG;
                        }
                        break;
                    }

                // Space Key
                case Key.Space:
                    {
                        if (Keyboard.IsKeyDown(Key.Space))
                        {
                            Space_Button.Foreground = keyDownFG;
                            Space_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Space_Button.Foreground = keyUpFG;
                            Space_Button.Background = keyUpBG;
                        }
                        break;
                    }

                // Caps Lock Button
                case Key.CapsLock:
                    {
                        if (Keyboard.IsKeyToggled(Key.CapsLock))
                        {
                            Caps_Button.Foreground = keyDownFG;
                            Caps_Button.Background = keyDownBG;
                        }
                        else
                        {
                            Caps_Button.Foreground = keyUpFG;
                            Caps_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.LeftShift:
                    {
                        if (Keyboard.IsKeyDown(Key.LeftShift))
                        {
                            LShift_Button.Foreground = keyDownFG;
                            LShift_Button.Background = keyDownBG;
                        }
                        else
                        {
                            LShift_Button.Foreground = keyUpFG;
                            LShift_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.RightShift:
                    {
                        if (Keyboard.IsKeyDown(Key.RightShift))
                        {
                            RShift_Button.Foreground = keyDownFG;
                            RShift_Button.Background = keyDownBG;
                        }
                        else
                        {
                            RShift_Button.Foreground = keyUpFG;
                            RShift_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.LeftCtrl:
                    {
                        if (Keyboard.IsKeyDown(Key.LeftCtrl))
                        {
                            LControl_Button.Foreground = keyDownFG;
                            LControl_Button.Background = keyDownBG;
                        }
                        else
                        {
                            LControl_Button.Foreground = keyUpFG;
                            LControl_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.RightCtrl:
                    {
                        if (Keyboard.IsKeyDown(Key.RightCtrl))
                        {
                            RControl_Button.Foreground = keyDownFG;
                            RControl_Button.Background = keyDownBG;
                        }
                        else
                        {
                            RControl_Button.Foreground = keyUpFG;
                            RControl_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.LWin:
                    {
                        if (Keyboard.IsKeyDown(Key.LWin))
                        {
                            LWindow_Button.Foreground = keyDownFG;
                            LWindow_Button.Background = keyDownBG;
                        }
                        else
                        {
                            LWindow_Button.Foreground = keyUpFG;
                            LWindow_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.RWin:
                    {
                        if (Keyboard.IsKeyDown(Key.RWin))
                        {
                            RWindow_Button.Foreground = keyDownFG;
                            RWindow_Button.Background = keyDownBG;
                        }
                        else
                        {
                            RWindow_Button.Foreground = keyUpFG;
                            RWindow_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.LeftAlt:
                    {
                        if (Keyboard.IsKeyDown(Key.LeftAlt))
                        {
                            LAlt_Button.Foreground = keyDownFG;
                            LAlt_Button.Background = keyDownBG;
                        }
                        else
                        {
                            LAlt_Button.Foreground = keyUpFG;
                            LAlt_Button.Background = keyUpBG;
                        }
                        break;
                    }

                case Key.RightAlt:
                    {
                        if (Keyboard.IsKeyDown(Key.RightAlt))
                        {
                            RAlt_Button.Foreground = keyDownFG;
                            RAlt_Button.Background = keyDownBG;
                        }
                        else
                        {
                            RAlt_Button.Foreground = keyUpFG;
                            RAlt_Button.Background = keyUpBG;
                        }
                        break;
                    }
                case Key.Escape:
                    {
                        this.Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

    }
       
}
