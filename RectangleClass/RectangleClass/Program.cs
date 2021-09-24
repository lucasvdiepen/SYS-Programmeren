using System;

namespace RectangleClass
{
    class Program
    {
        private class Rectangle
        {
            private float _x = 0f;
            private float _y = 0f;
            private float _width = 0f;
            private float _height = 0f;

            public Rectangle(float x, float y, float height, float width)
            {
                _x = x;
                _y = y;
                _height = height;
                _width = width;
            }

            public Rectangle(float x, float y, float size)
            {
                _x = x;
                _y = y;
                _height = size;
                _width = size;
            }

            public Rectangle(float width, float height)
            {
                _width = width;
                _height = height;
            }

            public Rectangle(float size)
            {
                _width = size;
                _height = size;
            }

            public void MoveTo(float x, float y)
            {
                _x = x;
                _y = y;
            }

            public bool IsSquare()
            {
                return _width == _height;
            }

            public void Set(float x, float y, float width, float height)
            {
                _x = x;
                _y = y;
                _width = width;
                _height = height;
            }

            public float GetWidth()
            {
                return _width;
            }

            public float GetHeight()
            {
                return _height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 50);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.Set(100, 100, rechthoek.GetWidth(), rechthoek.GetHeight());
        }
    }
}
