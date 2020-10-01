using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearningProyect
{
    class Carta
    {
        private int points; 
        private String CardName;
        
        public Carta(String card)
        {
            this.CardName = card;
            String val = this.CardName.Substring(0, CardName.Length - 1);
            this.points = (isNumber(val)) ? Convert.ToInt32(val) :
                          (val == "A") ? 11 : 10;
        }
        private bool isNumber(String value)
        {
            return value.All(char.IsNumber);
        }

        public int getPoints() => this.points;

        public Rectangle createCard()
        {
            Rectangle cardRectangle = new Rectangle();
            BitmapImage imagen = new BitmapImage(
                    new Uri($"../../Assets/Cartas/{ this.CardName }.png", UriKind.Relative)
                );
            ImageBrush imagenBrush = new ImageBrush(imagen);
            imagenBrush.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            imagenBrush.Stretch = Stretch.Fill;
            cardRectangle.Fill = imagenBrush;
            cardRectangle.MouseEnter += (s, e) =>
            {
                animation_Hover_Card(cardRectangle);
            };
            cardRectangle.MouseLeave += (s, e) =>
            {
                animation_Unhovered_Card(cardRectangle);
            };
            return cardRectangle;
        }
        private void animation_Hover_Card(Rectangle card)
        {
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            heightAnimation.To = 150;
            Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(Rectangle.HeightProperty));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(heightAnimation);
            storyboard.Begin(card);
        }

        private void animation_Unhovered_Card(Rectangle card)
        {
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.7));
            heightAnimation.To = 120;
            Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(Rectangle.HeightProperty));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(heightAnimation);
            storyboard.Begin(card);
        }
    }
}
