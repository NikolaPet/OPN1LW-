using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OPN1LW_v1._2
{
    public class Protein
    {
        int X { get; set; } // X koordinata na proteinot
        int Y { get; set; } // Y koordinata na proteinot

        int initialX { get; set; }
        int initialY { get; set; }

        int finalX { get; set; }
        int finalY { get; set; }

        int radius { get; set; } // zavisi od toa kolku nukletodi sodrzi sekvencijata

        Brush brush; // chetka so koja se boi proteinot

        public String name { get; set; }

        public String description { get; set; }

        public Boolean isSelected = false;
        public Boolean lastSelected = false;
        public Boolean isBound = false;
        public Boolean isClickable = true;

        public String instructionText { get; set; }
        public String correctText { get; set; }
        public String incorrectText { get; set; }

        public String additionalInfo { get; set; }
        public String sequence { get; set; }

        public int direction = 0; // 1 e napred, 2 e nazad

        public Boolean hasSecondaryProtein = false;

        public int secondaryProteinX;
        public int secondaryProteinY;

        public Color color { get; set; }

        public Protein()
        {
            // za DoubleClick metodot
        }
     
        public Protein(String name, String description, int X, int Y, int finalX, int finalY, int radius, Color color, Boolean hasSecondaryProtein) // bojata ja zadavame vo konstruktorot
        {
            this.name = name;
            this.description = description;
            this.X = X;
            this.Y = Y;
            this.initialX = X;
            this.initialY = Y;
            this.finalX = finalX;
            this.finalY = finalY;
            this.radius = radius;
            brush = new SolidBrush(color);
            instructionText = "";
            correctText = "Одлично!";
            incorrectText = "Грешка. Обидете се повторно.";
            additionalInfo = "";
            this.hasSecondaryProtein = hasSecondaryProtein;
            this.secondaryProteinX = 0;
            this.secondaryProteinY = 0;
            this.color = color;
        }

        public void setSecondaryProteinInfo(int x, int y)
        {
            secondaryProteinX = x;
            secondaryProteinY = y;
        }

        public void Draw(Graphics g)
        {
            
            if (isSelected && isClickable)
            {
                Pen pen = new Pen(Brushes.Salmon, 5);
                g.DrawEllipse(pen, X - radius, Y - radius, radius * 2, radius * 2);
                pen.Dispose();
            }
            
            g.FillEllipse(brush, X - radius, Y - radius, radius * 2, radius * 2);
        }

        public static float Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public void Select(Point point)
        {
            if (isClickable)
            {
                if (Distance(point, new Point(X, Y)) <= radius * radius)
                {
                    lastSelected = true;
                    isSelected = !isSelected;
                }
            }
        }

        

        public void MoveForward(int step)
        {
            X += ((finalX - X) * step) / 100;
            Y += ((finalY - Y) * step) / 100;
        }

        public void MoveBackward(int step)
        {
            X += ((initialX - X) * step) / 100;
            Y += ((initialY - Y) * step) / 100;
        }

        



    }
}
