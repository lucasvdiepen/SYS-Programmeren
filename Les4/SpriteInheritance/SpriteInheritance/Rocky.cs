using System.Drawing;

namespace Eindopdracht
{
    class Rocky : Sprite
    {
        public Rocky(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 239, 16, 16);
        }
    }
}
