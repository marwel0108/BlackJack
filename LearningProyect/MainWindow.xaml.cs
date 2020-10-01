using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;

namespace LearningProyect
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Baraja bar = new Baraja();
        Jugador jugador = new Jugador();
        Jugador pc = new Jugador();
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            StopGame.IsEnabled = false;
            StopGame.Opacity = 0.7;
        }
        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            bar.mixDeck();
        }
        private void btn_AddCard_Click(object sender, RoutedEventArgs e)
        {
            if (!StopGame.IsEnabled)
            {
                animateOpacity_Enabled(StopGame);
                StopGame.IsEnabled = true;
            }
            Carta card = bar.askCard();
            Rectangle recCard = card.createCard();
            jugador.sumPoints(card);
            PlayerZone.Children.Add(recCard);
            pPoints.Content = $"Tus puntos: {jugador.Points}";

            if (jugador.Points > 21)
            {
                animateOpacity_Disabled(AddCard);
                AddCard.IsEnabled = false;
                animateOpacity_Disabled(StopGame);
                StopGame.IsEnabled = false;
                pcLogic(jugador.Points);
            } else if (jugador.Points == 21)
            {
                animateOpacity_Disabled(AddCard);
                AddCard.IsEnabled = false;
                animateOpacity_Disabled(StopGame);
                StopGame.IsEnabled = false;
                pcLogic(jugador.Points);
            }
        }

        private void btn_AddCard_MouseEnter(object sender, MouseEventArgs e) => btn_Hovered(AddCard);

        private void btn_AddCard_MouseLeave(object sender, MouseEventArgs e) => btn_Unhovered(AddCard);

        private void btn_StopGame_Click(object sender, RoutedEventArgs e)
        {
            animateOpacity_Disabled(AddCard);
            AddCard.IsEnabled = false;
            animateOpacity_Disabled(StopGame);
            StopGame.IsEnabled = false;
            pcLogic(jugador.Points);
        }

        private void btn_StopGame_MouseEnter(object sender, MouseEventArgs e) => btn_Hovered(StopGame);

        private void btn_StopGame_MouseLeave(object sender, MouseEventArgs e) => btn_Unhovered(StopGame);

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            bar.emptyMixedDeck();
            bar.mixDeck();
            jugador.setPoints(0);
            pPoints.Content = $"Tus puntos: {jugador.Points}";
            pc.setPoints(0);
            pcPoints.Content = $"Puntos de pc: {pc.Points}";
            animateOpacity_Enabled(AddCard);
            AddCard.IsEnabled = true;
            animateOpacity_Enabled(StopGame);
            StopGame.IsEnabled = true;
            PlayerZone.Children.Clear();
            PCZone.Children.Clear();
        }

        private void btn_Reset_MouseEnter(object sender, MouseEventArgs e) => btn_Hovered(Reset);

        private void btn_Reset_MouseLeave(object sender, MouseEventArgs e) => btn_Unhovered(Reset);

        private void btn_Quit_Click(object sender, RoutedEventArgs e) => App.Current.Shutdown();
        private void btn_Quit_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation btnHAnimation = new DoubleAnimation();
            btnHAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnHAnimation.To = 40;
            DoubleAnimation btnWAnimation = new DoubleAnimation();
            btnWAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnWAnimation.To = 40;
            Quit.BeginAnimation(Button.HeightProperty, btnHAnimation);
            Quit.BeginAnimation(Button.WidthProperty, btnHAnimation);
        }
        private void btn_Quit_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation btnHAnimation = new DoubleAnimation();
            btnHAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnHAnimation.To = 35;
            DoubleAnimation btnWAnimation = new DoubleAnimation();
            btnWAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnWAnimation.To = 35;
            Quit.BeginAnimation(Button.HeightProperty, btnHAnimation);
            Quit.BeginAnimation(Button.WidthProperty, btnHAnimation);
        }

        private void border_playerZoneBorder_Enter(object sender, MouseEventArgs e) => border_Hovered(playerZoneBorder);

        private void border_playerZoneBorder_Leave(object sender, MouseEventArgs e) => border_Unhovered(playerZoneBorder);

        private void border_pcZoneBorder_Enter(object sender, MouseEventArgs e) => border_Hovered(pcZoneBorder);

        private void border_pcZoneBorder_Leave(object sender, MouseEventArgs e) => border_Unhovered(pcZoneBorder);

        private void btn_Hovered(Button btn)
        {
            DoubleAnimation btnHAnimation = new DoubleAnimation();
            btnHAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnHAnimation.To = 50;
            btn.BeginAnimation(Button.HeightProperty, btnHAnimation);
        }

        private void btn_Unhovered(Button btn)
        {
            DoubleAnimation btnHAnimation = new DoubleAnimation();
            btnHAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            btnHAnimation.To = 40;
            btn.BeginAnimation(Button.HeightProperty, btnHAnimation);
        }

        private void animateOpacity_Disabled(Button btn)
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            opacityAnimation.To = 0.7;
            btn.BeginAnimation(Button.OpacityProperty, opacityAnimation);
        }

        private void animateOpacity_Enabled(Button btn)
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            opacityAnimation.To = 1;
            btn.BeginAnimation(Button.OpacityProperty, opacityAnimation);
        }

        private void border_Hovered(Border panelBord) => panelBord.BorderBrush = new SolidColorBrush(Color.FromRgb(136, 243, 106));

        private void border_Unhovered(Border panelBord) => panelBord.BorderBrush = new SolidColorBrush(Color.FromRgb(13, 59, 0));

        private void pcLogic(int minimunPoints)
        {
            timer.Start();
            if ( pc.Points == minimunPoints)
            {
                MessageBox.Show("Ha sido un empate");
            } else if (minimunPoints > 21)
            {
                MessageBox.Show("PC ha ganado");
                pc.sumWins();
                pcRounds.Content = pc.Wins;
            } else if( pc.Points > 21 || minimunPoints == 21)
            {
                MessageBox.Show("Jugador ha ganado");
                jugador.sumWins();
                playerRounds.Content = jugador.Wins;
            } else
            {
                if(minimunPoints < 21 && pc.Points > 21)
                {
                    MessageBox.Show("Jugador ha ganado");
                    jugador.sumWins();
                    playerRounds.Content = jugador.Wins;
                } else if((minimunPoints > 21 && pc.Points > 21) && minimunPoints < pc.Points)
                {
                    MessageBox.Show("Jugador ha ganado");
                    jugador.sumWins();
                    playerRounds.Content = jugador.Wins;
                } else if((minimunPoints < 21 && pc.Points < 21) && minimunPoints > pc.Points)
                {
                    MessageBox.Show("Jugador ha ganado");
                    jugador.sumWins();
                    playerRounds.Content = jugador.Wins;
                } else if ((minimunPoints < 21 && pc.Points < 21) && minimunPoints < pc.Points)
                {
                    MessageBox.Show("PC ha ganado");
                    MessageBox.Show("PC ha ganado");
                    pc.sumWins();
                    pcRounds.Content = pc.Wins;
                }
                
            }
        }

        private void timeSpawnCards(int minimunPoints)
        {
            if ((pc.Points < minimunPoints) && (minimunPoints <= 21))
            {
                Carta card = bar.askCard();
                Rectangle recCard = card.createCard();
                pc.sumPoints(card);
                PCZone.Children.Add(recCard);
                pcPoints.Content = $"Puntos de pc: {pc.Points}";
                if (minimunPoints > 21)
                {
                    timer.Stop();
                    return;
                }
            } else
            {
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeSpawnCards(jugador.Points);
        }
    }
}
