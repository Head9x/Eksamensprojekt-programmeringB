using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics.Platform;

namespace Eksamensprojekt.Drawables
{
    public class MapIcon : IDrawable
    {

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Microsoft.Maui.Graphics.IImage image;
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("Eksamensprojekt.Resources.Images.h20x.png"))
            {
                image = PlatformImage.FromStream(stream);
            }

            if (image != null)
            {
                Microsoft.Maui.Graphics.IImage newImage = image.Downsize(750, true);
                canvas.DrawImage(newImage, 10, 10, newImage.Width, newImage.Height);
            }
            
            DateTime curTime = DateTime.Now;
            var clockCenterPoint = new PointF(100, 600);
            var circleRadius = 50;


            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 6;

            canvas.DrawCircle(clockCenterPoint, circleRadius);
            canvas.DrawCircle(clockCenterPoint, 5);

            canvas.StrokeSize = 4;
            var hourPoint = GetHourHand(curTime, circleRadius, clockCenterPoint);
            canvas.DrawLine(clockCenterPoint, hourPoint);


            var minutePoint = GetMinuteHand(curTime, circleRadius, clockCenterPoint);
            canvas.DrawLine(clockCenterPoint, minutePoint);

            var secondPoint = GetSecondHand(curTime, circleRadius, clockCenterPoint);
            canvas.DrawLine(clockCenterPoint, secondPoint);

            

        }

        internal static PointF GetHourHand(DateTime curTime, int radius, PointF center)
        {

            int currentHour = curTime.Hour;

            if (currentHour > 12)
                currentHour -= 12;

            var angleDegrees = (currentHour * 360) / 12;
            var angle = (Math.PI / 180.0) * angleDegrees;

            var hourShorter = radius * .8;
            PointF outerPoint = new((float)(hourShorter * Math.Sin(angle)) + center.X, (float)(-hourShorter * Math.Cos(angle)) + center.Y);

            return outerPoint;
        }

        internal static PointF GetMinuteHand(DateTime curTime, int radius, PointF center)
        {

            int currentMin = curTime.Minute;

            var angleDegrees = (currentMin * 360) / 60;
            var angle = (Math.PI / 180.0) * angleDegrees;

            PointF outerPoint = new((float)(radius * Math.Sin(angle)) + center.X, (float)(-radius * Math.Cos(angle)) + center.Y);

            return outerPoint;
        }

        internal static PointF GetSecondHand(DateTime curTime, int radius, PointF center)
        {

            int currentSecond = curTime.Second;

            var angleDegrees = (currentSecond * 360) / 60;
            var angle = (Math.PI / 180.0) * angleDegrees;

            PointF outerPoint = new((float)(radius * Math.Sin(angle) + center.X), (float)(-radius * Math.Cos(angle)) + center.Y);

            return outerPoint;
        }
    }
}
